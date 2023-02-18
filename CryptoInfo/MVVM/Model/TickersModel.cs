using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CryptoInfo.MVVM.Model;

public class TickersModel
{
    
    [JsonProperty("tickers", NullValueHandling = NullValueHandling.Ignore)]
    public Ticker[] Tickers { get; set; }
    
}

public class Ticker
{
    //What currency you change
    [JsonProperty("base")]
    public string? Base { get; set; }
    //Target currency
    [JsonProperty("target")]
    public string? Target { get; set; }
    //Market info
    [JsonProperty("market", NullValueHandling = NullValueHandling.Ignore)]
    public Market? Market { get; set; }
    //Last price
    [JsonProperty("last")]
    public decimal? Last { get; set; }
    
    //Volume in USD
    [JsonProperty("converted_volume")]
    public Dictionary<string, decimal> Converted_volume { get; set; }
    //Market Trust score
    [JsonProperty("trust_score")]
    public string? Trust_score { get; set; }
    //Spread
    [JsonProperty("bid_ask_spread_percentage")]
    public double? Bid_ask_spread_percentage { get; set; }
    
    [JsonProperty("trade_url")]
    public Uri? Trade_url { get; set; }
    [JsonProperty("coin_id")]
    public string? coin_id { get; set; }
    [JsonProperty("target_coin_id")]
    public string? target_coin_id { get; set; }
}
    
public class Market
{
    [JsonProperty("name")]
    public string? Name { get; set; }
    [JsonProperty("logo")]
    public Uri? Logo { get; set; }
}

public class Converted_volume
{
    [JsonProperty("usd")]
    public long? Usd { get; set; }
}
