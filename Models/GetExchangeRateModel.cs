namespace CryptoCurrency.Models
{
    public class GetExchangeRateModel
    {
        public string asset_id_base { get; set; }
        public RateUnit[] rates { get; set; }
    }
    public class RateUnit
    {
        public string time { get; set; }
        public string asset_id_quote { get; set; }
        public double rate { get; set; }
    }
}
