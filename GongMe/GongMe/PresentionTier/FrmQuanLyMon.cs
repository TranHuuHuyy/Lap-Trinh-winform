using GongMe.BusinessTier;
using GongMe.DataTier.Models;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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

namespace GongMe.PresentionTier
{
    public partial class FrmQuanLyMon : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DANGKHOABACH;Initial Catalog=QLTiemTraSua;Integrated Security=True");

        string soluongmon, soluongmon1;

        public FrmQuanLyMon()
        {
            InitializeComponent();
        }

        private void FrmQuanLyMon_Load(object sender, EventArgs e)
        {
            PopulateItems();

            String querry = "SELECT *FROM DanhMuc";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            //Fill combobox thêm món
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            cbxDanhMuc.DataSource = dtable;
            cbxDanhMuc.ValueMember = "MaDanhMuc";
            cbxDanhMuc.DisplayMember = "TenDanhMuc";
        }

        //Tự tạo danh sách món
        private void PopulateItems()
        {
            //Đếm số lượng món hiện có
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Menu", conn);
            var count = cmd.ExecuteScalar();
            soluongmon = count.ToString().Trim();
            conn.Close();

            //Tạo món trong bảng Danh sách món
            UCListMenu[] listMenus = new UCListMenu[Convert.ToInt32(soluongmon)];

            //Lấy menu từ database
            String querryMenu = "SELECT *FROM Menu";
            SqlDataAdapter sdaMenu = new SqlDataAdapter(querryMenu, conn);

            DataTable dtableMenu = new DataTable();
            sdaMenu.Fill(dtableMenu);

            for (int i = 0; i < listMenus.Length; i++)
            {
                listMenus[i] = new UCListMenu();

                //Thêm menu từ database vào user control
                listMenus[i].TenMon = dtableMenu.Rows[i][2].ToString().Trim();
                listMenus[i].DanhMuc = dtableMenu.Rows[i][1].ToString().Trim();
                listMenus[i].MaMon = dtableMenu.Rows[i][0].ToString().Trim();
                listMenus[i].DonGia = dtableMenu.Rows[i][4].ToString().Trim();
                listMenus[i].MoTa = dtableMenu.Rows[i][3].ToString().Trim();

                flpnlMenu.Controls.Add(listMenus[i]);
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            //Đếm số lượng món theo mã (Mã món tự động)
            conn.Open();
            SqlCommand cmdcount = new SqlCommand("SELECT COUNT(*) FROM Menu WHERE MaDanhMuc = '" + cbxDanhMuc.SelectedValue.ToString().Trim() + "'",conn);
            var count1 = cmdcount.ExecuteScalar();
            soluongmon1 = count1.ToString();
            conn.Close();

            //Thêm món
            if (txtDonGia.Text == "" || txtTenMon.Text == "" || txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Menu] ([MaDanhMuc], [TenMon], [DonGia], [MoTa], [MaMon]) VALUES('"+cbxDanhMuc.SelectedValue+"','"+txtTenMon.Text+"','"+txtDonGia.Text+"','"+txtMoTa.Text+"', '" + cbxDanhMuc.SelectedValue.ToString().Trim() + (Convert.ToInt32(soluongmon1)+1) + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm món mới thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Load lại danh sách món
                flpnlMenu.Controls.Clear();
                PopulateItems();
            }    
        }
    }
}