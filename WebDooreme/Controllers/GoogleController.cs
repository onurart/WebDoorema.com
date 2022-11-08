using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System;
using System.Web.Http;
using WebDooreme.ServicesGoogle;
using static WebDooreme.ServicesGoogle.IGoogleIndexService;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebDooreme.Controllers
{
    public class GoogleController : ApiController
    {
        private GoogleIndexService googleIndexService;

        public GoogleController()
        {
            googleIndexService = new GoogleIndexService();
        }
         [OverrideAuthentication]
        [OverrideAuthorization]
        [Route("SendUrlToGoogle")]
        [HttpPost]
        public HttpResponseMessage SendUrlToGoogle(string url)
        {
            try
            {
                var response = PostUrlToGoogle(url, GoogleIndexAction.URL_UPDATED).GetAwaiter().GetResult();
                var message = response.Content.ReadAsStringAsync().Result;

                return Request.CreateResponse(HttpStatusCode.OK, message);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        private async Task<HttpResponseMessage> PostUrlToGoogle(string url, GoogleIndexAction action)
        {
            var response = await googleIndexService.PostUrlToGoogle(url, action);

            return response;
        }
    }
}