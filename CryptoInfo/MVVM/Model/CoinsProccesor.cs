using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CryptoInfo.Core;

namespace CryptoInfo.MVVM.Model;

public class CoinsProccesor
{
    public static async Task<CoinModel[]> LoadTopCoinsInfo(APIHelper apiHelper)
    {
        string url = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false";
        using (HttpResponseMessage responseMessage = await apiHelper.ApiClient.GetAsync(url))
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                var coins = await responseMessage.Content.ReadFromJsonAsync<CoinModel[]>();

                return coins;
            }
            
            throw new Exception(responseMessage.ReasonPhrase);
        }
    }
    
    public static async Task<ShortCoinModel[]> LoadCoinsInfo(APIHelper apiHelper)
    {
        string url = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=250&page=1&sparkline=false";
        using (HttpResponseMessage responseMessage = await apiHelper.ApiClient.GetAsync(url))
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                var coins = await responseMessage.Content.ReadFromJsonAsync<ShortCoinModel[]>();

                return coins;
            }
            
            throw new Exception(responseMessage.ReasonPhrase);
        }
    }
}