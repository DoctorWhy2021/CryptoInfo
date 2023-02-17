namespace CryptoInfo.MVVM.Model;

public class TestModel
{
    public string id { get; set; }
    public string symbol { get; set; }
    public string name { get; set; }
    // public Links links { get; set; }
    public Image image { get; set; }
    public int market_cap_rank { get; set; }
    public Market_data market_data { get; set; }


    public class Links
    {
        public string[] homepage { get; set; }
        public string[] blockchain_site { get; set; }
        public string[] official_forum_url { get; set; }
        public string[] chat_url { get; set; }
        public string[] announcement_url { get; set; }
        public string twitter_screen_name { get; set; }
        public string facebook_username { get; set; }
        public object bitcointalk_thread_identifier { get; set; }
        public string telegram_channel_identifier { get; set; }
        public string subreddit_url { get; set; }
        public Repos_url repos_url { get; set; }
    }

    public partial class Repos_url
    {
        public string[] github { get; set; }
        public object[] bitbucket { get; set; }
    }

    public class Image
    {
        public string thumb { get; set; }
        public string small { get; set; }
        public string large { get; set; }
    }

    public class Market_data
    {
        public Current_price current_price { get; set; }
        // public Market_cap market_cap { get; set; }
        // public Total_volume total_volume { get; set; }
        // public High_24h high_24h { get; set; }
        // public Low_24h low_24h { get; set; }
        public double price_change_24h { get; set; }
        public double price_change_percentage_24h { get; set; }
        public long market_cap_change_24h { get; set; }
        public double market_cap_change_percentage_24h { get; set; }
        // public Price_change_24h_in_currency price_change_24h_in_currency { get; set; }
        // public Price_change_percentage_24h_in_currency price_change_percentage_24h_in_currency { get; set; }
        // public Market_cap_change_24h_in_currency market_cap_change_24h_in_currency { get; set; }
        // public Market_cap_change_percentage_24h_in_currency market_cap_change_percentage_24h_in_currency { get; set; }
        public double total_supply { get; set; }
    }

    public class Current_price
    {
        public double uah { get; set; }
        public double usd { get; set; }
    }


    public partial class Market_cap
    {
        public long aed { get; set; }
        public long ars { get; set; }
        public long aud { get; set; }
        public long bch { get; set; }
        public long bdt { get; set; }
        public long bhd { get; set; }
        public long bmd { get; set; }
        public int bnb { get; set; }
        public long brl { get; set; }
        public int btc { get; set; }
        public long cad { get; set; }
        public long chf { get; set; }
        public long clp { get; set; }
        public long cny { get; set; }
        public long czk { get; set; }
        public long dkk { get; set; }
        public long dot { get; set; }
        public long eos { get; set; }
        public int eth { get; set; }
        public long eur { get; set; }
        public long gbp { get; set; }
        public long hkd { get; set; }
        public long huf { get; set; }
        public long idr { get; set; }
        public long ils { get; set; }
        public long inr { get; set; }
        public long jpy { get; set; }
        public long krw { get; set; }
        public long kwd { get; set; }
        public long lkr { get; set; }
        public long ltc { get; set; }
        public long mmk { get; set; }
        public long mxn { get; set; }
        public long myr { get; set; }
        public long ngn { get; set; }
        public long nok { get; set; }
        public long nzd { get; set; }
        public long php { get; set; }
        public long pkr { get; set; }
        public long pln { get; set; }
        public long rub { get; set; }
        public long sar { get; set; }
        public long sek { get; set; }
        public long sgd { get; set; }
        public long thb { get; set; }
        public long twd { get; set; }
        public long uah { get; set; }
        public long usd { get; set; }
        public long vef { get; set; }
        public long vnd { get; set; }
        public long xag { get; set; }
        public int xau { get; set; }
        public long xdr { get; set; }
        public long xlm { get; set; }
        public long xrp { get; set; }
        public int yfi { get; set; }
        public long zar { get; set; }
        public long bits { get; set; }
        public long link { get; set; }
        public long sats { get; set; }
    }


