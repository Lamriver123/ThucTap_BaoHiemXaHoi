namespace Login
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            panel19 = new Panel();
            btnDangNhap = new Button();
            panel18 = new Panel();
            panel17 = new Panel();
            panel12 = new Panel();
            txtCaptcha = new TextBox();
            panel16 = new Panel();
            panel13 = new Panel();
            label3 = new Label();
            panel11 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            picCaptcha = new PictureBox();
            panel8 = new Panel();
            panel6 = new Panel();
            txtPassword = new TextBox();
            panel15 = new Panel();
            panel7 = new Panel();
            lblPass = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            txtUsername = new TextBox();
            panel14 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel21 = new Panel();
            cbDoanhNghiep = new CheckBox();
            panel20 = new Panel();
            cbCaNhan = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel19.SuspendLayout();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCaptcha).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel21.SuspendLayout();
            panel20.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel19);
            panel1.Controls.Add(panel18);
            panel1.Controls.Add(panel17);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 403);
            panel1.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.Controls.Add(btnDangNhap);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(0, 321);
            panel19.Name = "panel19";
            panel19.Size = new Size(467, 62);
            panel19.TabIndex = 23;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DarkTurquoise;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(24, 18);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(421, 38);
            btnDangNhap.TabIndex = 12;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel18
            // 
            panel18.Dock = DockStyle.Bottom;
            panel18.Location = new Point(0, 383);
            panel18.Name = "panel18";
            panel18.Size = new Size(467, 18);
            panel18.TabIndex = 22;
            // 
            // panel17
            // 
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 291);
            panel17.Name = "panel17";
            panel17.Size = new Size(467, 30);
            panel17.TabIndex = 21;
            // 
            // panel12
            // 
            panel12.Controls.Add(txtCaptcha);
            panel12.Controls.Add(panel16);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(label3);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 256);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(20, 0, 0, 0);
            panel12.Size = new Size(467, 35);
            panel12.TabIndex = 20;
            // 
            // txtCaptcha
            // 
            txtCaptcha.Dock = DockStyle.Fill;
            txtCaptcha.Font = new Font("Segoe UI", 14.25F);
            txtCaptcha.Location = new Point(131, 0);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(314, 33);
            txtCaptcha.TabIndex = 8;
            // 
            // panel16
            // 
            panel16.Dock = DockStyle.Right;
            panel16.Location = new Point(445, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(22, 35);
            panel16.TabIndex = 12;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(117, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(14, 35);
            panel13.TabIndex = 11;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(20, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 35);
            label3.TabIndex = 10;
            label3.Text = "Captcha";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 241);
            panel11.Name = "panel11";
            panel11.Size = new Size(467, 15);
            panel11.TabIndex = 19;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(picCaptcha);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 164);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(100, 0, 0, 0);
            panel9.Size = new Size(467, 77);
            panel9.TabIndex = 18;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnRefresh);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(347, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(120, 77);
            panel10.TabIndex = 12;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Control;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.DarkTurquoise;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.Location = new Point(39, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(44, 43);
            btnRefresh.TabIndex = 11;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // picCaptcha
            // 
            picCaptcha.Dock = DockStyle.Left;
            picCaptcha.Location = new Point(100, 0);
            picCaptcha.Name = "picCaptcha";
            picCaptcha.Size = new Size(247, 77);
            picCaptcha.SizeMode = PictureBoxSizeMode.Zoom;
            picCaptcha.TabIndex = 7;
            picCaptcha.TabStop = false;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 152);
            panel8.Name = "panel8";
            panel8.Size = new Size(467, 12);
            panel8.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtPassword);
            panel6.Controls.Add(panel15);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(lblPass);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 116);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 0, 0, 0);
            panel6.Size = new Size(467, 36);
            panel6.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 14.25F);
            txtPassword.Location = new Point(131, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 33);
            txtPassword.TabIndex = 4;
            // 
            // panel15
            // 
            panel15.Dock = DockStyle.Right;
            panel15.Location = new Point(445, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(22, 36);
            panel15.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(117, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(14, 36);
            panel7.TabIndex = 7;
            // 
            // lblPass
            // 
            lblPass.Dock = DockStyle.Left;
            lblPass.Font = new Font("Segoe UI", 14.25F);
            lblPass.Location = new Point(20, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(97, 36);
            lblPass.TabIndex = 6;
            lblPass.Text = "Password";
            lblPass.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(467, 24);
            panel5.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(panel14);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 0, 0, 0);
            panel3.Size = new Size(467, 34);
            panel3.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 14.25F);
            txtUsername.Location = new Point(131, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(314, 33);
            txtUsername.TabIndex = 3;
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Right;
            panel14.Location = new Point(445, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(22, 34);
            panel14.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(117, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 34);
            panel4.TabIndex = 6;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(20, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 34);
            label2.TabIndex = 5;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel21);
            panel2.Controls.Add(panel20);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 58);
            panel2.TabIndex = 13;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbDoanhNghiep);
            panel21.Dock = DockStyle.Fill;
            panel21.Location = new Point(287, 0);
            panel21.Name = "panel21";
            panel21.Padding = new Padding(10, 10, 10, 10);
            panel21.Size = new Size(180, 58);
            panel21.TabIndex = 4;
            // 
            // cbDoanhNghiep
            // 
            cbDoanhNghiep.AutoSize = true;
            cbDoanhNghiep.Dock = DockStyle.Fill;
            cbDoanhNghiep.Location = new Point(10, 10);
            cbDoanhNghiep.Name = "cbDoanhNghiep";
            cbDoanhNghiep.Size = new Size(160, 38);
            cbDoanhNghiep.TabIndex = 2;
            cbDoanhNghiep.Text = "Doanh nghiệp";
            cbDoanhNghiep.UseVisualStyleBackColor = true;
            cbDoanhNghiep.Click += cbDoanhNghiep_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(cbCaNhan);
            panel20.Dock = DockStyle.Left;
            panel20.Location = new Point(111, 0);
            panel20.Name = "panel20";
            panel20.Padding = new Padding(10, 10, 10, 10);
            panel20.Size = new Size(176, 58);
            panel20.TabIndex = 3;
            // 
            // cbCaNhan
            // 
            cbCaNhan.AutoSize = true;
            cbCaNhan.Dock = DockStyle.Fill;
            cbCaNhan.Location = new Point(10, 10);
            cbCaNhan.Name = "cbCaNhan";
            cbCaNhan.Size = new Size(156, 38);
            cbCaNhan.TabIndex = 1;
            cbCaNhan.Text = "Cá nhân";
            cbCaNhan.UseVisualStyleBackColor = true;
            cbCaNhan.Click += cbCaNhan_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 0, 0);
            label1.Size = new Size(111, 58);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(495, 433);
            Controls.Add(panel1);
            Name = "FLogin";
            Padding = new Padding(5, 5, 5, 5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCaptcha).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label lblPass;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private CheckBox cbDoanhNghiep;
        private CheckBox cbCaNhan;
        private Label label1;
        private PictureBox picCaptcha;
        private TextBox txtCaptcha;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Button btnDangNhap;
        private Panel panel3;
        private Panel panel2;
        private Panel panel9;
        private Panel panel10;
        private Panel panel8;
        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private Panel panel4;
        private Panel panel18;
        private Panel panel17;
        private Panel panel12;
        private Panel panel16;
        private Panel panel13;
        private Panel panel11;
        private Panel panel15;
        private Panel panel14;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
    }
}
