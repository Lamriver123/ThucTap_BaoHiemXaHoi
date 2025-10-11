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
            btnLuu = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnViewPDF = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dvThongTin).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dvThongTin
            // 
            dvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvThongTin.Dock = DockStyle.Fill;
            dvThongTin.Location = new Point(3, 3);
            dvThongTin.Name = "dvThongTin";
            dvThongTin.Size = new Size(1416, 890);
            dvThongTin.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Dock = DockStyle.Fill;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnLuu.IconColor = Color.MediumTurquoise;
            btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLuu.Location = new Point(13, 56);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(170, 63);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu vào database";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1475, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 890);
            panel1.TabIndex = 2;
            // 
            // btnViewPDF
            // 
            btnViewPDF.Dock = DockStyle.Fill;
            btnViewPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewPDF.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnViewPDF.IconColor = Color.Lime;
            btnViewPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewPDF.Location = new Point(13, 151);
            btnViewPDF.Name = "btnViewPDF";
            btnViewPDF.Size = new Size(170, 63);
            btnViewPDF.TabIndex = 2;
            btnViewPDF.Text = "Xem file PDF";
            btnViewPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViewPDF.UseVisualStyleBackColor = true;
            btnViewPDF.Click += btnViewPDF_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(20, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(1674, 896);
            panel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.0052948F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.99396181F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0007467F));
            tableLayoutPanel1.Controls.Add(dvThongTin, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1674, 896);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnLuu, 0, 1);
            tableLayoutPanel2.Controls.Add(btnViewPDF, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 76F));
            tableLayoutPanel2.Size = new Size(196, 890);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // FShowTraCuuC12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1714, 936);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FShowTraCuuC12";
            Padding = new Padding(20);
            Text = "FShowTraCuuC12";
            Load += FShowTraCuuC12_Load;
            ((System.ComponentModel.ISupportInitialize)dvThongTin).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvThongTin;
        private FontAwesome.Sharp.IconButton btnLuu;
        private Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnViewPDF;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}