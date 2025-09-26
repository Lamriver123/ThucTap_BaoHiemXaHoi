using Login.Views.TraCuu;
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
    public partial class FTraCuu : Form
    {
        public FTraCuu()
        {
            InitializeComponent();
        }

        private void btnTraCuuC12_Click(object sender, EventArgs e)
        {
            openChildForm(new FTraCuuC12());
        }

        private void FTraCuu_Load(object sender, EventArgs e)
        {
            if(AppState.loaiDoiTuong == 0)
            {
                pTraCuuC12.Hide();
            }
            else
            {
                pTraCuuC12.Show();
                btnTraCuuC12_Click(sender, e);
            }

        }
        public void openChildForm(Form frm)
        {
            pBody.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pBody.Controls.Add(frm);
            frm.Show();
        }
    }
}
