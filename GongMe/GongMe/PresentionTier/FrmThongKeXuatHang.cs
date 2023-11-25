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
    public partial class FrmThongKeXuatHang : Form
    {
        TraSua ts = new TraSua();

        public FrmThongKeXuatHang()
        {
            InitializeComponent();
        }

        void HienThiListDsTungayDenNgay()
        {
            string tuNgay = String.Format("{0:MM/dd/yyyy 00:00:00}", dtpTuNgay.Value);
            string denNgay = String.Format("{0:MM/dd/yyyy 23:59:59}", dtpDenNgay.Value);
            lvsPhieuXuat.Items.Clear();
            DataTable dh = ts.LayDsXuatHangTuNgayDenNgay(tuNgay, denNgay);
            for (int i = 0; i < dh.Rows.Count; i++)
            {
                ListViewItem lvi =
                lvsPhieuXuat.Items.Add(dh.Rows[i][0].ToString());
                lvi.SubItems.Add(dh.Rows[i][1].ToString());
                lvi.SubItems.Add(dh.Rows[i][2].ToString());

            }
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
            }
        }
    }
}
