using System.Net.Http;
using System.Threading.Tasks;

namespace GDAXClient.HttpClient
{
    public class HttpClient : IHttpClient
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<HttpResponseMessage> SendASync(HttpRequestMessage httpRequestMessage)
        {
                var result = await Client.SendASync(httpRequestMessage);
                return result;
        }

        public async Task<string> ReadAsStringAsync(HttpResponseMessage httpRequestMessage)
        {
            var result = await httpRequestMessage.Content.ReadAsStringAsync();
            return result;
        }
    }
}