    public partial class Total_volume
    {
        public long aed { get; set; }
        public long ars { get; set; }
        public long aud { get; set; }
        public int bch { get; set; }
        public long bdt { get; set; }
        public long bhd { get; set; }
        public long bmd { get; set; }
        public int bnb { get; set; }
        public long brl { get; set; }
        public int btc { get; set; }
        public long cad { get; set; }
        public long chf { get; set; }
        public long clp { get; set; }
        public long cny { get; set; }
        public long czk { get; set; }
        public long dkk { get; set; }
        public long dot { get; set; }
        public long eos { get; set; }
        public int eth { get; set; }
        public long eur { get; set; }
        public long gbp { get; set; }
        public long hkd { get; set; }
        public long huf { get; set; }
        public long idr { get; set; }
        public long ils { get; set; }
        public long inr { get; set; }
        public long jpy { get; set; }
        public long krw { get; set; }
        public long kwd { get; set; }
        public long lkr { get; set; }
        public int ltc { get; set; }
        public long mmk { get; set; }
        public long mxn { get; set; }
        public long myr { get; set; }
        public long ngn { get; set; }
        public long nok { get; set; }
        public long nzd { get; set; }
        public long php { get; set; }
        public long pkr { get; set; }
        public long pln { get; set; }
        public long rub { get; set; }
        public long sar { get; set; }
        public long sek { get; set; }
        public long sgd { get; set; }
        public long thb { get; set; }
        public long twd { get; set; }
        public long uah { get; set; }
        public long usd { get; set; }
        public long vef { get; set; }
        public long vnd { get; set; }
        public long xag { get; set; }
        public int xau { get; set; }
        public long xdr { get; set; }
        public long xlm { get; set; }
        public long xrp { get; set; }
        public int yfi { get; set; }
        public long zar { get; set; }
        public long bits { get; set; }
        public long link { get; set; }
        public long sats { get; set; }
    }

    public partial class High_24h
    {
        public int aed { get; set; }
        public int ars { get; set; }
        public int aud { get; set; }
        public double bch { get; set; }
        public int bdt { get; set; }
        public double bhd { get; set; }
        public int bmd { get; set; }
        public double bnb { get; set; }
        public int brl { get; set; }
        public double btc { get; set; }
        public int cad { get; set; }
        public int chf { get; set; }
        public int clp { get; set; }
        public int cny { get; set; }
        public int czk { get; set; }
        public int dkk { get; set; }
        public int dot { get; set; }
        public int eos { get; set; }
        public double eth { get; set; }
        public int eur { get; set; }
        public int gbp { get; set; }
        public int hkd { get; set; }
        public int huf { get; set; }
        public int idr { get; set; }
        public int ils { get; set; }
        public int inr { get; set; }
        public int jpy { get; set; }
        public int krw { get; set; }
        public double kwd { get; set; }
        public int lkr { get; set; }
        public double ltc { get; set; }
        public int mmk { get; set; }
        public int mxn { get; set; }
        public int myr { get; set; }
        public int ngn { get; set; }
        public int nok { get; set; }
        public int nzd { get; set; }
        public int php { get; set; }
        public int pkr { get; set; }
        public int pln { get; set; }
        public int rub { get; set; }
        public int sar { get; set; }
        public int sek { get; set; }
        public int sgd { get; set; }
        public int thb { get; set; }
        public int twd { get; set; }
        public int uah { get; set; }
        public int usd { get; set; }
        public double vef { get; set; }
        public int vnd { get; set; }
        public double xag { get; set; }
        public double xau { get; set; }
        public double xdr { get; set; }
        public int xlm { get; set; }
        public int xrp { get; set; }
        public double yfi { get; set; }
        public int zar { get; set; }
        public int bits { get; set; }
        public int link { get; set; }
        public int sats { get; set; }
    }

