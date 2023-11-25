using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GongMe.PresentionTier;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GongMe.PresentionTier
{
    public partial class UCListMenu : UserControl
    {
        public UCListMenu()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DANGKHOABACH;Initial Catalog=QLTiemTraSua;Integrated Security=True");

        //Tên món
        [Category("Custom Props")]
        private string _tenmon;

        public string TenMon
        {
            get
            {
                return _tenmon;
            }
            set
            {
                _tenmon = value;
                
                lbTenMon.Text = value;
            }
        }

        //Danh mục
        [Category("Custom Props")]
        private string _danhmuc;

        public string DanhMuc
        {
            get
            {
                return _danhmuc;
            }
            set
            {
                _danhmuc = value;

                lbHTDanhMuc.Text = value;
            }
        }

        //Mã món
        [Category("Custom Props")]
        private string _mamon;

        public string MaMon
        {
            get
            {
                return _mamon;
            }
            set
            {
                _mamon = value;

                lbHTMaMon.Text = value;
            }
        }

        //Đơn giá
        [Category("Custom Props")]
        private string _dongia;

        public string DonGia
        {
            get
            {
                return _dongia;
            }
            set
            {
                _dongia = value;

                txtDonGia.Text = value;
            }
        }

        //Mô tả
        [Category("Custom Props")]
        private string _mota;

        public string MoTa
        {
            get
            {
                return _mota;
            }
            set
            {
                _mota = value;

                txtMoTa.Text = value;
            }
        }

        private void UCListMenu_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
            txtDonGia.FillColor = Color.Gainsboro;
            txtMoTa.FillColor = Color.Gainsboro;
            txtDonGia.BorderColor = Color.Gainsboro;
            txtMoTa.BorderColor = Color.Gainsboro;
        }

        private void UCListMenu_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            txtDonGia.FillColor = Color.White;
            txtMoTa.FillColor = Color.White;
            txtDonGia.BorderColor = Color.White;
            txtMoTa.BorderColor = Color.White;
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin giá món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi giá món này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Menu] SET [DonGia] = '" + txtDonGia.Text.Trim() + "' WHERE RTRIM([MaMon]) = '" + lbHTMaMon.Text.Trim() + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thay đổi giá món thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại danh sách món
                }
                else
                {
                    //Load lại danh sách món
                }
            }
        }

        private void txtMoTa_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi mô tả món này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Menu] SET [MoTa] = '" + txtMoTa.Text.Trim() + "' WHERE RTRIM([MaMon]) = '" + lbHTMaMon.Text.Trim() + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thay đổi mô tả món thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Load lại danh sách món
            }
            else
            {
                //Load lại danh sách món
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa món này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Menu WHERE RTRIM([MaMon]) = '" + lbHTMaMon.Text.Trim() + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa món thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Load lại danh sách món
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UCListMenu_Load(object sender, EventArgs e)
        {
            /*if (txtDonGia.TextLength > 0)
            {
                txtDonGia.Text = String.Format("{0:C0}", decimal.Parse(txtDonGia.Text));
            }*/
        }
    }
}