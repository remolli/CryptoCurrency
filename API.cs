using CryptoCurrency.Models;
using RestSharp;

namespace CryptoCurrency
{
    public class API
    {
        RestClient client;
        public API()
        {
            var options = new RestClientOptions("https://api.coincap.io/v2");
            client = new RestClient(options);
        }
        public async Task<GetAssetsModel> GetAssetsAsync()
        {
            var request = new RestRequest($"/assets");
            request.AddHeader("Authorization", "Bearer7b46f726-cc15-4d61-92c1-778ee01669d0");
            var requestDeserialized = await client.GetAsync<GetAssetsModel>(request);
            return requestDeserialized;
        }
    }
}