    public partial class Low_24h
    {
        public int aed { get; set; }
        public int ars { get; set; }
        public int aud { get; set; }
        public double bch { get; set; }
        public int bdt { get; set; }
        public double bhd { get; set; }
        public int bmd { get; set; }
        public double bnb { get; set; }
        public int brl { get; set; }
        public double btc { get; set; }
        public int cad { get; set; }
        public int chf { get; set; }
        public int clp { get; set; }
        public int cny { get; set; }
        public int czk { get; set; }
        public int dkk { get; set; }
        public int dot { get; set; }
        public int eos { get; set; }
        public double eth { get; set; }
        public int eur { get; set; }
        public int gbp { get; set; }
        public int hkd { get; set; }
        public int huf { get; set; }
        public int idr { get; set; }
        public int ils { get; set; }
        public int inr { get; set; }
        public int jpy { get; set; }
        public int krw { get; set; }
        public double kwd { get; set; }
        public int lkr { get; set; }
        public double ltc { get; set; }
        public int mmk { get; set; }
        public int mxn { get; set; }
        public int myr { get; set; }
        public int ngn { get; set; }
        public int nok { get; set; }
        public int nzd { get; set; }
        public int php { get; set; }
        public int pkr { get; set; }
        public int pln { get; set; }
        public int rub { get; set; }
        public int sar { get; set; }
        public int sek { get; set; }
        public int sgd { get; set; }
        public int thb { get; set; }
        public int twd { get; set; }
        public int uah { get; set; }
        public int usd { get; set; }
        public double vef { get; set; }
        public int vnd { get; set; }
        public double xag { get; set; }
        public double xau { get; set; }
        public double xdr { get; set; }
        public int xlm { get; set; }
        public int xrp { get; set; }
        public double yfi { get; set; }
        public int zar { get; set; }
        public int bits { get; set; }
        public int link { get; set; }
        public int sats { get; set; }
    }

    public partial class Price_change_24h_in_currency
    {
        public double aed { get; set; }
        public int ars { get; set; }
        public double aud { get; set; }
        public double bch { get; set; }
        public int bdt { get; set; }
        public double bhd { get; set; }
        public double bmd { get; set; }
        public double bnb { get; set; }
        public double brl { get; set; }
        public double btc { get; set; }
        public double cad { get; set; }
        public double chf { get; set; }
        public int clp { get; set; }
        public double cny { get; set; }
        public double czk { get; set; }
        public double dkk { get; set; }
        public double dot { get; set; }
        public double eos { get; set; }
        public double eth { get; set; }
        public double eur { get; set; }
        public double gbp { get; set; }
        public double hkd { get; set; }
        public int huf { get; set; }
        public int idr { get; set; }
        public double ils { get; set; }
        public int inr { get; set; }
        public int jpy { get; set; }
        public int krw { get; set; }
        public double kwd { get; set; }
        public int lkr { get; set; }
        public double ltc { get; set; }
        public int mmk { get; set; }
        public double mxn { get; set; }
        public double myr { get; set; }
        public int ngn { get; set; }
        public double nok { get; set; }
        public double nzd { get; set; }
        public double php { get; set; }
        public int pkr { get; set; }
        public double pln { get; set; }
        public int rub { get; set; }
        public double sar { get; set; }
        public double sek { get; set; }
        public double sgd { get; set; }
        public double thb { get; set; }
        public double twd { get; set; }
        public double uah { get; set; }
        public double usd { get; set; }
        public double vef { get; set; }
        public int vnd { get; set; }
        public double xag { get; set; }
        public double xau { get; set; }
        public double xdr { get; set; }
        public int xlm { get; set; }
        public int xrp { get; set; }
        public double yfi { get; set; }
        public double zar { get; set; }
        public double bits { get; set; }
        public double link { get; set; }
        public double sats { get; set; }
    }


    public partial class Price_change_percentage_24h_in_currency
    {
        public double aed { get; set; }
        public double ars { get; set; }
        public double aud { get; set; }
        public double bch { get; set; }
        public double bdt { get; set; }
        public double bhd { get; set; }
        public double bmd { get; set; }
        public double bnb { get; set; }
        public double brl { get; set; }
        public double btc { get; set; }
        public double cad { get; set; }
        public double chf { get; set; }
        public double clp { get; set; }
        public double cny { get; set; }
        public double czk { get; set; }
        public double dkk { get; set; }
        public double dot { get; set; }
        public double eos { get; set; }
        public double eth { get; set; }
        public double eur { get; set; }
        public double gbp { get; set; }
        public double hkd { get; set; }
        public double huf { get; set; }
        public double idr { get; set; }
        public double ils { get; set; }
        public double inr { get; set; }
        public double jpy { get; set; }
        public double krw { get; set; }
        public double kwd { get; set; }
        public double lkr { get; set; }
        public double ltc { get; set; }
        public double mmk { get; set; }
        public double mxn { get; set; }
        public double myr { get; set; }
        public double ngn { get; set; }
        public double nok { get; set; }
        public double nzd { get; set; }
        public double php { get; set; }
        public double pkr { get; set; }
        public double pln { get; set; }
        public double rub { get; set; }
        public double sar { get; set; }
        public double sek { get; set; }
        public double sgd { get; set; }
        public double thb { get; set; }
        public double twd { get; set; }
        public double uah { get; set; }
        public double usd { get; set; }
        public double vef { get; set; }
        public double vnd { get; set; }
        public double xag { get; set; }
        public double xau { get; set; }
        public double xdr { get; set; }
        public double xlm { get; set; }
        public double xrp { get; set; }
        public double yfi { get; set; }
        public double zar { get; set; }
        public double bits { get; set; }
        public double link { get; set; }
        public double sats { get; set; }
    }


