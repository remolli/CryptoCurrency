namespace CryptoCurrency.Models
{
    public class GetAssetsModel
    {
        public AssetModel[]? data { get; set; }
        public decimal timestamp { get; set; }
    }
    public class AssetModel
    {
        public string id { get; set; }
        public int rank { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public decimal supply { get; set; }
        public decimal? maxSupply { get; set; }
        public decimal marketCapUsd { get; set; }
        public decimal volumeUsd24Hr { get; set; }
        public decimal priceUsd { get; set; }
        public decimal changePercent24Hr { get; set; }
        public decimal? vwap24Hr { get; set; }
        public string explorer { get; set; }
    }
}
