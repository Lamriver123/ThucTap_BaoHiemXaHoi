using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Views
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (FLogin fLogin = new FLogin())
            {
                if (fLogin.ShowDialog() == DialogResult.OK)
                {

                    pDangNhap.Hide();
                    pDaDangNhap.Show();
                    btnDangXuat.Text = AppState.FullName;
                }
            }
        }

        private void btnDangXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnDangXuat.SelectedItem != null && btnDangXuat.SelectedItem.ToString() == "Đăng xuất")
            {
                // Reset trạng thái đăng nhập
                AppState.IsLoggedIn = false;
                AppState.AccessToken = null;
                AppState.UserName = null;
                AppState.FullName = null;

                // Ẩn phần đã đăng nhập, hiện phần đăng nhập
                pDaDangNhap.Hide();
                pDangNhap.Show();

                MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông báo");

                // Reset lại combobox (tránh để chữ 'Đăng xuất' hiển thị)
                btnDangXuat.SelectedIndex = -1;
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            if (AppState.IsLoggedIn)
            {
                pDangNhap.Hide();
                pDaDangNhap.Show();
            }
            else
            {
                pDangNhap.Show();
                pDaDangNhap.Hide();
            }
        }
    }
}
