namespace CryptoInfo.MVVM.Model;

public class TickersModel
{
    public Ticker[] Tickers { get; set; }
    
}

public class Ticker
{
    //What currency you change
    public string Base { get; set; }
    //Target currency
    public string Target { get; set; }
    //Market info
    public Market Market { get; set; }
    //Last price
    public double Last { get; set; }
    //Volume in USD
    public Converted_volume Converted_volume { get; set; }
    //Market Trust score
    public string Trust_score { get; set; }
    //Spread
    public double Bid_ask_spread_percentage { get; set; }
    public string Trade_url { get; set; }
    public string coin_id { get; set; }
    public string target_coin_id { get; set; }
}
    
public class Market
{
    public string Name { get; set; }
    public string Logo { get; set; }
}

public class Converted_volume
{
    public long Usd { get; set; }
}
