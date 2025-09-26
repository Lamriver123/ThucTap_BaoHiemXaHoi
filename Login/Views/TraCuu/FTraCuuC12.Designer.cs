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
            label3 = new Label();
            label2 = new Label();
            cbThang = new ComboBox();
            txtNam = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            btnTraCuu = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbThang);
            panel1.Controls.Add(txtNam);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnTraCuu);
            panel1.Location = new Point(314, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 530);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(362, 180);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 5;
            label3.Text = "Năm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 180);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 4;
            label2.Text = "Tháng";
            // 
            // cbThang
            // 
            cbThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbThang.Font = new Font("Segoe UI", 18F);
            cbThang.FormattingEnabled = true;
            cbThang.Items.AddRange(new object[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" });
            cbThang.Location = new Point(36, 214);
            cbThang.MaxDropDownItems = 6;
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(304, 40);
            cbThang.TabIndex = 3;
            cbThang.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNam
            // 
            txtNam.Font = new Font("Segoe UI", 18F);
            txtNam.Location = new Point(362, 214);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(283, 39);
            txtNam.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 95);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(259, 35);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "TRA CỨU C12";
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = SystemColors.ActiveCaption;
            btnTraCuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.IconChar = FontAwesome.Sharp.IconChar.None;
            btnTraCuu.IconColor = Color.Black;
            btnTraCuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTraCuu.Location = new Point(95, 344);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(489, 60);
            btnTraCuu.TabIndex = 0;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // FTraCuuC12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 936);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTraCuuC12";
            Text = "FTraCuuC12";
            Load += FTraCuuC12_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}