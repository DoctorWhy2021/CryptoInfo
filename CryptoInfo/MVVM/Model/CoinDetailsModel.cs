namespace CryptoInfo.MVVM.Model;

public class CoinDetailsModel
{
    public string Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    // public Image? image { get; set; }
    // public int Market_cap_rank { get; set; }
    // public Market_data? Market_data { get; set; }

}

// public class Links
// {
//     public string[] homepage { get; set; }
//     public string[] blockchain_site { get; set; }
//     public string[] official_forum_url { get; set; }
//     public string[] chat_url { get; set; }
//     public string[] announcement_url { get; set; }
//     public string twitter_screen_name { get; set; }
//     public string facebook_username { get; set; }
//     public object bitcointalk_thread_identifier { get; set; }
//     public string telegram_channel_identifier { get; set; }
//     public string subreddit_url { get; set; }
//     public Repos_url repos_url { get; set; }
// }
//
// public class Repos_url
// {
//     public string[] github { get; set; }
//     public object[] bitbucket { get; set; }
// }

public class Image
{
    public string Thumb { get; set; }
    public string Small { get; set; }
    public string Large { get; set; }
}

public class Market_data
{
    public Current_price? Current_price { get; set; }
    public Market_cap Market_cap { get; set; }
    public Total_volume Total_volume { get; set; }
    public High_24h? High_24h { get; set; }
    public Low_24h? Low_24h { get; set; }
    public long Price_change_24h { get; set; }
    public double Price_change_percentage_24h { get; set; }
    public long Market_cap_change_24h { get; set; }
    public double Market_cap_change_percentage_24h { get; set; }
    public double Total_supply { get; set; }
}

public class Current_price
{
    public double Usd { get; set; }
    public double Btc { get; set; }
}

public class Market_cap
{
    public long Usd { get; set; }
}

public class Total_volume
{
    public long Usd { get; set; }
}

public class High_24h
{
    public double Usd { get; set; }
}

public class Low_24h
{
    public double Usd { get; set; }
}