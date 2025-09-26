using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public static class AppState
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static int loaiDoiTuong { get; set; }
        public static string Ten { get; set; }
        public static string AccessToken { get; set; }
        public static string ClientId { get; set; }
        public static string UserName { get; set; }
        public static string DsDonViRaw { get; set; }   // JSON gốc chuỗi dsDonVi
        //public static List<DonViInfo> DsDonVi { get; set; } = new List<DonViInfo>();
        public static bool IsPublic { get; set; }
        public static bool IsAdmin { get; set; }
        public static string VnConnect { get; set; }
        public static int Status { get; set; }
        public static int Expires { get; set; }
        public static TstUserInfo TstUser { get; set; }

        public static void Reset()
        {
            IsLoggedIn = false;
            Ten = null;
            AccessToken = null;
            ClientId = null;
            UserName = null;
            DsDonViRaw = null;
            //DsDonVi.Clear();
            IsPublic = false;
            IsAdmin = false;
            VnConnect = null;
            Status = 0;
            Expires = 0;
            TstUser = null;
        }
    }

}
