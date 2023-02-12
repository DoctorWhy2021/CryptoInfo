using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CryptoInfo.Core;

namespace CryptoInfo.MVVM.Model;

public class CoinsProccesor
{
    public static async Task<CoinsModel> LoadCoinsInfo()
    {
        string url = "https://api.coingecko.com/api/v3/search/trending";

        using (HttpResponseMessage responseMessage = await APIHelper.ApiClient.GetAsync(url))
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                var coins = await responseMessage.Content.ReadFromJsonAsync<CoinsModel>();

                return coins;
            }
            else
            {
                throw new Exception(responseMessage.ReasonPhrase);
            }
        }
    }
}