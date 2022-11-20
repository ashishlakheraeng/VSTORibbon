using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public static class APICall
{
    private static HttpClient GetHttpClient(string url)
    {
        var client = new HttpClient { BaseAddress = new Uri(url) };
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        return client;
    }

    private static async Task<T> GetAsync<T>(string url, string urlParameters)
    {
        try
        {
            if (url.StartsWith("http:/r"))
                url = url.Replace("http:/r", "http://r");
            using (var client = GetHttpClient(url))
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<T>(json);
                    return result;
                }

                return default(T);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return default(T);
        }
    }

    public static async Task<T> RunAsync<T>(string url, string urlParameters)
    {
        return await GetAsync<T>(url, urlParameters);
    }
}