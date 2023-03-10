using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CryptoInfo.MVVM.Model;

public class CoinDetailsModel
{
    [JsonProperty("id")]
    public string id { get; set; }
    [JsonProperty("symbol")]
    public string symbol { get; set; }
    [JsonProperty("name")]
    public string name { get; set; }
    [JsonProperty("image")]
    public Image image { get; set; }
    [JsonProperty("market_cap_rank")]
    public int? market_cap_rank { get; set; }
    [JsonProperty("market_data", NullValueHandling = NullValueHandling.Ignore)]
    public Market_data? market_data { get; set; }
}

public class Image
{
    [JsonProperty("thumb")]
    public Uri? thumb { get; set; }
    [JsonProperty("small")]
    public Uri? small { get; set; }
    [JsonProperty("large")]
    public Uri? large { get; set; }
}

public class Market_data
{
    [JsonProperty("current_price")]
    public Dictionary<string, decimal>? current_price { get; set; }
    [JsonProperty("market_cap")]
    public Dictionary<string, decimal>? market_cap { get; set; }
    [JsonProperty("total_volume")]
    public Dictionary<string, decimal>? total_volume { get; set; }
    [JsonProperty("high_24h")]
    public Dictionary<string, decimal>? high_24h { get; set; }
    [JsonProperty("low_24h")]
    public Dictionary<string, decimal>? low_24h { get; set; }
    [JsonProperty("price_change_24h")]
    public decimal? price_change_24h { get; set; }
    [JsonProperty("price_change_percentage_24h")]
    public double? price_change_percentage_24h { get; set; }
    [JsonProperty("market_cap_change_24h")]
    public decimal? market_cap_change_24h { get; set; }
    [JsonProperty("market_cap_change_percentage_24h")]
    public double? market_cap_change_percentage_24h { get; set; }
    [JsonProperty("price_change_24h_in_currency")]
    public Dictionary<string, decimal>? price_change_24h_in_currency { get; set; }
    [JsonProperty("price_change_percentage_24h_in_currency")]
    public Dictionary<string, double>? price_change_percentage_24h_in_currency { get; set; }
    [JsonProperty("market_cap_change_24h_in_currency")]
    public Dictionary<string, decimal>? market_cap_change_24h_in_currency { get; set; }
    [JsonProperty("market_cap_change_percentage_24h_in_currency")]
    public Dictionary<string, double>? market_cap_change_percentage_24h_in_currency { get; set; }
    [JsonProperty("total_supply")]
    public decimal? total_supply { get; set; }
}





























