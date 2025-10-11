using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Wordprocessing;
using Login.Database;
using Login.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglyToad.PdfPig.Graphics;

namespace Login.Views.TraCuu
{
    public partial class FShowTraCuuC12 : Form
    {
        List<TraCuuC12Models> list = new List<TraCuuC12Models>();
        private byte[] dataPdf1;
        private string filePath;

        public FShowTraCuuC12(List<TraCuuC12Models> list, byte[] dataPdf)
        {
            InitializeComponent();
            this.list = list;
            dataPdf1 = dataPdf;

        }

        private void LoadData(List<TraCuuC12Models> list)
        {

            if (list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu bảng trong PDF");
            }
            else
            {
                // Cấu hình DataGridView
                dvThongTin.AutoGenerateColumns = false;
                dvThongTin.Columns.Clear();
                dvThongTin.AllowUserToAddRows = false;
                dvThongTin.ReadOnly = true;
                dvThongTin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dvThongTin.MultiSelect = false;
                dvThongTin.RowHeadersVisible = false;
                dvThongTin.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                dvThongTin.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
                dvThongTin.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dvThongTin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dvThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvThongTin.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
                dvThongTin.GridColor = System.Drawing.Color.LightGray;
                dvThongTin.BackgroundColor = System.Drawing.Color.White;

                // Danh sách cột
                var columns = new[]
                {
                    new { Name = "STT", Header = "STT", Align = DataGridViewContentAlignment.MiddleCenter },
                    new { Name = "NoiDung", Header = "Nội dung", Align = DataGridViewContentAlignment.MiddleLeft },
                    new { Name = "BHXH_OD_TS", Header = "BHXH OD TS", Align = DataGridViewContentAlignment.MiddleCenter },
                    new { Name = "BHXH_HTTT", Header = "BHXH HTTT", Align = DataGridViewContentAlignment.MiddleCenter },
                    new { Name = "BHYT", Header = "BHYT", Align = DataGridViewContentAlignment.MiddleCenter },
                    new { Name = "BHTN", Header = "BHTN", Align = DataGridViewContentAlignment.MiddleCenter },
                    new { Name = "BHTNLD_BNN", Header = "BHTNLD_BNN", Align = DataGridViewContentAlignment.MiddleCenter },
                    new { Name = "Cong", Header = "Cộng", Align = DataGridViewContentAlignment.MiddleCenter }
                };

                // Tạo cột
                foreach (var col in columns)
                {
                    var column = new DataGridViewTextBoxColumn
                    {
                        Name = col.Name,
                        DataPropertyName = col.Name,
                        HeaderText = col.Header,
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Alignment = col.Align
                        }
                    };
                    dvThongTin.Columns.Add(column);
                }

                // Gán dữ liệu
                dvThongTin.DataSource = list;
                // Refresh lại DataGridView trước khi tô đậm
                dvThongTin.Refresh();

                dvThongTin.CellFormatting += (s, e) =>
                {
                    if (dvThongTin.Columns[e.ColumnIndex].DataPropertyName == "STT")
                    {
                        var value = e.Value?.ToString()?.Trim();
                        if (!string.IsNullOrEmpty(value) && !decimal.TryParse(value, out _))
                        {
                            // Tô đậm toàn hàng nếu STT không phải số
                            var row = dvThongTin.Rows[e.RowIndex];
                            row.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
                        }
                    }
                };



            }

        }

        private void FShowTraCuuC12_Load(object sender, EventArgs e)
        {
            LoadData(list);
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TraCuu");
            Directory.CreateDirectory(folder);
            filePath = Path.Combine(folder, $"C12_{AppState.Ten}.pdf");
            File.WriteAllBytes(filePath, dataPdf1);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu!", "Cảnh báo");
                return;
            }

            var firstItem = list[0];

            using (var context = new AppDbContext())
            {
                bool isExist = context.CheckTraCuuC12Exists(firstItem.Date, firstItem.userName);

                if (isExist)
                {
                    DialogResult result = MessageBox.Show("Dữ liệu tháng này đã tồn tại. Bạn có muốn ghi đè không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        context.DeleteTraCuuC12ByMonth(firstItem.Date, firstItem.userName);
                        context.TraCuuC12.AddRange(list);
                        context.SaveChanges();
                        foreach (var item in list)
                        {
                            item.Id = 0;
                        }
                        MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn lưu dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        context.TraCuuC12.AddRange(list);
                        context.SaveChanges();
                        foreach (var item in list)
                        {
                            item.Id = 0;
                        }
                        MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
                    }
                }
            }
        }

        private void btnViewPDF_Click(object sender, EventArgs e)
        {
            try
            {
                FViewPdf fViewPdf = new FViewPdf(dataPdf1);
                fViewPdf.ShowDialog();
            }
            catch
            {
            }
        }

        
    }
}
