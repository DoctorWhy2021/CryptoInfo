using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CryptoInfo.Core;
using CryptoInfo.MVVM.Model;

namespace CryptoInfo.MVVM.ViewModel;

public class MainPageViewModel: ObservableObject
{
    public ObservableCollection<CoinModel> CoinsList { get; set; }
    // public ObservableCollection<double[]> SparklinesList { get; set; }

    private async Task LoadCoin()
    {
        var coins = await CoinsProccesor.LoadCoinsInfo();

        foreach (var coin in coins)
        {
           CoinsList.Add(coin); 
           // SparklinesList.Add(coin.Price);
        }
        
    }

    public MainPageViewModel()
    {
        CoinsList = new ObservableCollection<CoinModel>();
        // SparklinesList = new ObservableCollection<double[]>();
        CoinsList.Add(new CoinModel
        {
            current_price = 10000,
            id = "nan",
            image = "https://assets.coingecko.com/coins/images/6319/large/USD_Coin_icon.png?1547042389",
            symbol = "NaN",
            name = "NAN",
            price_change_percentage_24h = -0.4

        });
        LoadCoin();
    }
}