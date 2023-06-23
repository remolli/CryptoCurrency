using CryptoCurrency.Models;
using RestSharp;

namespace CryptoCurrency
{
    public class API
    {
        RestClient client;
        public API()
        {
            var options = new RestClientOptions("https://rest.coinapi.io");
            client = new RestClient(options);
        }
        public async Task<GetExchangeRateModel> GetExchangeRateAsync(string asset_id_base)
        {
            var request = new RestRequest($"/v1/exchangerate/{asset_id_base}");
            request.AddHeader("X-CoinAPI-Key", "11CA632B-F6B4-419E-8E88-65246C594C97");
            var requestDeserialized = await client.GetAsync<GetExchangeRateModel>(request);
            return requestDeserialized;
        }
        public async Task<GetAssetModel[]> GetAssetsAsync()
        {
            var request = new RestRequest($"/v1/assets");
            request.AddHeader("X-CoinAPI-Key", "11CA632B-F6B4-419E-8E88-65246C594C97");
            var requestDeserialized = await client.GetAsync<GetAssetModel[]>(request);
            return requestDeserialized;
        }
        public async Task<GetAssetModel> GetAssetAsync(string asset_id)
        {
            var request = new RestRequest($"/v1/assets/{asset_id}");
            request.AddHeader("X-CoinAPI-Key", "11CA632B-F6B4-419E-8E88-65246C594C97");
            var requestDeserialized = await client.GetAsync<GetAssetModel>(request);
            return requestDeserialized;
        }
    }
}
