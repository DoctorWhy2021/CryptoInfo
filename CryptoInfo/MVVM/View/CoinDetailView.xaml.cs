using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace CryptoInfo.MVVM.View;

public partial class CoinDetailView : UserControl
{
    public CoinDetailView()
    {
        InitializeComponent();
    }


    private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName ="https://www.coingecko.com/en/coins/" + e.Uri,
            UseShellExecute = true
        });
    }



    private void EventSetter_OnHandler(object sender, RoutedEventArgs e)
    {
        Hyperlink link = (Hyperlink)e.OriginalSource;
        Process.Start(new ProcessStartInfo
        {
            FileName = link.NavigateUri.AbsoluteUri,
            UseShellExecute = true
        });
    }
}