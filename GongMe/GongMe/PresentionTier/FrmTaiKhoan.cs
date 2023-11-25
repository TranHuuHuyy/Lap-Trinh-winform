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
using GongMe.DataTier.Models;
using GongMe.PresentionTier;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace GongMe.PresentionTier
{
    public partial class FrmTaiKhoan : Form
    {

        string CheckMail = Console.ReadLine();

        SqlConnection conn = new SqlConnection(@"Data Source=DANGKHOABACH;Initial Catalog=QLTiemTraSua;Integrated Security=True");

        string user = "";

        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        public FrmTaiKhoan(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnThayDoiTT_Click(object sender, EventArgs e)
        {
            //Ẩn các mục thay đổi thông tin tài khoản
            lbTTTK.Visible = false;
            lbHoTen.Visible = false;
            lbSDT.Visible = false;
            lbMail.Visible = false;
            lbPass.Visible = false;
            lbMaNV.Visible = false;
            lbGioiTinh.Visible = false;
            lbNamSinh.Visible = false;
            lbChucVu.Visible = false;

            txtHoTen.Visible = false;
            txtSDT.Visible = false;
            txtMail.Visible = false;
            txtPassword.Visible = false;
            txtMaNV.Visible = false;
            txtGioiTinh.Visible = false;
            txtNamSinh.Visible = false;
            txtChucVu.Visible = false;

            btnThayDoiTT.Visible = false;

            //Hiển thị các mục xác minh tài khoản
            lbXacMinh.Visible = true;
            lbUserID.Visible = true;
            lbPassXacMinh.Visible = true;

            txtUserID.Visible = true;
            txtXacMinhPass.Visible = true;

            btnXacMinh.Visible = true;
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            //Đóng các mục có thể thay đổi thông tin
            txtMail.Enabled = false;
            txtPassword.Enabled = false;
            txtSDT.Enabled = false;

            //Ẩn nút lưu thay đổi
            btnLuuThayDoi.Visible = false;

            //Hiển thị lại nút thay đổi thông tin
            btnThayDoiTT.Visible = true;

            if (txtPassword.Text == "" || txtMail.Text == "" || txtSDT.Text ==  "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[NHANVIEN] SET [MATKHAU] = '" + txtPassword.Text + "', [MAIL] = '" + txtMail.Text + "', [SDT] = '" + txtSDT.Text + "' WHERE SDT = '" + user + "' OR MAIL = '" + user + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thay đổi thông tin thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            String querry = "SELECT *FROM NHANVIEN WHERE SDT = '" + user + "' OR MAIL = '" + user + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            txtHoTen.Text = dtable.Rows[0][2].ToString().Trim();
            txtSDT.Text = dtable.Rows[0][3].ToString().Trim();
            txtMail.Text = dtable.Rows[0][7].ToString().Trim();
            txtPassword.Text = dtable.Rows[0][6].ToString().Trim();
            txtMaNV.Text = dtable.Rows[0][0].ToString().Trim();
            txtGioiTinh.Text = dtable.Rows[0][5].ToString().Trim();
            txtNamSinh.Text = dtable.Rows[0][4].ToString().Trim();
            txtUserID.Text = dtable.Rows[0][7].ToString().Trim();

            if (dtable.Rows[0][1].ToString().Trim() == "QL")
            {
                txtChucVu.Text = "Quản lý";
            }
            else
            {
                if (dtable.Rows[0][1].ToString().Trim() == "KT")
                {
                    txtChucVu.Text = "Kế toán";
                }
                else
                {
                    if (dtable.Rows[0][1].ToString().Trim() == "TN")
                    {
                        txtChucVu.Text = "Thu ngân";
                    }
                    else
                    {
                        if (dtable.Rows[0][1].ToString().Trim() == "PC")
                        {
                            txtChucVu.Text = "Pha chế";
                        }
                        else
                        {
                            txtChucVu.Text = "Nhân viên";
                        }
                    }
                }
            }         
        }

        private void FrmTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnXacMinh_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txtUserID.Text;
            password = txtXacMinhPass.Text;

            try
            {
                String querry = "SELECT *FROM NHANVIEN WHERE MAIL = '" + txtUserID.Text + "' AND MATKHAU = '" + txtXacMinhPass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUserID.Text;
                    password = txtXacMinhPass.Text;

                    //Hiển thị các mục thay đổi thông tin tài khoản
                    lbTTTK.Visible = true;
                    lbHoTen.Visible = true;
                    lbSDT.Visible = true;
                    lbMail.Visible = true;
                    lbPass.Visible = true;
                    lbMaNV.Visible = true;
                    lbGioiTinh.Visible = true;
                    lbNamSinh.Visible = true;
                    lbChucVu.Visible = true;

                    txtHoTen.Visible = true;
                    txtSDT.Visible = true;
                    txtMail.Visible = true;
                    txtPassword.Visible = true;
                    txtMaNV.Visible = true;
                    txtGioiTinh.Visible = true;
                    txtNamSinh.Visible = true;
                    txtChucVu.Visible = true;

                    btnLuuThayDoi.Visible = true;

                    //Ẩn các mục xác minh tài khoản
                    lbXacMinh.Visible = false;
                    lbUserID.Visible = false;
                    lbPassXacMinh.Visible = false;

                    txtUserID.Visible = false;
                    txtXacMinhPass.Visible = false;

                    btnXacMinh.Visible = false;

                    //Mở các mục có thể thay đổi thông tin
                    txtMail.Enabled = true;
                    txtPassword.Enabled = true;
                    txtSDT.Enabled = true;

                    //Xác minh thành công
                    MessageBox.Show("Xác minh thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtXacMinhPass.Clear();
                }
                else
                {
                    MessageBox.Show("Xác minh thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtXacMinhPass.Clear();
                    txtUserID.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSDT.MaxLength = 10;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}