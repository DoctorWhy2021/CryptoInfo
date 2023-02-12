namespace CryptoInfo.MVVM.Model;

public class CoinModel
{
    public ItemModel? Item { get; set; }
    
    public class ItemModel
    {
        public string Id { get; set; }
        public double Price_btc { get; set; }
        public string Small { get; set; }
    }
}