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

namespace Login.Views.TraCuu
{
    public partial class FShowTraCuuC12 : Form
    {
        public FShowTraCuuC12(List<TraCuuC12Models> list)
        {
            InitializeComponent();
            LoadData(list);
        }

        private void LoadData(List<TraCuuC12Models> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu bảng trong PDF");
            }
            else
            {
                dvThongTin.AutoGenerateColumns = false;
                dvThongTin.Columns.Clear();

                dvThongTin.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "STT",
                    HeaderText = "STT"
                });
                dvThongTin.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NoiDung",
                    HeaderText = "Nội dung"
                });
                dvThongTin.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "BHXH_OD_TS",
                    HeaderText = "BHXH OD TS"
                });
                dvThongTin.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "BHXH_HTTT",
                    HeaderText = "BHXH HTTT"
                });
                dvThongTin.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "BHYT",
                    HeaderText = "BHYT"
                });
                dvThongTin.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "BHTN",
                    HeaderText = "BHTN"
                });
                dvThongTin.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "BHTNLD_BNN",
                    HeaderText = "BHTNLD_BNN"
                });
                dvThongTin.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Cong",
                    HeaderText = "Cộng"
                });


                dvThongTin.DataSource = list;

            }
        }

        private void FShowTraCuuC12_Load(object sender, EventArgs e)
        {
            
        }
    }
}
