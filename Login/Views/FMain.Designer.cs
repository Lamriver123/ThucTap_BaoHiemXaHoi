namespace Login.Views
{
    partial class FMain
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
            pHeader = new Panel();
            btnHome = new FontAwesome.Sharp.IconButton();
            pDaDangNhap = new Panel();
            btnDangXuat = new ComboBox();
            pDangNhap = new Panel();
            btnDangNhap = new FontAwesome.Sharp.IconButton();
            pBody = new Panel();
            pHeader.SuspendLayout();
            pDaDangNhap.SuspendLayout();
            pDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // pHeader
            // 
            pHeader.BackColor = SystemColors.ActiveCaption;
            pHeader.Controls.Add(btnHome);
            pHeader.Controls.Add(pDaDangNhap);
            pHeader.Controls.Add(pDangNhap);
            pHeader.Dock = DockStyle.Top;
            pHeader.Location = new Point(0, 0);
            pHeader.Name = "pHeader";
            pHeader.Size = new Size(1904, 65);
            pHeader.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ActiveCaption;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.DarkOliveGreen;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.Location = new Point(28, 5);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(54, 54);
            btnHome.TabIndex = 2;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pDaDangNhap
            // 
            pDaDangNhap.Controls.Add(btnDangXuat);
            pDaDangNhap.Dock = DockStyle.Right;
            pDaDangNhap.Location = new Point(1516, 0);
            pDaDangNhap.Name = "pDaDangNhap";
            pDaDangNhap.Size = new Size(234, 65);
            pDaDangNhap.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = SystemColors.Window;
            btnDangXuat.FormattingEnabled = true;
            btnDangXuat.Items.AddRange(new object[] { "Đăng xuất" });
            btnDangXuat.Location = new Point(0, 22);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(220, 23);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Nguyễn Hữu Ngọc Lam";
            btnDangXuat.SelectedIndexChanged += btnDangXuat_SelectedIndexChanged;
            // 
            // pDangNhap
            // 
            pDangNhap.Controls.Add(btnDangNhap);
            pDangNhap.Dock = DockStyle.Right;
            pDangNhap.Location = new Point(1750, 0);
            pDangNhap.Name = "pDangNhap";
            pDangNhap.Size = new Size(154, 65);
            pDangNhap.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.RoyalBlue;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.ButtonFace;
            btnDangNhap.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDangNhap.IconColor = Color.Black;
            btnDangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDangNhap.Location = new Point(15, 9);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(121, 40);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pBody
            // 
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(0, 65);
            pBody.Name = "pBody";
            pBody.Size = new Size(1904, 976);
            pBody.TabIndex = 2;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pBody);
            Controls.Add(pHeader);
            Name = "FMain";
            Text = "FMain";
            WindowState = FormWindowState.Maximized;
            Load += FMain_Load;
            pHeader.ResumeLayout(false);
            pDaDangNhap.ResumeLayout(false);
            pDangNhap.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pHeader;
        private Panel pDaDangNhap;
        private ComboBox btnDangXuat;
        private Panel pDangNhap;
        private FontAwesome.Sharp.IconButton btnDangNhap;
        private Panel pBody;
        private FontAwesome.Sharp.IconButton btnHome;
    }
}