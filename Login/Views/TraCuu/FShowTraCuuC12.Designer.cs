namespace Login.Views.TraCuu
{
    partial class FShowTraCuuC12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dvThongTin = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvThongTin).BeginInit();
            SuspendLayout();
            // 
            // dvThongTin
            // 
            dvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvThongTin.Dock = DockStyle.Fill;
            dvThongTin.Location = new Point(20, 20);
            dvThongTin.Name = "dvThongTin";
            dvThongTin.Size = new Size(1674, 896);
            dvThongTin.TabIndex = 0;
            // 
            // FShowTraCuuC12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 936);
            Controls.Add(dvThongTin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FShowTraCuuC12";
            Padding = new Padding(20);
            Text = "FShowTraCuuC12";
            Load += FShowTraCuuC12_Load;
            ((System.ComponentModel.ISupportInitialize)dvThongTin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvThongTin;
    }
}