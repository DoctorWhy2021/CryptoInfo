using System.Net.Http;
using System.Net.Http.Headers;

namespace CryptoInfo.Core;

public class APIHelper
{
    public HttpClient ApiClient { get; set; }

    public void InitializeClient()
    {
        ApiClient = new HttpClient();
        ApiClient.DefaultRequestHeaders.Accept.Clear();
        ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        ApiClient.DefaultRequestHeaders.Add("User-Agent", "your bot 0.1");

    }
}