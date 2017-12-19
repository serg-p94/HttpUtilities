using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace HttpCore
{
    public static class HtmlHelper
    {
        public static async Task<HtmlDocument> LoadAsync(string url)
        {
            return await Task.Run(() => new HtmlWeb().Load(url));
        }

        public static async Task<string> GetStringAsync(string url)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        public static async Task<TResult> GetDataAsync<TResult>(string url)
        {
            var json = await GetStringAsync(url);
            return JsonConvert.DeserializeObject<TResult>(json);            
        }

    }
}
