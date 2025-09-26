using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Views.TraCuu
{
    public partial class FTraCuuC12 : Form
    {
        public FTraCuuC12()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra chọn tháng
            if (cbThang.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nhập năm
            if (string.IsNullOrWhiteSpace(txtNam.Text))
            {
                MessageBox.Show("Vui lòng nhập năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nam;
            if (!int.TryParse(txtNam.Text, out nam))
            {
                MessageBox.Show("Năm phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ví dụ chỉ cho phép năm >= 1900 và <= năm hiện tại
            int namHienTai = DateTime.Now.Year;
            if (nam < 1900 || nam > namHienTai)
            {
                MessageBox.Show("Năm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Tháng
            int thangHienTai = DateTime.Now.Month;
            if (nam == namHienTai && thangHienTai < cbThang.SelectedIndex + 1)
            {
                MessageBox.Show("Tháng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Nếu hợp lệ thì lấy tháng + năm
            int thang = cbThang.SelectedIndex + 1;
            MessageBox.Show($"Bạn đã chọn: Tháng {thang} - Năm {nam}");
        }

        private void FTraCuuC12_Load(object sender, EventArgs e)
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            cbThang.SelectedIndex = thang - 1;
            txtNam.Text = nam.ToString();
        }
    }
}
