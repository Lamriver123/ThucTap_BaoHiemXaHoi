using Login.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Login.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly string clientId = "YjEwZDhhMDQtMTY2My00YjFjLTk3ZDUtNjhlZTBiMjEzMDJiLTYzODk0MzI4OTM2OTYyNDc3OQ==";
        private readonly string grantType = "password";

        public AuthService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://dichvucong.baohiemxahoi.gov.vn")
            };
        }

        public async Task<bool> LoginAsync(
            string username,
            string password,
            string code,
            string text,
            int loaiDoiTuong)
        {
            var values = new Dictionary<string, string>
            {
                { "grant_type", grantType },
                { "username", username },
                { "password", password },
                { "loaidoituong", loaiDoiTuong.ToString() },
                { "text", text },
                { "code", code },
                { "clientId", clientId }
            };

            var content = new FormUrlEncodedContent(values);
            var response = await _httpClient.PostAsync("/token", content);
            var result = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var obj = JObject.Parse(result);

                AppState.IsLoggedIn = true;
                AppState.loaiDoiTuong = loaiDoiTuong;
                AppState.AccessToken = obj["access_token"]?.ToString();
                AppState.ClientId = obj["as:client_id"]?.ToString();
                AppState.UserName = obj["userName"]?.ToString();
                AppState.DsDonViRaw = obj["dsDonVi"]?.ToString();

                var ds = JArray.Parse(AppState.DsDonViRaw);
                var donVi = ds[0];
                AppState.Ten = donVi["Ten"]?.ToString();

                AppState.IsPublic = obj["as:is_public"]?.ToString() == "1";
                AppState.IsAdmin = obj["as:is_admin"]?.ToString() == "1";
                AppState.VnConnect = obj["vnconnect"]?.ToString();
                AppState.Status = obj["status"]?.ToObject<int>() ?? 0;
                AppState.Expires = obj[".expires"]?.ToObject<int>() ?? 0;

                // Parse tstUser
                var tstUserJson = obj["tstUser"]?.ToString();
                if (!string.IsNullOrEmpty(tstUserJson))
                {
                    try
                    {
                        AppState.TstUser = JsonConvert.DeserializeObject<TstUserInfo>(tstUserJson);
                    }
                    catch { }
                }

                return true;
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                var err = JObject.Parse(result);
                string error = err["error"]?.ToString();
                string description = err["error_description"]?.ToString();
                throw new Exception($"Lỗi: {error}\nMô tả: {description}");
            }
            return false;
        }
    }
}
