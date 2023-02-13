using System.Collections.Generic;

namespace CryptoInfo.MVVM.Model;

public class CoinModel
{
    public string id { get; set; }
    
    public string symbol { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public double current_price { get; set; }

    public double price_change_percentage_24h { get; set; }

    public double total_volume { get; set; }

    public double[] Price { get; set; }

    }

