namespace Login
{
    partial class FTraCuu
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
            pMenu = new Panel();
            pTraCuu = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            pTraCuuC12 = new Panel();
            btnTraCuuC12 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel1 = new Panel();
            pBody = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pMenu.SuspendLayout();
            pTraCuu.SuspendLayout();
            pTraCuuC12.SuspendLayout();
            SuspendLayout();
            // 
            // pMenu
            // 
            pMenu.BackColor = SystemColors.GradientInactiveCaption;
            pMenu.Controls.Add(pTraCuu);
            pMenu.Controls.Add(pTraCuuC12);
            pMenu.Controls.Add(panel1);
            pMenu.Dock = DockStyle.Left;
            pMenu.Location = new Point(0, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(200, 936);
            pMenu.TabIndex = 0;
            // 
            // pTraCuu
            // 
            pTraCuu.AutoSize = true;
            pTraCuu.Controls.Add(iconButton2);
            pTraCuu.Controls.Add(panel4);
            pTraCuu.Dock = DockStyle.Top;
            pTraCuu.Location = new Point(0, 105);
            pTraCuu.Name = "pTraCuu";
            pTraCuu.Size = new Size(200, 49);
            pTraCuu.TabIndex = 4;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(0, 11);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(200, 38);
            iconButton2.TabIndex = 4;
            iconButton2.Text = "Tra cứu ...";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 11);
            panel4.TabIndex = 3;
            // 
            // pTraCuuC12
            // 
            pTraCuuC12.AutoSize = true;
            pTraCuuC12.Controls.Add(btnTraCuuC12);
            pTraCuuC12.Controls.Add(panel2);
            pTraCuuC12.Dock = DockStyle.Top;
            pTraCuuC12.Location = new Point(0, 56);
            pTraCuuC12.Name = "pTraCuuC12";
            pTraCuuC12.Size = new Size(200, 49);
            pTraCuuC12.TabIndex = 3;
            // 
            // btnTraCuuC12
            // 
            btnTraCuuC12.BackColor = Color.MediumTurquoise;
            btnTraCuuC12.Dock = DockStyle.Top;
            btnTraCuuC12.FlatStyle = FlatStyle.Flat;
            btnTraCuuC12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuuC12.IconChar = FontAwesome.Sharp.IconChar.None;
            btnTraCuuC12.IconColor = Color.Black;
            btnTraCuuC12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTraCuuC12.Location = new Point(0, 11);
            btnTraCuuC12.Name = "btnTraCuuC12";
            btnTraCuuC12.Size = new Size(200, 38);
            btnTraCuuC12.TabIndex = 4;
            btnTraCuuC12.Text = "Tra Cứu C12";
            btnTraCuuC12.UseVisualStyleBackColor = false;
            btnTraCuuC12.Click += btnTraCuuC12_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 11);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 56);
            panel1.TabIndex = 1;
            // 
            // pBody
            // 
            pBody.AutoSize = true;
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(200, 0);
            pBody.Name = "pBody";
            pBody.Size = new Size(1714, 936);
            pBody.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FTraCuu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1914, 936);
            Controls.Add(pBody);
            Controls.Add(pMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTraCuu";
            Text = "FTraCuu";
            Load += FTraCuu_Load;
            pMenu.ResumeLayout(false);
            pMenu.PerformLayout();
            pTraCuu.ResumeLayout(false);
            pTraCuuC12.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pMenu;
        private Panel pBody;
        private Panel panel1;
        private Panel pTraCuuC12;
        private Panel panel2;
        private Panel pTraCuu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnTraCuuC12;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}