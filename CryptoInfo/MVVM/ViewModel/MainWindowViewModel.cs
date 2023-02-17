using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Threading;
using CryptoInfo.Core;
using CryptoInfo.MVVM.Model;

namespace CryptoInfo.MVVM.ViewModel;

public class MainWindowViewModel: ObservableObject
{
    private object _currentView;
    private string _searchText;


    private MainPageViewModel MainPageVM { get; set; }
    private ConvertViewModel ConvertVm { get; set; }
    private CoinDetailViewModel CoinDetailVM { get; set; }

    public RelayCommand MainPageViewCommand { get; set; }
    public RelayCommand ConvertViewCommand { get; set; }

    public RelayCommand CoinDetailViewCommand { get; set; }
    
    private ObservableCollection<ShortCoinModel> CoinsList { get; }


    public object CurrentView
    {
        get { return _currentView; }
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public string SearchText
    {
        get
        {
            return _searchText;
        }
        set
        {
            _searchText = value;
            OnPropertyChanged();
            OnPropertyChanged("FilteredCoinsList");
        }
    }

    public static ShortCoinModel SelectedItem { get; set; }

    public ObservableCollection<ShortCoinModel> FilteredCoinsList
    {
        get
        {
            return SearchText == null ? CoinsList : new ObservableCollection<ShortCoinModel>(CoinsList.Where(x => x.Name.ToLower().StartsWith(SearchText.ToLower())));
        }
    }

    private async Task LoadCoins(APIHelper apiHelper)
    {
        var coins = await CoinsProccesor.LoadShortCoinsInfo(apiHelper);

        foreach (var coin in coins)
        {
            CoinsList.Add(coin);
        }
    }
    
    public MainWindowViewModel()
    {
        var apiHelper = new APIHelper();
        apiHelper.InitializeClient();
        CoinsList = new ObservableCollection<ShortCoinModel>();
        
        CoinsList.Add(new ShortCoinModel
        {
            Id = "tether",
            Image = new Uri("https://assets.coingecko.com/coins/images/6319/large/USD_Coin"),
            Symbol = "USDT",
            Name = "Tether",
        });
        CoinsList.Add(new ShortCoinModel
        {
            Id = "bitcoin",
            Image = new Uri("https://assets.coingecko.com/coins/images/6319/large/USD_Coin"),
            Symbol = "BTC",
            Name = "Bitcoin",
        });
        CoinsList.Add(new ShortCoinModel
        {
            Id = "okb",
            Image = new Uri("https://assets.coingecko.com/coins/images/6319/large/USD_Coin"),
            Symbol = "OKB",
            Name = "OKB",
        });
        LoadCoins(apiHelper);

        MainPageVM = new MainPageViewModel();
        ConvertVm = new ConvertViewModel();

        CurrentView = MainPageVM;
        
        MainPageViewCommand = new RelayCommand(o =>
        {

            CurrentView = MainPageVM;
        });

        ConvertViewCommand = new RelayCommand(o =>
        {
            CurrentView = ConvertVm;
        });

        CoinDetailViewCommand = new RelayCommand(o =>
        {
            // if (CurrentView == CoinDetailVM)
            // {
            //     CurrentView = MainPageVM;
            //     CoinDetailVM = new CoinDetailViewModel();
            //     CurrentView = CoinDetailVM;
            // }
            SearchText = null;
            CoinDetailVM = new CoinDetailViewModel();
            CurrentView = CoinDetailVM;

        });
        
    }
}