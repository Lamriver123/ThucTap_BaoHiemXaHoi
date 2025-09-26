using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Services
{
    public class CallApiPublicService
    {
        private readonly HttpClient _httpClient;

        public CallApiPublicService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://dichvucong.baohiemxahoi.gov.vn")
            };
        }

        public async Task<JObject> GetCallApiPublic()
        {
            var json = "{\"code\":581,\"data\":{}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/callApiPublic", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var obj = JObject.Parse(result);

            return obj;
        }
    }
}
