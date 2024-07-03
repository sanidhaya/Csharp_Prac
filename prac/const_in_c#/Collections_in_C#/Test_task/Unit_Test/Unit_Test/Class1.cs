using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Unit_Test
{
    public class Class1
    {
        public readonly HttpClient _httpClient;

        public Class1(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ApiData> GetBinTask(string code)
        {
            string url = $"https://httpbin.org/status/{code}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            ApiData apiData = JsonConvert.DeserializeObject<ApiData>(responseBody);
            return apiData;
        }

        public static async void Main(string[] args)
        {
            var httpClient = new HttpClient();
            Class1 class1 = new Class1(httpClient);
            ApiData apiData = await class1.GetBinTask("200");
            Console.WriteLine(apiData.ToString()); 
        }
    }
}
