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
    private ShortCoinModel _selectedItem;
   

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
            // OnPropertyChanged("SelectedItem");
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

    public ShortCoinModel SelectedItem
    {
        get { return _selectedItem; }
        set
        {
            _selectedItem = value;
            SearchText = null;
            // if (_selectedItem != null)
            // {
                CoinDetailVM = new CoinDetailViewModel();
                CoinDetailVM.SelectedId = value.Id;
                CurrentView = CoinDetailVM;
            // }
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
        APIHelper apiHelper = new APIHelper();
        apiHelper.InitializeClient();
        var coins = await CoinsProccesor.LoadCoinsInfo(apiHelper);

        foreach (var coin in coins)
        {
            CoinsList.Add(coin);
        }
    }
    
    public MainWindowViewModel()
    {
        CoinsList = new ObservableCollection<ShortCoinModel>();
        CoinsList.Add(new ShortCoinModel
        {
            Id = "tether",
            Image = "https://assets.coingecko.com/coins/images/6319/large/USD_Coin_icon.png?1547042389",
            Symbol = "NaN",
            Name = "NAN",

        });
        
        
        MainPageVM = new MainPageViewModel();
        ConvertVm = new ConvertViewModel();

        CurrentView = MainPageVM;
        
        MainPageViewCommand = new RelayCommand(o =>
        {
            // _selectedItem = null;

            CurrentView = MainPageVM;
        });

        ConvertViewCommand = new RelayCommand(o =>
        {
            CurrentView = ConvertVm;
        });
        // LoadCoins();

        CoinDetailViewCommand = new RelayCommand(o =>
        {
            CurrentView = CoinDetailVM;
        });
        
    }
}