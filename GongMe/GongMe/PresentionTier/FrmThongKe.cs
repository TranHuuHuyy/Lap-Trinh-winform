using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GongMe
{
    public partial class FrmThongKe : Form
    {
        TraSua ts = new TraSua();
        long tongDoanhThu;
        System.Globalization.CultureInfo fVND = new System.Globalization.CultureInfo("vi-VN");

        public FrmThongKe()
        {
            InitializeComponent();
        }

        void HienThiListDsTungayDenNgay()
        {
            string tuNgay = String.Format("{0:MM/dd/yyyy 00:00:00}", dtpTuNgay.Value);
            string denNgay = String.Format("{0:MM/dd/yyyy 23:59:59}", dtpDenNgay.Value);
            lvsDoanhThu.Items.Clear();
            DataTable dt = ts.LayDSHoaDonChoDoanhThuTuNgayDenNgay(tuNgay, denNgay);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvsDoanhThu.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }
        }

        public long TongDoanhThuTungayDenNgay()
        {
            string tuNgay = String.Format("{0:MM/dd/yyyy 00:00:00}", dtpTuNgay.Value);
            string denNgay = String.Format("{0:MM/dd/yyyy 23:59:59}", dtpDenNgay.Value);
            tongDoanhThu = 0;
            long tongtien = 0;
            DataTable dt = ts.LayDSHoaDonChoDoanhThuTuNgayDenNgay(tuNgay, denNgay);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongtien = long.Parse(dt.Rows[i][4].ToString());
                tongDoanhThu += tongtien;
            }
            return tongDoanhThu;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Vui lòng chọn ngày hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {    
                HienThiListDsTungayDenNgay();
                long totalDoanhThu = TongDoanhThuTungayDenNgay();
                //txtTongDoanhThu.Text = totalDoanhThu.ToString();
                txtTongDoanhThu.Text = String.Format(fVND, "{0:C0}", (totalDoanhThu));
            }
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;

            btnCheck_Click(sender, e);
        }
    }
}
