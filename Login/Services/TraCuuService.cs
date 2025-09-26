using System.Text.RegularExpressions;
using System.Globalization;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using Login.Models;
using System.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;




namespace Login.Services
{
    public class TraCuuService
    {
        private readonly HttpClient _httpClient;

        public TraCuuService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://dichvucong.baohiemxahoi.gov.vn")
            };
        }
        public async Task<byte[]> TraCuuC12Async(int thang, int nam)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", AppState.AccessToken);

            var ds = JArray.Parse(AppState.DsDonViRaw);
            var donVi = ds[0];

            string maCoQuan = donVi["MaCoquan"]?.ToString();
            string maDonVi = donVi["Ma"]?.ToString();
            var requestBody = new
            {
                code = "170",
                data = new
                {
                    macoquan = maCoQuan,
                    madonvi = maDonVi,
                    month = thang,
                    year = nam,
                    masobhxhuser = maDonVi,
                    macoquanuser = maCoQuan,
                    loaidoituonguser = AppState.loaiDoiTuong.ToString()
                }
            };

            var response = await _httpClient.PostAsJsonAsync("/CallApiWithCurrentUser", requestBody);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync();

            }

            throw new Exception($"API lỗi: {response.StatusCode}");
        }
        


    }
}
