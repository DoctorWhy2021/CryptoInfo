using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows;
using CryptoInfo.Core;

namespace CryptoInfo.MVVM.Model;

public class CoinDetailsProcessor
{
    public static async Task<CoinDetailsModel> LoadCoinDetails(APIHelper apiHelper, string id)
    {
        string url = $"https://api.coingecko.com/api/v3/coins/{id}?localization=false&tickers=false&market_data=true&community_data=false&developer_data=false&sparkline=false";
        using (HttpResponseMessage responseMessage = await apiHelper.ApiClient.GetAsync(url))
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                var coinDetails = await responseMessage.Content.ReadFromJsonAsync<CoinDetailsModel>();

                return coinDetails;
            }
            ReasonPhraseMessage.ShowPopup(responseMessage.ReasonPhrase);
            throw new Exception(responseMessage.ReasonPhrase);
        }
    }
}