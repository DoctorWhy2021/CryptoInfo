﻿using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CryptoInfo.Core;

namespace CryptoInfo.MVVM.Model;

public class TickersProcessor
{
    public static async Task<TickersModel> LoadTickersInfo(APIHelper apiHelper)
    {
        string url = "https://api.coingecko.com/api/v3/coins/bitcoin/tickers?include_exchange_logo=true";
        using (HttpResponseMessage responseMessage = await apiHelper.ApiClient.GetAsync(url))
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                var tickers = await responseMessage.Content.ReadFromJsonAsync<TickersModel>();

                return tickers;
            }
            
            throw new Exception(responseMessage.ReasonPhrase);
        }
    }
}