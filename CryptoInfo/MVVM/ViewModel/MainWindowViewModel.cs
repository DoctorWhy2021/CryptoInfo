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

    #region Props
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
            //Changing filtered list property on every new manipulation with searchtext
            OnPropertyChanged("FilteredCoinsList");
        }
    }

    public static ShortCoinModel SelectedItem { get; set; }

    public ObservableCollection<ShortCoinModel> FilteredCoinsList
    {
        get
        {
            //Return new filtered list 
            //To filter list use Linq
            return new ObservableCollection<ShortCoinModel>(CoinsList.Where(x => x.Name.ToLower().StartsWith(SearchText.ToLower())));
        }
    }

    #endregion

    #region Load Coins and adding it to list
    private async Task LoadCoins(APIHelper apiHelper)
    {
        var coins = await CoinsProccesor.LoadShortCoinsInfo(apiHelper);

        foreach (var coin in coins)
        {
            CoinsList.Add(coin);
        }
    }
    #endregion

    public MainWindowViewModel()
    {
        var apiHelper = new APIHelper();
        apiHelper.InitializeClient();
        
        CoinsList = new ObservableCollection<ShortCoinModel>();
        
        //Add hardcode Coins for tests
        /*CoinsList.Add(new ShortCoinModel
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
        */
        
        //Load coins info
        LoadCoins(apiHelper);
        
        //Creating ViewModels on application start
        MainPageVM = new MainPageViewModel();
        ConvertVm = new ConvertViewModel();
        
        //Set current view to main page
        CurrentView = MainPageVM;

        #region RelayCommands

        MainPageViewCommand = new RelayCommand(o => { CurrentView = MainPageVM; });

        ConvertViewCommand = new RelayCommand(o => { CurrentView = ConvertVm; });

        CoinDetailViewCommand = new RelayCommand(o =>
        {
            //Creating ViewModels on Command execution because it needs Coin Id
            CoinDetailVM = new CoinDetailViewModel();
            //Set Search text to null to hide listbox with FilteredCoinsList
            SearchText = null;
            CurrentView = CoinDetailVM;
        });
        #endregion
    }
}