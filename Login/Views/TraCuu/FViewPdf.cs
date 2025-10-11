using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using PdfiumViewer;
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
    public partial class FViewPdf : Form
    {
        private PdfViewer pdfViewer;
        private PdfDocument pdfDocument;
        public FViewPdf(byte[] dataPdf)
        {
            InitializeComponent();
            LoadPdf(dataPdf);

            this.FormClosed += FViewPdf_FormClosed;
        }
        private void LoadPdf(byte[] dataPdf)
        {
            // Dùng MemoryStream thay vì file
            var stream = new MemoryStream(dataPdf);
            pdfDocument = PdfDocument.Load(stream);

            pdfViewer = new PdfViewer
            {
                Document = pdfDocument,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(pdfViewer);
        }

        private void FViewPdf_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                // Giải phóng tài nguyên
                pdfViewer?.Dispose();
                pdfDocument?.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi giải phóng PDF: {ex.Message}");
            }
        }
    }
}
