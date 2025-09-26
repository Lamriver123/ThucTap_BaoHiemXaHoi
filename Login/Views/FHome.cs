using Login.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FHome : Form
    {
        private readonly CallApiPublicService _apiService;
        public FHome()
        {
            InitializeComponent();
            _apiService = new CallApiPublicService();

        }

        private async void FHome_Load(object sender, EventArgs e)
        {
            try
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

                var obj = await _apiService.GetCallApiPublic();

                lbtTiepNhan.Text = string.Format("{0:N0}", (long)obj["tongTiepNhan"]);
                lblGiaiQuyet.Text = string.Format("{0:N0}", (long)obj["daGiaiQuyet"]);
                lblTyLeDaGiaiQuyet.Text = string.Format("{0:N2}", (double)obj["tyleGiaiQuyet"]) + "%";


                DrawPieChart(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
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



        private void DrawPieChart(JObject obj)
        {
            // Lấy dữ liệu
            float thu = (float)obj["tongTiepNhanThu"];
            float sothe = (float)obj["tongTiepNhanSoThe"];
            float csxh = (float)obj["tongTiepNhanCsxh"];
            float csyt = (float)obj["tongTiepNhanCsyt"];
            float chiTra = (float)obj["tongTiepNhanChiTra"];

            float tong = thu + sothe + csxh + csyt + chiTra;
            if (tong == 0) return;

            // Bitmap để vẽ
            Bitmap bmp = new Bitmap(pThongKeHoSo.Width, pThongKeHoSo.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                Rectangle rect = new Rectangle(10, 10, pThongKeHoSo.Width - 150, pThongKeHoSo.Height - 90);

                // Màu cho từng phần
                Brush[] brushes = new Brush[]
                {
                    Brushes.Red, Brushes.Green, Brushes.Gold, Brushes.Purple, Brushes.Blue
                };

                float[] values = { thu, sothe, csxh, csyt, chiTra };
                string[] labels = {
                    "Thu BHXH, \nBHYT, BHTN",
                    "Cấp sổ BHXH, \nthẻ BHYT",
                    "Thực hiện \nCS BHXH",
                    "Thực hiện \nCS BHYT",
                    "Chi trả \nchế độ"
                };

                float startAngle = 0;
                for (int i = 0; i < values.Length; i++)
                {
                    float sweep = values[i] / tong * 360;
                    g.FillPie(brushes[i], rect, startAngle, sweep);
                    g.DrawPie(Pens.Black, rect, startAngle, sweep);
                    startAngle += sweep;
                }

                // Legend nhỏ bên phải
                int y = 20;
                for (int i = 0; i < values.Length; i++)
                {
                    g.FillRectangle(brushes[i], rect.Right + 20, y, 10, 10);
                    g.DrawRectangle(Pens.Black, rect.Right + 20, y, 10, 10);
                    g.DrawString(labels[i], new Font("Segoe UI", 9), Brushes.Black, rect.Right + 45, y);
                    y += 40;
                }
            }

            pThongKeHoSo.BackgroundImage = bmp;
            pThongKeHoSo.BackgroundImageLayout = ImageLayout.Center;
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

        private void btnDongBH_Click(object sender, EventArgs e)
        {
            if (AppState.IsLoggedIn)
            {
            }
            else
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnKeKhai_Click(object sender, EventArgs e)
        {
            if (AppState.IsLoggedIn)
            {
            }
            else
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnDichVuCong_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (AppState.IsLoggedIn)
            {
            }
            else
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnTaiLieu_Click(object sender, EventArgs e)
        {
            if (AppState.IsLoggedIn)
            {
            }
            else
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (AppState.IsLoggedIn)
            {
            }
            else
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void pTinhHinhXuLy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
