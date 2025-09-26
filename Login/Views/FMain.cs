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
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();
            UpdateLoginUI();
        }

        private void btnDangXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnDangXuat.SelectedItem != null && btnDangXuat.SelectedItem.ToString() == "Đăng xuất")
            {
                // Reset trạng thái đăng nhập
                AppState.Reset();

                // Ẩn phần đã đăng nhập, hiện phần đăng nhập
                pDaDangNhap.Hide();
                pDangNhap.Show();

                MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông báo");

                // Reset lại combobox (tránh để chữ 'Đăng xuất' hiển thị)
                btnDangXuat.SelectedIndex = -1;
                childForm(new FHome());
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            UpdateLoginUI();
            childForm(new FHome());
        }

        

        public void childForm(Form frm)
        {
            pBody.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pBody.Controls.Add(frm);
            frm.Show();
        }

        public void UpdateLoginUI()
        {
            if (AppState.IsLoggedIn)
            {
                pDangNhap.Hide();
                pDaDangNhap.Show();
                btnDangXuat.Text = AppState.UserName + "-" + AppState.Ten;
            }
            else
            {
                pDangNhap.Show();
                pDaDangNhap.Hide();
                btnDangXuat.SelectedIndex = -1;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            childForm(new FHome());
        }
    }
}
