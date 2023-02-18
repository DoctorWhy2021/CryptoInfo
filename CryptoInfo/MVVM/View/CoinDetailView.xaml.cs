using System.Diagnostics;
using System.Windows.Controls;
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

  
}