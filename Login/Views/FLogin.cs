using Login.Services;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace Login
{
    public partial class FLogin : Form
    {
        private readonly CaptchaService _captchaService;
        private readonly AuthService _authService;

        private string code = "";
        private int loaiDoiTuong = 0;

        private readonly HttpClient _httpClient = new HttpClient();
        public FLogin()
        {
            InitializeComponent();
            _captchaService = new CaptchaService();
            _authService = new AuthService();
        }

        private async Task LoadCaptchaAsync()
        {
            try
            {
                btnRefresh.Enabled = false;

                var (image, captchaCode) = await _captchaService.GetCaptchaAsync();
                if (image != null)
                {
                    picCaptcha.Image = image;
                    code = captchaCode;
                }

                btnRefresh.Enabled = true;
            }
            catch (Exception ex)
            {
                btnRefresh.Enabled = true;
                MessageBox.Show("Lỗi lấy captcha: " + ex.Message);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            cbCaNhan.Checked = true;
            cbDoanhNghiep.Checked = false;

            await LoadCaptchaAsync();
        }

        private void cbCaNhan_Click(object sender, EventArgs e)
        {
            cbCaNhan.Checked = true;
            cbDoanhNghiep.Checked = false;
            loaiDoiTuong = 0;
        }

        private void cbDoanhNghiep_Click(object sender, EventArgs e)
        {
            cbDoanhNghiep.Checked = true;
            cbCaNhan.Checked = false;
            loaiDoiTuong = 1;
        }


        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadCaptchaAsync();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {

            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();
            var text = txtCaptcha.Text.Trim();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            btnDangNhap.Enabled = false;
            try
            {
                var user = await _authService.LoginAsync(username, password, code, text, loaiDoiTuong);

                MessageBox.Show("Đăng nhập thành công");

                this.DialogResult = DialogResult.OK;
                btnDangNhap.Enabled = true;
                this.Close();
            }
            catch (Exception ex)
            {
                btnDangNhap.Enabled = true;
                MessageBox.Show("Đăng nhập thất bại: " + ex.Message);
            }

            await LoadCaptchaAsync();
        }

        
    }
}
