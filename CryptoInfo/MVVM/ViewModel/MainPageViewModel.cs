using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CryptoInfo.Core;
using CryptoInfo.MVVM.Model;

namespace CryptoInfo.MVVM.ViewModel;

public class MainPageViewModel: ObservableObject
{
    #region Props
    public ObservableCollection<CoinModel> CoinsList { get; set; }
    
    // public ObservableCollection<double[]> SparklinesList { get; set; }
    #endregion

    #region Loading Coins
    private async Task LoadCoin(APIHelper apiHelper)
    {
        
        var coins = await CoinsProccesor.LoadTopCoinsInfo(apiHelper);

        foreach (var coin in coins)
        {
            CoinsList.Add(coin); 
            // SparklinesList.Add(coin.Price);
        }
    }
    

    #endregion
    

    public MainPageViewModel()
    {
        APIHelper apiHelper = new APIHelper();
        apiHelper.InitializeClient();
        
        CoinsList = new ObservableCollection<CoinModel>();
        
        //Collection for sparklines
        // SparklinesList = new ObservableCollection<double[]>();
        
        
        //Add coinmodel for tests
        /*
        CoinsList.Add(new CoinModel
        {
            Current_price = 10000,
            Id = "nan",
            Image = "https://assets.coingecko.com/coins/images/6319/large/USD_Coin_icon.png?1547042389",
            Symbol = "NaN",
            Name = "NAN",
            Price_change_percentage_24h = -0.4

        });
        */
        
        //Loading Top Coins info
        LoadCoin(apiHelper);
    }
}