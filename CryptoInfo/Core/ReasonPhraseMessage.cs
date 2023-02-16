using System.Windows;

namespace CryptoInfo.Core;

public class ReasonPhraseMessage
{
    public static void ShowPopup(string message)
    {
        Window popup = new Window();
        popup.Name = "MessagePopUP";
        popup.Content = message;
        popup.Width = 100;
        popup.Height = 100;
        popup.Show();
    }
}