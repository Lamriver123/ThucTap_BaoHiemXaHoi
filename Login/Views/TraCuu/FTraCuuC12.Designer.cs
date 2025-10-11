namespace Login.Views.TraCuu
{
    partial class FTraCuuC12
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
            panel1 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel11 = new Panel();
            txtNam = new TextBox();
            label3 = new Label();
            panel14 = new Panel();
            cbThang = new ComboBox();
            label2 = new Label();
            panel12 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnTraCuu = new FontAwesome.Sharp.IconButton();
            panel13 = new Panel();
            panel8 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel11.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(44, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 437);
            panel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel12);
            panel9.Controls.Add(panel13);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 167);
            panel9.Name = "panel9";
            panel9.Size = new Size(1036, 270);
            panel9.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.Controls.Add(tableLayoutPanel1);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(10, 10, 10, 10);
            panel10.Size = new Size(1036, 12);
            panel10.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel11, 1, 0);
            tableLayoutPanel1.Controls.Add(panel14, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1016, 0);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Controls.Add(txtNam);
            panel11.Controls.Add(label3);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(511, 3);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(10, 10, 10, 10);
            panel11.Size = new Size(502, 1);
            panel11.TabIndex = 7;
            // 
            // txtNam
            // 
            txtNam.Dock = DockStyle.Fill;
            txtNam.Font = new Font("Segoe UI", 18F);
            txtNam.Location = new Point(10, 70);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(482, 39);
            txtNam.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Size = new Size(482, 60);
            label3.TabIndex = 5;
            label3.Text = "Năm";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            panel14.Controls.Add(cbThang);
            panel14.Controls.Add(label2);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(3, 3);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(10, 10, 10, 10);
            panel14.Size = new Size(502, 1);
            panel14.TabIndex = 8;
            // 
            // cbThang
            // 
            cbThang.Dock = DockStyle.Fill;
            cbThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbThang.Font = new Font("Segoe UI", 18F);
            cbThang.FormattingEnabled = true;
            cbThang.Items.AddRange(new object[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" });
            cbThang.Location = new Point(10, 70);
            cbThang.MaxDropDownItems = 6;
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(482, 40);
            cbThang.TabIndex = 3;
            cbThang.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(482, 60);
            label2.TabIndex = 4;
            label2.Text = "Tháng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            panel12.Controls.Add(tableLayoutPanel2);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 12);
            panel12.Name = "panel12";
            panel12.Size = new Size(1036, 145);
            panel12.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnTraCuu, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(1036, 145);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = SystemColors.ActiveCaption;
            btnTraCuu.Dock = DockStyle.Fill;
            btnTraCuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.IconChar = FontAwesome.Sharp.IconChar.None;
            btnTraCuu.IconColor = Color.Black;
            btnTraCuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTraCuu.Location = new Point(348, 51);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(339, 42);
            btnTraCuu.TabIndex = 0;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(0, 157);
            panel13.Name = "panel13";
            panel13.Size = new Size(1036, 113);
            panel13.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 95);
            panel8.Name = "panel8";
            panel8.Size = new Size(1036, 72);
            panel8.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 95);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1036, 95);
            label1.TabIndex = 0;
            label1.Text = "TRA CỨU C12";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1132, 43);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(44, 507);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(44, 480);
            panel6.Name = "panel6";
            panel6.Size = new Size(1088, 70);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(1080, 43);
            panel7.Name = "panel7";
            panel7.Size = new Size(52, 437);
            panel7.TabIndex = 5;
            // 
            // FTraCuuC12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1132, 550);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTraCuuC12";
            Text = "FTraCuuC12";
            Load += FTraCuuC12_Load;
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel14.ResumeLayout(false);
            panel12.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbThang;
        private TextBox txtNam;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnTraCuu;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}