using System.Net.Http;
using System.Threading.Tasks;

namespace WebDooreme.ServicesGoogle
{ 

    public interface IGoogleIndexService
    {
        public interface IGoogleIndexService
        {
            Task<HttpResponseMessage> PostUrlToGoogle(string Url, GoogleIndexAction action);
        }

        public enum GoogleIndexAction
        {
            URL_UPDATED,
            URL_DELETED
        }
    }
}
