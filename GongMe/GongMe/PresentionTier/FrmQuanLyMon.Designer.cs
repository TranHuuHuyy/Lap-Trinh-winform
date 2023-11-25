namespace GongMe.PresentionTier
{
    partial class FrmQuanLyMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyMon));
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lbThemMon = new System.Windows.Forms.Label();
            this.btnThemMon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbDanhMucCT = new System.Windows.Forms.Label();
            this.cbxDanhMuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlLine = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.flpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lbThemMon);
            this.pnlLeft.Controls.Add(this.btnThemMon);
            this.pnlLeft.Controls.Add(this.lbDanhMucCT);
            this.pnlLeft.Controls.Add(this.cbxDanhMuc);
            this.pnlLeft.Controls.Add(this.pnlLine);
            this.pnlLeft.Controls.Add(this.txtMoTa);
            this.pnlLeft.Controls.Add(this.txtDonGia);
            this.pnlLeft.Controls.Add(this.txtTenMon);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.lbTenMon);
            resources.ApplyResources(this.pnlLeft, "pnlLeft");
            this.pnlLeft.Name = "pnlLeft";
            // 
            // lbThemMon
            // 
            resources.ApplyResources(this.lbThemMon, "lbThemMon");
            this.lbThemMon.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbThemMon.Name = "lbThemMon";
            // 
            // btnThemMon
            // 
            this.btnThemMon.AutoRoundedCorners = true;
            this.btnThemMon.BackColor = System.Drawing.Color.Transparent;
            this.btnThemMon.BorderRadius = 20;
            this.btnThemMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMon.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThemMon.FillColor2 = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btnThemMon, "btnThemMon");
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // lbDanhMucCT
            // 
            resources.ApplyResources(this.lbDanhMucCT, "lbDanhMucCT");
            this.lbDanhMucCT.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbDanhMucCT.Name = "lbDanhMucCT";
            // 
            // cbxDanhMuc
            // 
            this.cbxDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.cbxDanhMuc.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cbxDanhMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDanhMuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbxDanhMuc, "cbxDanhMuc");
            this.cbxDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxDanhMuc.Name = "cbxDanhMuc";
            this.cbxDanhMuc.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.pnlLine, "pnlLine");
            this.pnlLine.Name = "pnlLine";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Animated = true;
            this.txtMoTa.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtMoTa, "txtMoTa");
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderText = "Mô tả";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Animated = true;
            this.txtDonGia.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtDonGia, "txtDonGia");
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.PlaceholderText = "Đơn giá";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Animated = true;
            this.txtTenMon.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMon.DefaultText = "";
            this.txtTenMon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtTenMon, "txtTenMon");
            this.txtTenMon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PasswordChar = '\0';
            this.txtTenMon.PlaceholderText = "Tên món";
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Name = "label1";
            // 
            // lbTenMon
            // 
            resources.ApplyResources(this.lbTenMon, "lbTenMon");
            this.lbTenMon.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTenMon.Name = "lbTenMon";
            // 
            // flpnlMenu
            // 
            resources.ApplyResources(this.flpnlMenu, "flpnlMenu");
            this.flpnlMenu.Name = "flpnlMenu";
            // 
            // FrmQuanLyMon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpnlMenu);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyMon";
            this.Load += new System.EventHandler(this.FrmQuanLyMon_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMon;
        private Guna.UI2.WinForms.Guna2Panel pnlLine;
        private System.Windows.Forms.Label lbDanhMucCT;
        private Guna.UI2.WinForms.Guna2ComboBox cbxDanhMuc;
        private System.Windows.Forms.FlowLayoutPanel flpnlMenu;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemMon;
        private System.Windows.Forms.Label lbThemMon;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private System.Windows.Forms.Label label2;
    }
}