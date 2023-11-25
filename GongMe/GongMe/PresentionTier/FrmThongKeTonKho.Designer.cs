namespace GongMe.PresentionTier
{
    partial class FrmThongKeTonKho
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
            this.lvsDoanhThu = new System.Windows.Forms.ListView();
            this.colMaHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayNhapHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHanSuDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnCheck = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.btnHomNay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvsDoanhThu
            // 
            this.lvsDoanhThu.BackColor = System.Drawing.Color.SkyBlue;
            this.lvsDoanhThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHang,
            this.colTenHang,
            this.colSoLuong,
            this.colNgayNhapHang,
            this.colNgaySanXuat,
            this.colHanSuDung});
            this.lvsDoanhThu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lvsDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lvsDoanhThu.HideSelection = false;
            this.lvsDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.lvsDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.lvsDoanhThu.Name = "lvsDoanhThu";
            this.lvsDoanhThu.Size = new System.Drawing.Size(1090, 496);
            this.lvsDoanhThu.TabIndex = 1;
            this.lvsDoanhThu.UseCompatibleStateImageBehavior = false;
            this.lvsDoanhThu.View = System.Windows.Forms.View.Details;
            // 
            // colMaHang
            // 
            this.colMaHang.Text = "Mã hàng";
            this.colMaHang.Width = 190;
            // 
            // colTenHang
            // 
            this.colTenHang.Text = "Tên hàng";
            this.colTenHang.Width = 190;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 190;
            // 
            // colNgayNhapHang
            // 
            this.colNgayNhapHang.Text = "Ngày nhập hàng";
            this.colNgayNhapHang.Width = 190;
            // 
            // colNgaySanXuat
            // 
            this.colNgaySanXuat.Text = "Ngày sản xuất";
            this.colNgaySanXuat.Width = 190;
            // 
            // colHanSuDung
            // 
            this.colHanSuDung.Text = "Hạn sử dụng";
            this.colHanSuDung.Width = 190;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lvsDoanhThu);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 107);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1090, 496);
            this.guna2GroupBox1.TabIndex = 29;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
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
            this.btnCheck.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(952, 34);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(153, 49);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Kiểm tra";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Animated = true;
            this.dtpDenNgay.BorderRadius = 10;
            this.dtpDenNgay.Checked = true;
            this.dtpDenNgay.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.dtpDenNgay.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dtpDenNgay.ForeColor = System.Drawing.Color.Black;
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDenNgay.Location = new System.Drawing.Point(122, 57);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(227, 36);
            this.dtpDenNgay.TabIndex = 1;
            this.dtpDenNgay.Value = new System.DateTime(2022, 9, 30, 16, 2, 40, 366);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Animated = true;
            this.dtpTuNgay.BorderRadius = 10;
            this.dtpTuNgay.Checked = true;
            this.dtpTuNgay.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.dtpTuNgay.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dtpTuNgay.ForeColor = System.Drawing.Color.Black;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTuNgay.Location = new System.Drawing.Point(122, 14);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(227, 36);
            this.dtpTuNgay.TabIndex = 0;
            this.dtpTuNgay.Value = new System.DateTime(2022, 9, 30, 16, 2, 40, 366);
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDenNgay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbDenNgay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDenNgay.Location = new System.Drawing.Point(25, 65);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(82, 19);
            this.lbDenNgay.TabIndex = 22;
            this.lbDenNgay.Text = "Đến ngày";
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTuNgay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTuNgay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTuNgay.Location = new System.Drawing.Point(34, 23);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(73, 19);
            this.lbTuNgay.TabIndex = 23;
            this.lbTuNgay.Text = "Từ ngày";
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
            this.btnHomNay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHomNay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHomNay.Location = new System.Drawing.Point(375, 34);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(112, 40);
            this.btnHomNay.TabIndex = 3;
            this.btnHomNay.Text = "Hôm nay";
            // 
            // FrmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 615);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lbDenNgay);
            this.Controls.Add(this.lbTuNgay);
            this.Controls.Add(this.btnHomNay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmThongKeTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tồn kho";
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvsDoanhThu;
        private System.Windows.Forms.ColumnHeader colMaHang;
        private System.Windows.Forms.ColumnHeader colTenHang;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colNgayNhapHang;
        private System.Windows.Forms.ColumnHeader colNgaySanXuat;
        private System.Windows.Forms.ColumnHeader colHanSuDung;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheck;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private Guna.UI2.WinForms.Guna2GradientButton btnHomNay;
    }
}