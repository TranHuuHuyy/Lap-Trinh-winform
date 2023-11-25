namespace GongMe
{
    partial class FrmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.linkforgotpass = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ckbLuuThongTin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.textboxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxUserid = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.PicMilkTea = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMilkTea)).BeginInit();
            this.SuspendLayout();
            // 
            // linkforgotpass
            // 
            this.linkforgotpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.linkforgotpass.AutoSize = true;
            this.linkforgotpass.Font = new System.Drawing.Font("Arial", 8.5F);
            this.linkforgotpass.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkforgotpass.Location = new System.Drawing.Point(320, 369);
            this.linkforgotpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkforgotpass.Name = "linkforgotpass";
            this.linkforgotpass.Size = new System.Drawing.Size(91, 15);
            this.linkforgotpass.TabIndex = 4;
            this.linkforgotpass.TabStop = true;
            this.linkforgotpass.Text = "Quên mật khẩu";
            this.linkforgotpass.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkforgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkforgotpass_LinkClicked);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoRoundedCorners = true;
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangNhap.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnDangNhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(287, 263);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(125, 42);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ckbLuuThongTin
            // 
            this.ckbLuuThongTin.AutoSize = true;
            this.ckbLuuThongTin.CheckedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ckbLuuThongTin.CheckedState.BorderRadius = 7;
            this.ckbLuuThongTin.CheckedState.BorderThickness = 0;
            this.ckbLuuThongTin.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.ckbLuuThongTin.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ckbLuuThongTin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ckbLuuThongTin.Location = new System.Drawing.Point(168, 276);
            this.ckbLuuThongTin.Name = "ckbLuuThongTin";
            this.ckbLuuThongTin.Size = new System.Drawing.Size(99, 18);
            this.ckbLuuThongTin.TabIndex = 3;
            this.ckbLuuThongTin.Text = "Lưu đăng nhập";
            this.ckbLuuThongTin.UncheckedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ckbLuuThongTin.UncheckedState.BorderRadius = 7;
            this.ckbLuuThongTin.UncheckedState.BorderThickness = 0;
            this.ckbLuuThongTin.UncheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // textboxPass
            // 
            this.textboxPass.Animated = true;
            this.textboxPass.BackColor = System.Drawing.Color.Transparent;
            this.textboxPass.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.textboxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPass.DefaultText = "";
            this.textboxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxPass.Font = new System.Drawing.Font("Arial", 9F);
            this.textboxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxPass.IconLeft = global::GongMe.Properties.Resources.password;
            this.textboxPass.Location = new System.Drawing.Point(60, 209);
            this.textboxPass.Margin = new System.Windows.Forms.Padding(2);
            this.textboxPass.Name = "textboxPass";
            this.textboxPass.PasswordChar = '●';
            this.textboxPass.PlaceholderText = "Mật khẩu";
            this.textboxPass.SelectedText = "";
            this.textboxPass.Size = new System.Drawing.Size(300, 35);
            this.textboxPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textboxPass.TabIndex = 1;
            this.textboxPass.UseSystemPasswordChar = true;
            this.textboxPass.IconLeftClick += new System.EventHandler(this.textboxPass_IconLeftClick);
            // 
            // textboxUserid
            // 
            this.textboxUserid.Animated = true;
            this.textboxUserid.BackColor = System.Drawing.Color.Transparent;
            this.textboxUserid.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.textboxUserid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxUserid.DefaultText = "";
            this.textboxUserid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxUserid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxUserid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxUserid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxUserid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxUserid.Font = new System.Drawing.Font("Arial", 9F);
            this.textboxUserid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxUserid.IconLeft = global::GongMe.Properties.Resources.user;
            this.textboxUserid.Location = new System.Drawing.Point(60, 160);
            this.textboxUserid.Margin = new System.Windows.Forms.Padding(2);
            this.textboxUserid.Name = "textboxUserid";
            this.textboxUserid.PasswordChar = '\0';
            this.textboxUserid.PlaceholderText = "Tên đăng nhập";
            this.textboxUserid.SelectedText = "";
            this.textboxUserid.Size = new System.Drawing.Size(300, 35);
            this.textboxUserid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textboxUserid.TabIndex = 0;
            this.textboxUserid.MouseHover += new System.EventHandler(this.textboxUserid_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::GongMe.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(821, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 22);
            this.btnExit.TabIndex = 16;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GongMe.Properties.Resources.NEWLOGO;
            this.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picLogo.Location = new System.Drawing.Point(94, 35);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(237, 101);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            // 
            // PicMilkTea
            // 
            this.PicMilkTea.Image = global::GongMe.Properties.Resources._1;
            this.PicMilkTea.Location = new System.Drawing.Point(414, 6);
            this.PicMilkTea.Name = "PicMilkTea";
            this.PicMilkTea.Size = new System.Drawing.Size(438, 395);
            this.PicMilkTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMilkTea.TabIndex = 12;
            this.PicMilkTea.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::GongMe.Properties.Resources.minimize1;
            this.btnMinimize.Location = new System.Drawing.Point(796, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 395);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.textboxPass);
            this.Controls.Add(this.textboxUserid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.PicMilkTea);
            this.Controls.Add(this.ckbLuuThongTin);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.linkforgotpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMilkTea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkforgotpass;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;
        private Guna.UI2.WinForms.Guna2CheckBox ckbLuuThongTin;
        private System.Windows.Forms.PictureBox PicMilkTea;
        private System.Windows.Forms.PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox textboxPass;
        private Guna.UI2.WinForms.Guna2TextBox textboxUserid;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
    }
}