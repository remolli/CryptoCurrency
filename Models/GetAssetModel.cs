namespace CryptoCurrency.Models
{
    public class GetAssetModel
    {
        public string asset_id { get; set; }
        public string name { get; set; }
        public string type_is_crypto { get; set; }
        public string data_start { get; set; }
        public string data_end { get; set; }
        public string data_quote_start { get; set; }
        public string data_quote_end { get; set; }
        public string data_orderbook_start { get; set; }
        public string data_orderbook_end { get; set; }
        public string data_trade_start { get; set; }
        public string data_trade_end { get; set; }
        public string data_symbols_count { get; set; }
        public string volume_1hrs_usd { get; set; }
        public string volume_1day_usd { get; set; }
        public string volume_1mth_usd { get; set; }
        public string price_usd { get; set; }
    }
}