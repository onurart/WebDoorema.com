using Newtonsoft.Json;
using static WebDooreme.ServicesGoogle.IGoogleIndexService;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;

namespace WebDooreme.ServicesGoogle
{
    public class GoogleIndexService: IGoogleIndexService
    {
        private GoogleCredential googleCredential;
        private readonly string googleAPIUrl;

        public GoogleIndexService()
        {
            googleAPIUrl = "https://www.googleapis.com/robot/v1/metadata/x509/dooremaindexapi%40doorema-366409.iam.gserviceaccount.com";
        }

        private GoogleCredential GetGoogleCredential()
        {
            var path = @"doorema-366409-1a66e0e226be.json";
            GoogleCredential credential;

            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(new[] { "https://www.googleapis.com/auth/indexing" });
            }

            return credential;
        }

        public async Task<HttpResponseMessage> PostUrlToGoogle(string Url, GoogleIndexAction action)
        {
            googleCredential = GetGoogleCredential();

            var serviceAccountCredential = (ServiceAccountCredential)googleCredential.UnderlyingCredential;

            var gAction = action.ToString();

            var requestBody = new
            {
                url = Url,
                type = gAction
            };

            var httpClientHandler = new HttpClientHandler();
            var cMessageHandler = new ConfigurableMessageHandler(httpClientHandler);
            var configurableHttpClient = new ConfigurableHttpClient(cMessageHandler);
            serviceAccountCredential.Initialize(configurableHttpClient);

            HttpContent content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
            var response = await configurableHttpClient.PostAsync(new Uri(googleAPIUrl), content);

            return response;
        }
    }
}