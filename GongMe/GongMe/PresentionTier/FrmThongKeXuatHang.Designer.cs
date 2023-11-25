namespace GongMe.PresentionTier
{
    partial class FrmThongKeXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeXuatHang));
            this.lvsPhieuXuat = new System.Windows.Forms.ListView();
            this.colMaPhieuXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayXuatHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHomNay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnCheck = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvsPhieuXuat
            // 
            this.lvsPhieuXuat.BackColor = System.Drawing.Color.SkyBlue;
            this.lvsPhieuXuat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieuXuat,
            this.colTenNhanVien,
            this.colNgayXuatHang});
            resources.ApplyResources(this.lvsPhieuXuat, "lvsPhieuXuat");
            this.lvsPhieuXuat.ForeColor = System.Drawing.Color.Black;
            this.lvsPhieuXuat.HideSelection = false;
            this.lvsPhieuXuat.Name = "lvsPhieuXuat";
            this.lvsPhieuXuat.UseCompatibleStateImageBehavior = false;
            this.lvsPhieuXuat.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhieuXuat
            // 
            resources.ApplyResources(this.colMaPhieuXuat, "colMaPhieuXuat");
            // 
            // colTenNhanVien
            // 
            resources.ApplyResources(this.colTenNhanVien, "colTenNhanVien");
            // 
            // colNgayXuatHang
            // 
            resources.ApplyResources(this.colNgayXuatHang, "colNgayXuatHang");
            // 
            // btnHomNay
            // 
            this.btnHomNay.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHomNay.BorderRadius = 10;
            this.btnHomNay.BorderThickness = 1;
            this.btnHomNay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHomNay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHomNay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHomNay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHomNay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHomNay.FillColor = System.Drawing.Color.White;
            this.btnHomNay.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.btnHomNay, "btnHomNay");
            this.btnHomNay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Click += new System.EventHandler(this.btnHomNay_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lvsPhieuXuat);
            resources.ApplyResources(this.guna2GroupBox1, "guna2GroupBox1");
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            // 
            // btnCheck
            // 
            this.btnCheck.AutoRoundedCorners = true;
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.BorderRadius = 23;
            this.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheck.FillColor2 = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Animated = true;
            this.dtpDenNgay.BorderRadius = 10;
            this.dtpDenNgay.Checked = true;
            this.dtpDenNgay.FillColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.dtpDenNgay, "dtpDenNgay");
            this.dtpDenNgay.ForeColor = System.Drawing.Color.Black;
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Value = new System.DateTime(2022, 9, 30, 16, 2, 40, 366);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Animated = true;
            this.dtpTuNgay.BorderRadius = 10;
            this.dtpTuNgay.Checked = true;
            this.dtpTuNgay.FillColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.dtpTuNgay, "dtpTuNgay");
            this.dtpTuNgay.ForeColor = System.Drawing.Color.Black;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Value = new System.DateTime(2022, 9, 30, 16, 2, 40, 366);
            // 
            // lbDenNgay
            // 
            resources.ApplyResources(this.lbDenNgay, "lbDenNgay");
            this.lbDenNgay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbDenNgay.Name = "lbDenNgay";
            // 
            // lbTuNgay
            // 
            resources.ApplyResources(this.lbTuNgay, "lbTuNgay");
            this.lbTuNgay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTuNgay.Name = "lbTuNgay";
            // 
            // FrmThongKeXuatHang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnHomNay);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lbDenNgay);
            this.Controls.Add(this.lbTuNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmThongKeXuatHang";
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvsPhieuXuat;
        private System.Windows.Forms.ColumnHeader colMaPhieuXuat;
        private System.Windows.Forms.ColumnHeader colTenNhanVien;
        private System.Windows.Forms.ColumnHeader colNgayXuatHang;
        private Guna.UI2.WinForms.Guna2GradientButton btnHomNay;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheck;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
    }
}