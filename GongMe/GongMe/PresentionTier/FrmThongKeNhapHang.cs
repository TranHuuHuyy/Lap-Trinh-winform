using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GongMe.PresentionTier
{
    public partial class FrmThongKeNhapHang : Form
    {
        TraSua ts = new TraSua();
        System.Globalization.CultureInfo fVND = new System.Globalization.CultureInfo("vi-VN");
        long DoanhThu;

        public FrmThongKeNhapHang()
        {
            InitializeComponent();
        }

        void HienThiListDsTungayDenNgay()
        {
            string tuNgay = String.Format("{0:MM/dd/yyyy 00:00:00}", dtpTuNgay.Value);
            string denNgay = String.Format("{0:MM/dd/yyyy 23:59:59}", dtpDenNgay.Value);
            lvsNhapHang.Items.Clear();
            DataTable df = ts.LayDSNhapHangTuNgayDenNgay(tuNgay, denNgay);
            for (int i = 0; i < df.Rows.Count; i++)
            {
                ListViewItem lvi =
                lvsNhapHang.Items.Add(df.Rows[i][0].ToString());
                lvi.SubItems.Add(df.Rows[i][1].ToString());
                lvi.SubItems.Add(df.Rows[i][2].ToString());
                lvi.SubItems.Add(df.Rows[i][3].ToString());
                lvi.SubItems.Add(df.Rows[i][4].ToString());
            }
        }

        public long TongDoanhThuTungayDenNgay()
        {
            string tuNgay = String.Format("{0:MM/dd/yyyy 00:00:00}", dtpTuNgay.Value);
            string denNgay = String.Format("{0:MM/dd/yyyy 23:59:59}", dtpDenNgay.Value);
            DoanhThu = 0;
            long tongtien = 0;
            DataTable df = ts.LayDSNhapHangTuNgayDenNgay(tuNgay, denNgay);
            for (int i = 0; i < df.Rows.Count; i++)
            {
                tongtien = long.Parse(df.Rows[i][4].ToString());
                DoanhThu += tongtien;
            }
            return DoanhThu;
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;

            btnCheck_Click(sender, e);
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
                txtTongTien.Text = totalDoanhThu.ToString();
                txtTongTien.Text = String.Format(fVND, "{0:C0}", (totalDoanhThu));
            }
        }
    }
}
