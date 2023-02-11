using CryptoInfo.Core;

namespace CryptoInfo.MVVM.ViewModel;

public class MainWindowViewModel: ObservableObject
{
    private object _currentView;

    private MainPageViewModel MainPageVM { get; set; }
    private ExchangeViewModel ExchangeVM { get; set; }


    public RelayCommand MainPageViewCommand { get; set; }
    public RelayCommand ExchangeViewCommand { get; set; }

    public object CurrentView
    {
        get { return _currentView; }
        set
        {
            _currentView = value;
            OnPropertyChanged();
        } }
    
    public MainWindowViewModel()
    {
        MainPageVM = new MainPageViewModel();
        ExchangeVM = new ExchangeViewModel();
        CurrentView = MainPageVM;

        MainPageViewCommand = new RelayCommand(o =>
        {
            CurrentView = MainPageVM;
        });

        ExchangeViewCommand = new RelayCommand(o =>
        {
            CurrentView = ExchangeVM;
        });
    }
}