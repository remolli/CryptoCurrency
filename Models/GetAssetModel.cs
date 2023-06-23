namespace CryptoCurrency.Models
{
    public class GetAssetModel
    {
        public string asset_id { get; set; }
        public string name { get; set; }
        public long type_is_crypto { get; set; }
        public DateTimeOffset data_start { get; set; }
        public DateTimeOffset data_end { get; set; }
        public DateTimeOffset data_quote_start { get; set; }
        public DateTimeOffset data_quote_end { get; set; }
        public DateTimeOffset data_orderbook_start { get; set; }
        public DateTimeOffset data_orderbook_end { get; set; }
        public DateTimeOffset data_trade_start { get; set; }
        public DateTimeOffset data_trade_end { get; set; }
        public long data_symbols_count { get; set; }
        public double volume_1hrs_usd { get; set; }
        public double volume_1day_usd { get; set; }
        public double volume_1mth_usd { get; set; }
        public double price_usd { get; set; }
    }
}