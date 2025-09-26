using Login.Models;
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

        public async Task<UserModel?> LoginAsync(
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

                var user = new UserModel
                {
                    AccessToken = (string)obj["access_token"],
                    UserName = (string)obj["userName"]
                };

                // parse tstUser
                var tstUser = obj["tstUser"];
                if (tstUser != null)
                {
                    user.HoTen = (string)tstUser["hoTen"];
                    user.GioiTinh = (string)tstUser["gioiTinh"];
                    user.NgaySinh = (string)tstUser["ngaySinh"];
                    user.MaCqbh = (string)tstUser["maCqbh"];
                    user.TenCqbh = (string)tstUser["tenCqbh"];
                    user.TinhLh = (string)tstUser["tinhLh"];
                    user.HuyenLh = (string)tstUser["huyenLh"];
                    user.XaLh = (string)tstUser["xaLh"];
                    user.TinhHk = (string)tstUser["tinhHk"];
                    user.HuyenHk = (string)tstUser["huyenHk"];
                    user.XaHk = (string)tstUser["xaHk"];
                    user.TinhKs = (string)tstUser["tinhKs"];
                    user.HuyenKs = (string)tstUser["huyenKs"];
                    user.XaKs = (string)tstUser["xaKs"];
                    user.DcLh = (string)tstUser["dcLh"];
                    user.DcHk = (string)tstUser["dcHk"];
                    user.NamSinh = (string)tstUser["namSinh"];
                    user.ThangSinh = (string)tstUser["thangSinh"];
                    user.SoDienThoai = (string)tstUser["sodienthoai"];
                    user.SoCmnd = (string)tstUser["soCmnd"];
                    user.MucDong = (int?)tstUser["mucDong"] ?? 0;
                    user.PtDong = (string)tstUser["ptDong"];
                    user.NguoiGiamHo = (string)tstUser["nguoiGiamHo"];
                    user.MaBv = (string)tstUser["maBv"];
                    user.MaTinhBenhVien = (string)tstUser["maTinhBenhVien"];
                    user.MaDvi = (string)tstUser["maDvi"];
                    user.TenDvi = (string)tstUser["tenDvi"];
                }
                return user;
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                var err = JObject.Parse(result);
                string error = err["error"]?.ToString();
                string description = err["error_description"]?.ToString();
                throw new Exception($"Lỗi: {error}\nMô tả: {description}");
            }
            return null;
        }
    }
}
