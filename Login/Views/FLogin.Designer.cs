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
            btnDangNhap = new Button();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtCaptcha = new TextBox();
            picCaptcha = new PictureBox();
            lblPass = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cbDoanhNghiep = new CheckBox();
            cbCaNhan = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCaptcha).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCaptcha);
            panel1.Controls.Add(picCaptcha);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(cbDoanhNghiep);
            panel1.Controls.Add(cbCaNhan);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 403);
            panel1.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DarkTurquoise;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(19, 327);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(421, 38);
            btnDangNhap.TabIndex = 12;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Control;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.DarkTurquoise;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.Location = new Point(396, 174);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(44, 43);
            btnRefresh.TabIndex = 11;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(19, 254);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 10;
            label3.Text = "Captcha";
            // 
            // txtCaptcha
            // 
            txtCaptcha.Font = new Font("Segoe UI", 14.25F);
            txtCaptcha.Location = new Point(121, 250);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(319, 33);
            txtCaptcha.TabIndex = 8;
            // 
            // picCaptcha
            // 
            picCaptcha.Location = new Point(122, 165);
            picCaptcha.Name = "picCaptcha";
            picCaptcha.Size = new Size(247, 65);
            picCaptcha.SizeMode = PictureBoxSizeMode.Zoom;
            picCaptcha.TabIndex = 7;
            picCaptcha.TabStop = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 14.25F);
            lblPass.Location = new Point(18, 115);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(91, 25);
            lblPass.TabIndex = 6;
            lblPass.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F);
            txtPassword.Location = new Point(121, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 33);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F);
            txtUsername.Location = new Point(121, 64);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(319, 33);
            txtUsername.TabIndex = 3;
            // 
            // cbDoanhNghiep
            // 
            cbDoanhNghiep.AutoSize = true;
            cbDoanhNghiep.Location = new Point(283, 20);
            cbDoanhNghiep.Name = "cbDoanhNghiep";
            cbDoanhNghiep.Size = new Size(101, 19);
            cbDoanhNghiep.TabIndex = 2;
            cbDoanhNghiep.Text = "Doanh nghiệp";
            cbDoanhNghiep.UseVisualStyleBackColor = true;
            cbDoanhNghiep.Click += cbDoanhNghiep_Click;
            // 
            // cbCaNhan
            // 
            cbCaNhan.AutoSize = true;
            cbCaNhan.Location = new Point(176, 19);
            cbCaNhan.Name = "cbCaNhan";
            cbCaNhan.Size = new Size(70, 19);
            cbCaNhan.TabIndex = 1;
            cbCaNhan.Text = "Cá nhân";
            cbCaNhan.UseVisualStyleBackColor = true;
            cbCaNhan.Click += cbCaNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(45, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Login";
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
            Padding = new Padding(5);
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCaptcha).EndInit();
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
    }
}
