using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class UserModel
    {
        public string AccessToken { get; set; }
        public string UserName { get; set; }

        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string MaCqbh { get; set; }
        public string TenCqbh { get; set; }
        public string TinhLh { get; set; }
        public string HuyenLh { get; set; }
        public string XaLh { get; set; }
        public string TinhHk { get; set; }
        public string HuyenHk { get; set; }
        public string XaHk { get; set; }
        public string TinhKs { get; set; }
        public string HuyenKs { get; set; }
        public string XaKs { get; set; }
        public string DcLh { get; set; }
        public string DcHk { get; set; }
        public string NamSinh { get; set; }
        public string ThangSinh { get; set; }
        public string SoDienThoai { get; set; }
        public string SoCmnd { get; set; }
        public int MucDong { get; set; }
        public string PtDong { get; set; }
        public string NguoiGiamHo { get; set; }
        public string MaBv { get; set; }
        public string MaTinhBenhVien { get; set; }
        public string MaDvi { get; set; }
        public string TenDvi { get; set; }
    }
}
