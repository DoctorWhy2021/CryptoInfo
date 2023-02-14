using System.Collections.Generic;

namespace CryptoInfo.MVVM.Model;

public class CoinModel
{
    public string Id { get; set; }
    
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public double Current_price { get; set; }

    public double Price_change_percentage_24h { get; set; }

    public double Total_volume { get; set; }

    public double[] Price { get; set; }

    }