    public partial class Market_cap_change_24h_in_currency
    {
        public long aed { get; set; }
        public long ars { get; set; }
        public long aud { get; set; }
        public int bch { get; set; }
        public long bdt { get; set; }
        public long bhd { get; set; }
        public long bmd { get; set; }
        public int bnb { get; set; }
        public long brl { get; set; }
        public int btc { get; set; }
        public long cad { get; set; }
        public long chf { get; set; }
        public long clp { get; set; }
        public long cny { get; set; }
        public long czk { get; set; }
        public long dkk { get; set; }
        public int dot { get; set; }
        public long eos { get; set; }
        public int eth { get; set; }
        public long eur { get; set; }
        public long gbp { get; set; }
        public long hkd { get; set; }
        public long huf { get; set; }
        public long idr { get; set; }
        public long ils { get; set; }
        public long inr { get; set; }
        public long jpy { get; set; }
        public long krw { get; set; }
        public long kwd { get; set; }
        public long lkr { get; set; }
        public int ltc { get; set; }
        public long mmk { get; set; }
        public long mxn { get; set; }
        public long myr { get; set; }
        public long ngn { get; set; }
        public long nok { get; set; }
        public long nzd { get; set; }
        public long php { get; set; }
        public long pkr { get; set; }
        public long pln { get; set; }
        public long rub { get; set; }
        public long sar { get; set; }
        public long sek { get; set; }
        public long sgd { get; set; }
        public long thb { get; set; }
        public long twd { get; set; }
        public long uah { get; set; }
        public long usd { get; set; }
        public int vef { get; set; }
        public long vnd { get; set; }
        public int xag { get; set; }
        public int xau { get; set; }
        public long xdr { get; set; }
        public long xlm { get; set; }
        public long xrp { get; set; }
        public int yfi { get; set; }
        public long zar { get; set; }
        public long bits { get; set; }
        public int link { get; set; }
        public long sats { get; set; }
    }

    public partial class Market_cap_change_percentage_24h_in_currency
    {
        public double aed { get; set; }
        public double ars { get; set; }
        public double aud { get; set; }
        public double bch { get; set; }
        public double bdt { get; set; }
        public double bhd { get; set; }
        public double bmd { get; set; }
        public double bnb { get; set; }
        public double brl { get; set; }
        public double btc { get; set; }
        public double cad { get; set; }
        public double chf { get; set; }
        public double clp { get; set; }
        public double cny { get; set; }
        public double czk { get; set; }
        public double dkk { get; set; }
        public double dot { get; set; }
        public double eos { get; set; }
        public double eth { get; set; }
        public double eur { get; set; }
        public double gbp { get; set; }
        public double hkd { get; set; }
        public double huf { get; set; }
        public double idr { get; set; }
        public double ils { get; set; }
        public double inr { get; set; }
        public double jpy { get; set; }
        public double krw { get; set; }
        public double kwd { get; set; }
        public double lkr { get; set; }
        public double ltc { get; set; }
        public double mmk { get; set; }
        public double mxn { get; set; }
        public double myr { get; set; }
        public double ngn { get; set; }
        public double nok { get; set; }
        public double nzd { get; set; }
        public double php { get; set; }
        public double pkr { get; set; }
        public double pln { get; set; }
        public double rub { get; set; }
        public double sar { get; set; }
        public double sek { get; set; }
        public double sgd { get; set; }
        public double thb { get; set; }
        public double twd { get; set; }
        public double uah { get; set; }
        public double usd { get; set; }
        public double vef { get; set; }
        public double vnd { get; set; }
        public double xag { get; set; }
        public double xau { get; set; }
        public double xdr { get; set; }
        public double xlm { get; set; }
        public double xrp { get; set; }
        public double yfi { get; set; }
        public double zar { get; set; }
        public double bits { get; set; }
        public double link { get; set; }
        public double sats { get; set; }
    }




}