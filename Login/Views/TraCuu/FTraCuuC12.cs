using Login.Services;
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

        private async void btnTraCuu_Click(object sender, EventArgs e)
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
            int thang = cbThang.SelectedIndex + 1;


            //Thực hiện
            try
            {
                var service = new TraCuuService();

                byte[] pdfData = await service.TraCuuC12Async(thang, nam);

                //// Extract table từ Python service
                //var dataTableService = new DataTablePdfService();
                //string jsonResult = await dataTableService.ExtractTableAsync(pdfData);

                //// Hiển thị JSON trả về
                //MessageBox.Show(jsonResult);


                string filePath = Path.Combine(Application.StartupPath, $"C12_{thang}_{nam}_{AppState.Ten}.pdf");
                File.WriteAllBytes(filePath, pdfData);

                var dataTableService = new DataTablePdfService();
                var listRaw = await dataTableService.ExtractTableAsync(pdfData);
                FTraCuu fTraCuu = this.ParentForm as FTraCuu;
                if (fTraCuu != null)
                {
                    fTraCuu.openChildForm(new FShowTraCuuC12(listRaw));
                }

                FViewPdf fViewPdf = new FViewPdf(filePath);
                fViewPdf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tra cứu: " + ex.Message);
            }
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
