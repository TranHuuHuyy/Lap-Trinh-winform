namespace GongMe.PresentionTier
{
    partial class FrmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThanhToan));
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTienKhachTra = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTienThua = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTienThua = new System.Windows.Forms.Label();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.pnlTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnInHD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoRoundedCorners = true;
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.BorderRadius = 20;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThanhToan.FillColor2 = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btnThanhToan, "btnThanhToan");
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Name = "btnThanhToan";
            // 
            // txtTienKhachTra
            // 
            this.txtTienKhachTra.Animated = true;
            this.txtTienKhachTra.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTienKhachTra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienKhachTra.DefaultText = "";
            this.txtTienKhachTra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienKhachTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienKhachTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienKhachTra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienKhachTra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtTienKhachTra, "txtTienKhachTra");
            this.txtTienKhachTra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienKhachTra.Name = "txtTienKhachTra";
            this.txtTienKhachTra.PasswordChar = '\0';
            this.txtTienKhachTra.PlaceholderText = "Số tiền khách trả";
            this.txtTienKhachTra.SelectedText = "";
            this.txtTienKhachTra.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTienKhachTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKhachTra_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Name = "label1";
            // 
            // txtTienThua
            // 
            this.txtTienThua.Animated = true;
            this.txtTienThua.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTienThua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienThua.DefaultText = "";
            this.txtTienThua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienThua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienThua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienThua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.txtTienThua, "txtTienThua");
            this.txtTienThua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienThua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.PasswordChar = '\0';
            this.txtTienThua.PlaceholderText = "Tiền thừa";
            this.txtTienThua.SelectedText = "";
            this.txtTienThua.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            // 
            // lbTienThua
            // 
            resources.ApplyResources(this.lbTienThua, "lbTienThua");
            this.lbTienThua.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTienThua.Name = "lbTienThua";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Animated = true;
            this.txtThanhTien.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.txtThanhTien, "txtThanhTien");
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "Thành tiền";
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            // 
            // lbThanhTien
            // 
            resources.ApplyResources(this.lbThanhTien, "lbThanhTien");
            this.lbThanhTien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbThanhTien.ForeColor = System.Drawing.Color.White;
            this.lbThanhTien.Name = "lbThanhTien";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlTop.Controls.Add(this.txtThanhTien);
            this.pnlTop.Controls.Add(this.lbThanhTien);
            resources.ApplyResources(this.pnlTop, "pnlTop");
            this.pnlTop.Name = "pnlTop";
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::GongMe.Properties.Resources.close;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInHD.BorderRadius = 10;
            this.btnInHD.BorderThickness = 1;
            this.btnInHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInHD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInHD.FillColor = System.Drawing.Color.White;
            this.btnInHD.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.btnInHD, "btnInHD");
            this.btnInHD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInHD.Name = "btnInHD";
            // 
            // FrmThanhToan
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbTienThua);
            this.Controls.Add(this.txtTienThua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTienKhachTra);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmThanhToan";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnThanhToan;
        private Guna.UI2.WinForms.Guna2TextBox txtTienKhachTra;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTienThua;
        private System.Windows.Forms.Label lbTienThua;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private System.Windows.Forms.Label lbThanhTien;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlTop;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2GradientButton btnInHD;
    }
}