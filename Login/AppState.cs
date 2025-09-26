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
        public static string AccessToken { get; set; }
        public static string UserName { get; set; }

        public static string FullName { get; set; }
    }

}
