namespace GongMe.PresentionTier
{
    partial class FrmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuenMatKhau));
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbQuenMatKhau = new System.Windows.Forms.Label();
            this.lbMaXacNhan = new System.Windows.Forms.Label();
            this.txtMaXacNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLayMa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbNhapLai = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ckbShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(134, 85);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(261, 29);
            this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmail.TabIndex = 0;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbEmail.Location = new System.Drawing.Point(69, 95);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 19);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "Email";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoRoundedCorners = true;
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BorderRadius = 20;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXacNhan.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnXacNhan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(191, 181);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(133, 43);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lbQuenMatKhau
            // 
            this.lbQuenMatKhau.AutoSize = true;
            this.lbQuenMatKhau.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuenMatKhau.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbQuenMatKhau.Location = new System.Drawing.Point(165, 27);
            this.lbQuenMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuenMatKhau.Name = "lbQuenMatKhau";
            this.lbQuenMatKhau.Size = new System.Drawing.Size(186, 29);
            this.lbQuenMatKhau.TabIndex = 10;
            this.lbQuenMatKhau.Text = "Quên mật khẩu";
            // 
            // lbMaXacNhan
            // 
            this.lbMaXacNhan.AutoSize = true;
            this.lbMaXacNhan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbMaXacNhan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbMaXacNhan.Location = new System.Drawing.Point(15, 144);
            this.lbMaXacNhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaXacNhan.Name = "lbMaXacNhan";
            this.lbMaXacNhan.Size = new System.Drawing.Size(105, 19);
            this.lbMaXacNhan.TabIndex = 10;
            this.lbMaXacNhan.Text = "Mã xác nhận";
            // 
            // txtMaXacNhan
            // 
            this.txtMaXacNhan.Animated = true;
            this.txtMaXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.txtMaXacNhan.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMaXacNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaXacNhan.DefaultText = "";
            this.txtMaXacNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaXacNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaXacNhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaXacNhan.Font = new System.Drawing.Font("Arial", 9F);
            this.txtMaXacNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaXacNhan.Location = new System.Drawing.Point(134, 134);
            this.txtMaXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaXacNhan.Name = "txtMaXacNhan";
            this.txtMaXacNhan.PasswordChar = '\0';
            this.txtMaXacNhan.PlaceholderText = "Mã xác nhận";
            this.txtMaXacNhan.SelectedText = "";
            this.txtMaXacNhan.Size = new System.Drawing.Size(261, 29);
            this.txtMaXacNhan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMaXacNhan.TabIndex = 2;
            // 
            // btnLayMa
            // 
            this.btnLayMa.AutoRoundedCorners = true;
            this.btnLayMa.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLayMa.BorderRadius = 16;
            this.btnLayMa.BorderThickness = 1;
            this.btnLayMa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLayMa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLayMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLayMa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLayMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLayMa.FillColor = System.Drawing.Color.White;
            this.btnLayMa.FillColor2 = System.Drawing.Color.White;
            this.btnLayMa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLayMa.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLayMa.Location = new System.Drawing.Point(415, 79);
            this.btnLayMa.Name = "btnLayMa";
            this.btnLayMa.Size = new System.Drawing.Size(80, 35);
            this.btnLayMa.TabIndex = 1;
            this.btnLayMa.Text = "Lấy mã";
            this.btnLayMa.Click += new System.EventHandler(this.btnLayMa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(158, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đặt lại mật khẩu";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Animated = true;
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhauMoi.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.DefaultText = "";
            this.txtMatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauMoi.Enabled = false;
            this.txtMatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Arial", 9F);
            this.txtMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(138, 321);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '●';
            this.txtMatKhauMoi.PlaceholderText = "Mật khẩu mới";
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(261, 29);
            this.txtMatKhauMoi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMatKhauMoi.TabIndex = 4;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbMatKhauMoi.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(19, 329);
            this.lbMatKhauMoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(111, 19);
            this.lbMatKhauMoi.TabIndex = 10;
            this.lbMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lbNhapLai
            // 
            this.lbNhapLai.AutoSize = true;
            this.lbNhapLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbNhapLai.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbNhapLai.Location = new System.Drawing.Point(58, 379);
            this.lbNhapLai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNhapLai.Name = "lbNhapLai";
            this.lbNhapLai.Size = new System.Drawing.Size(71, 19);
            this.lbNhapLai.TabIndex = 10;
            this.lbNhapLai.Text = "Nhập lại";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Animated = true;
            this.txtNhapLaiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtNhapLaiMatKhau.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNhapLaiMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiMatKhau.DefaultText = "";
            this.txtNhapLaiMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapLaiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapLaiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiMatKhau.Enabled = false;
            this.txtNhapLaiMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Arial", 9F);
            this.txtNhapLaiMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(138, 372);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '●';
            this.txtNhapLaiMatKhau.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtNhapLaiMatKhau.SelectedText = "";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(261, 29);
            this.txtNhapLaiMatKhau.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNhapLaiMatKhau.TabIndex = 5;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AutoRoundedCorners = true;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiMatKhau.BorderRadius = 21;
            this.btnDoiMatKhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMatKhau.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMatKhau.Enabled = false;
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDoiMatKhau.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(169, 417);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(180, 45);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Đặt Lại Mật Khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // ckbShowPass
            // 
            this.ckbShowPass.AutoSize = true;
            this.ckbShowPass.CheckedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ckbShowPass.CheckedState.BorderRadius = 7;
            this.ckbShowPass.CheckedState.BorderThickness = 0;
            this.ckbShowPass.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.ckbShowPass.Enabled = false;
            this.ckbShowPass.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ckbShowPass.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ckbShowPass.Location = new System.Drawing.Point(419, 355);
            this.ckbShowPass.Name = "ckbShowPass";
            this.ckbShowPass.Size = new System.Drawing.Size(55, 18);
            this.ckbShowPass.TabIndex = 14;
            this.ckbShowPass.Text = "Show";
            this.ckbShowPass.UncheckedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ckbShowPass.UncheckedState.BorderRadius = 7;
            this.ckbShowPass.UncheckedState.BorderThickness = 0;
            this.ckbShowPass.UncheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.ckbShowPass.CheckedChanged += new System.EventHandler(this.ckbShowPass_CheckedChanged);
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
            this.btnExit.Location = new System.Drawing.Point(486, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 22);
            this.btnExit.TabIndex = 18;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(461, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 21;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 478);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ckbShowPass);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnLayMa);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbQuenMatKhau);
            this.Controls.Add(this.lbMaXacNhan);
            this.Controls.Add(this.lbNhapLai);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtMaXacNhan);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmQuenMatKhau_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private Guna.UI2.WinForms.Guna2GradientButton btnXacNhan;
        private System.Windows.Forms.Label lbQuenMatKhau;
        private System.Windows.Forms.Label lbMaXacNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtMaXacNhan;
        private Guna.UI2.WinForms.Guna2GradientButton btnLayMa;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Label lbNhapLai;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiMatKhau;
        private Guna.UI2.WinForms.Guna2GradientButton btnDoiMatKhau;
        private Guna.UI2.WinForms.Guna2CheckBox ckbShowPass;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
    }
}