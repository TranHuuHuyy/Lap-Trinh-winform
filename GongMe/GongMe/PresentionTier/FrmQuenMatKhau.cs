using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Security.Cryptography.Xml;

namespace GongMe.PresentionTier
{
    public partial class FrmQuenMatKhau : Form
    {
        string randomCode;
        public static string to;

        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DANGKHOABACH;Initial Catalog=QLTiemTraSua;Integrated Security=True");


        private void FrmQuenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
                FrmDangNhap f = new FrmDangNhap();
                f.Show();
                this.Hide();
        }

        //Lấy code qua email
        private void btnLayMa_Click(object sender, EventArgs e)
        {
            try
            {
                String querry = "SELECT *FROM NHANVIEN WHERE MAIL = '" + txtEmail.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(000000, 999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (txtEmail.Text).ToString();
                    from = "gongme.hutech@gmail.com";
                    pass = "tjfxnmghsuumfnjj";
                    messageBody = "Mã xác nhận của bạn là " + randomCode + ".";
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Mã xác nhận đặt lại mật khẩu trà sữa Gong Me";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Mã xác nhận của bạn đã được gửi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Địa chỉ Email không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
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

        //Xác nhận code
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtMaXacNhan.Text).ToString())
            {
                to = txtEmail.Text;
                MessageBox.Show("Mã xác nhận chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMatKhauMoi.Enabled = true;
                txtNhapLaiMatKhau.Enabled = true;
                btnDoiMatKhau.Enabled = true;
                ckbShowPass.Enabled = true;
            }    
            else
            {
                MessageBox.Show("Nhập sai mã xác nhận!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaXacNhan.Clear();
            }    
        }

        //Đặt lại mật khẩu
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
            {
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[NHANVIEN] SET [MATKHAU] = '"+txtNhapLaiMatKhau.Text+"' WHERE MAIL = '"+txtEmail.Text+"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đặt lại mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmDangNhap f = new FrmDangNhap();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        //Ẩn hiện mật khẩu
        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked == true)
            {
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtMatKhauMoi.PasswordChar = '\0';

                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtMatKhauMoi.PasswordChar = '●';

                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.PasswordChar = '●';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
