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
        public FViewPdf(string filePath)
        {
            InitializeComponent();
            LoadPdf(filePath);
        }
        private void LoadPdf(string filePath)
        {
            var pdfDocument = PdfiumViewer.PdfDocument.Load(filePath);
            var pdfViewer = new PdfViewer
            {
                Document = pdfDocument,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(pdfViewer);
        }
    }
}
