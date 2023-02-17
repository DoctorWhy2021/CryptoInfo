using System;
using Newtonsoft.Json;

namespace CryptoInfo.MVVM.Model;

public class ShortCoinModel
{
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("symbol")]
    public string Symbol { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("image")]
    public Uri Image { get; set; }
}