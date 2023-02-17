using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CryptoInfo.Core;
using CryptoInfo.MVVM.Model;

namespace CryptoInfo.MVVM.ViewModel;

public class CoinDetailViewModel: ObservableObject
{
    private CoinDetailsModel? _coinDetails;
    private string? _selectedItem;
    
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
    private async Task LoadCoinDetails(APIHelper apiHelper, string selectedId){
    {
        var coinDetails = await CoinDetailsProcessor.LoadCoinDetails(apiHelper, selectedId);
        CoinDetails = coinDetails;

    }}
    private async Task LoadTickers(APIHelper apiHelper, string id)
    {
        
        var tickers = await TickersProcessor.LoadTickersInfo(apiHelper, id);

        foreach (var ticker in tickers.Tickers)
        {
            TickersList.Add(ticker);
        }
        
        // MainWindowViewModel.SelectedItem = null;
    }
    

    public CoinDetailViewModel()
    {
        APIHelper apiHelper = new APIHelper();
        apiHelper.InitializeClient();
        SelectedItem = MainWindowViewModel.SelectedItem.Id;
        TickersList = new ObservableCollection<Ticker>();
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
            Trade_url = "https://www.binance.com/en/trade/BTC_USDT?ref=37754157",
            coin_id = "nan",
            target_coin_id = "neh"
        });
        LoadTickers(apiHelper, SelectedItem);

        LoadCoinDetails(apiHelper, SelectedItem);
    }

}