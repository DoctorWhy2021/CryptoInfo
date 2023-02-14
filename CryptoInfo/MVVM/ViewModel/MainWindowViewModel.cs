using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CryptoInfo.Core;
using CryptoInfo.MVVM.Model;

namespace CryptoInfo.MVVM.ViewModel;

public class MainWindowViewModel: ObservableObject
{
    private object _currentView;
    private string _searchText;

    public ObservableCollection<ShortCoinModel> CoinsList { get; set; }

    private MainPageViewModel MainPageVM { get; set; }
    private ExchangeViewModel ExchangeVM { get; set; } 
    private CoinDetailViewModel CoinDetailVM { get;}



    public RelayCommand MainPageViewCommand { get; set; }
    public RelayCommand ExchangeViewCommand { get; set; }

    public RelayCommand CoinDetailViewCommand { get; set; }

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

    public ObservableCollection<ShortCoinModel> FilteredCoinsList
    {
        get
        {
            if (SearchText == null)
                return CoinsList;
            return new ObservableCollection<ShortCoinModel>(CoinsList.Where(x => x.Name.ToLower().StartsWith(SearchText.ToLower())));
        }
    }



    private async Task LoadCoins()
    {
        var coins = await CoinsProccesor.LoadCoinsInfo();

        foreach (var coin in coins)
        {
            CoinsList.Add(coin);
        }
    }
    
    public MainWindowViewModel()
    {
        APIHelper.InitializeClient();
        CoinsList = new ObservableCollection<ShortCoinModel>();
        CoinsList.Add(new ShortCoinModel
        {
            Id = "nan",
            Image = "https://assets.coingecko.com/coins/images/6319/large/USD_Coin_icon.png?1547042389",
            Symbol = "NaN",
            Name = "NAN",

        });
        LoadCoins();
        MainPageVM = new MainPageViewModel();
        ExchangeVM = new ExchangeViewModel();
        CoinDetailVM = new CoinDetailViewModel();
        CurrentView = MainPageVM;
        
        MainPageViewCommand = new RelayCommand(o =>
        {
            CurrentView = MainPageVM;
        });

        ExchangeViewCommand = new RelayCommand(o =>
        {
            CurrentView = ExchangeVM;
        });

        CoinDetailViewCommand = new RelayCommand(o =>
        {
            CurrentView = CoinDetailVM;
        });
    }
}