using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Services
{
    public class CaptchaService
    {
        private readonly HttpClient _httpClient;

        public CaptchaService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://dichvucong.baohiemxahoi.gov.vn")
            };
        }

        public async Task<(Image Image, string Code)> GetCaptchaAsync()
        {
            var json = "{\"height\":60,\"width\":300}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/api/getCaptchaImage", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var obj = JObject.Parse(result);

            string base64 = obj["image"]?.ToString();
            string code = obj["code"]?.ToString();

            if (string.IsNullOrEmpty(base64))
                return (null, null);

            byte[] bytes = Convert.FromBase64String(base64);
            using var ms = new MemoryStream(bytes);
            var img = Image.FromStream(ms);

            return (img, code);
        }
    }
}
