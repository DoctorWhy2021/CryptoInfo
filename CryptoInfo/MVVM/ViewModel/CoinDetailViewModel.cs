using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CryptoInfo.Core;
using CryptoInfo.MVVM.Model;
using CryptoInfo.MVVM.View;

namespace CryptoInfo.MVVM.ViewModel;

public class CoinDetailViewModel : ObservableObject
{
    private CoinDetailsModel? _coinDetails;
    private string? _selectedItem;

    #region Props
    public CoinDetailView CoinDetailsView { get; set; }
    public ObservableCollection<Ticker> TickersList { get; set; }

    public string SelectedItem
    {
        get { return _selectedItem; }
        set
        {
            _selectedItem = value;
            OnPropertyChanged();
        }
    }

    public CoinDetailsModel? CoinDetails
    {
        get { return _coinDetails; }
        set
        {
            _coinDetails = value;
            OnPropertyChanged();

        }
    }
    

    #endregion

    #region Get Info From API

    private async Task LoadCoinDetails(APIHelper apiHelper, string selectedId)
    {
        {
            var coinDetails = await CoinDetailsProcessor.LoadCoinDetails(apiHelper, selectedId);
            CoinDetails = coinDetails;

        }
    }
    
    private async Task LoadTickers(APIHelper apiHelper, string id)
    {

        var tickers = await TickersProcessor.LoadTickersInfo(apiHelper, id);

        foreach (var ticker in tickers.Tickers)
        {
            TickersList.Add(ticker);
        }

    }

    #endregion
    


    public CoinDetailViewModel()
    {
        //Creating object of view to update UI
        CoinDetailsView = new CoinDetailView();
        CoinDetailsView.DataContext = this;
        
        APIHelper apiHelper = new APIHelper();
        apiHelper.InitializeClient();
        //Get selected Id from MainWindowViewModel
        SelectedItem = MainWindowViewModel.SelectedItem.Id;
        TickersList = new ObservableCollection<Ticker>();

        //Add hardcode ticker for tests
        /*
         TickersList.Add(new Ticker
        {
            Base = "Nan",
            Target = "nehh",
            Market = new Market
            {
                Logo = new Uri("https://assets.coingecko.com/markets/images/52/small/binance.jpg?1519353250"),
                Name = "Binance"
            },
            Last = 12345,
            Trust_score = "green",
            Bid_ask_spread_percentage = 0.02,
            Trade_url = new Uri("https://www.binance.com/en/trade/BTC_USDT?ref=37754157"),
            coin_id = "nan",
            target_coin_id = "neh"
        });
         */
        
        //Loading Info from API
        LoadCoinDetails(apiHelper, SelectedItem);
        LoadTickers(apiHelper, SelectedItem);

    }
}