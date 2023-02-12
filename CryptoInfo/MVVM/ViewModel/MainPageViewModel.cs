using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CryptoInfo.Core;
using CryptoInfo.MVVM.Model;

namespace CryptoInfo.MVVM.ViewModel;

public class MainPageViewModel: ObservableObject
{
    public ObservableCollection<CoinModel.ItemModel> CoinsList { get; set; }

    private async Task LoadCoin()
    {
        var coins = await CoinsProccesor.LoadCoinsInfo();

        foreach (var coin in coins.Coins)
        {
           CoinsList.Add(coin.Item); 
        }
    }

    public MainPageViewModel()
    {
        CoinsList = new ObservableCollection<CoinModel.ItemModel>();
        
        LoadCoin();
    }
}