namespace GongMe
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCheck = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lvsDoanhThu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHomNay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTuNgay
            // 
            resources.ApplyResources(this.lbTuNgay, "lbTuNgay");
            this.lbTuNgay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTuNgay.Name = "lbTuNgay";
            // 
            // lbDenNgay
            // 
            resources.ApplyResources(this.lbDenNgay, "lbDenNgay");
            this.lbDenNgay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbDenNgay.Name = "lbDenNgay";
            // 
            // lbTongDoanhThu
            // 
            resources.ApplyResources(this.lbTongDoanhThu, "lbTongDoanhThu");
            this.lbTongDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.lbTongDoanhThu.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Animated = true;
            this.txtTongDoanhThu.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTongDoanhThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongDoanhThu.DefaultText = "";
            this.txtTongDoanhThu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongDoanhThu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.txtTongDoanhThu, "txtTongDoanhThu");
            this.txtTongDoanhThu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongDoanhThu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.PasswordChar = '\0';
            this.txtTongDoanhThu.PlaceholderText = "0";
            this.txtTongDoanhThu.SelectedText = "";
            this.txtTongDoanhThu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
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
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lvsDoanhThu);
            resources.ApplyResources(this.guna2GroupBox1, "guna2GroupBox1");
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            // 
            // lvsDoanhThu
            // 
            this.lvsDoanhThu.BackColor = System.Drawing.Color.SkyBlue;
            this.lvsDoanhThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            resources.ApplyResources(this.lvsDoanhThu, "lvsDoanhThu");
            this.lvsDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lvsDoanhThu.HideSelection = false;
            this.lvsDoanhThu.Name = "lvsDoanhThu";
            this.lvsDoanhThu.UseCompatibleStateImageBehavior = false;
            this.lvsDoanhThu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
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
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // FrmThongKe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnHomNay);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.lbDenNgay);
            this.Controls.Add(this.lbTuNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private Guna.UI2.WinForms.Guna2TextBox txtTongDoanhThu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheck;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ListView lvsDoanhThu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Guna.UI2.WinForms.Guna2GradientButton btnHomNay;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}