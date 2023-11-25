using GongMe.BusinessTier;
using GongMe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GongMe
{
    public partial class FrmNhanVien : Form
    {
        TiemTraSuaModel context = new TiemTraSuaModel();
        private int maNhanVien = -1;
        private NhanVienBUS nhanVienBUS;
        private ChucVuBUS chucVuBUS;

        public FrmNhanVien()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            chucVuBUS = new ChucVuBUS();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            LoadNhanVien();
            CaiDatDieuKhien();
            cbxGioiTinh.SelectedIndex = 0;
        }

        private void LoadChucVu()
        {
            cbxChucvu.DataSource = chucVuBUS.GetCHUCVUs();
        }
        private void LoadNhanVien()
        {
            dgvQLnhanvien.DataSource = nhanVienBUS.GetNhanViens();
        }

        private void CaiDatDieuKhien()
        {
            cbxChucvu.DisplayMember = "TENCHUCVU";
            cbxChucvu.ValueMember = "MACHUCVU";
        }
        private void LoadForm()
        {
            txtMail.Clear();
            txtHoten.Clear();
            txtSdt.Clear();
            txtNamsinh.Clear();
            txtPassword.Clear();
        }
        private bool KiemTraNhapNV()
        {
            if (txtHoten.Text == "" || txtSdt.Text == "" || txtPassword.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            int length = txtSdt.Text.Length;
            if (length < 10 || length > 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 kí tự!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapNV())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.HoTen = txtHoten.Text;
                ChucVu cv = cbxChucvu.SelectedItem as ChucVu;
                nhanVien.MaChucVu = cv.MaChucVu;
                nhanVien.Sdt = txtSdt.Text;
                nhanVien.MatKhau = txtPassword.Text;
                nhanVien.Mail = txtMail.Text;
                nhanVien.NamSinh = Convert.ToInt32(txtNamsinh.Text.ToString());
                nhanVien.GioiTinh = cbxGioiTinh.Text.ToString();

                try
                {
                   // nhanVienBUS.(nhanVien);
                    LoadNhanVien();
                    LoadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapNV())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNhanVien = maNhanVien;
                nhanVien.HoTen = txtHoten.Text;
                ChucVu cv = cbxChucvu.SelectedItem as ChucVu;
                nhanVien.MaChucVu = cv.MaChucVu;
                nhanVien.Sdt = txtSdt.Text;
                nhanVien.MatKhau = txtPassword.Text;
                nhanVien.Mail = txtMail.Text;
                nhanVien.NamSinh = Convert.ToInt32(txtNamsinh.Text.ToString());
                nhanVien.GioiTinh = cbxGioiTinh.Text.ToString();

                try
                {
                    //nhanVienBUS.SuaNhanVien(nhanVien);
                    LoadNhanVien();
                    LoadForm();
                    btnThem.Enabled = true;
                    MessageBox.Show("Chỉnh sửa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvQLnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rows = e.RowIndex;
                maNhanVien = Convert.ToInt32(dgvQLnhanvien.Rows[rows].Cells[0].Value.ToString());
                txtHoten.Text = dgvQLnhanvien.Rows[rows].Cells[1].Value.ToString().Trim();
                cbxChucvu.SelectedValue = dgvQLnhanvien.Rows[rows].Cells[2].Value;
                ChucVu chucVu = cbxChucvu.SelectedItem as ChucVu;
                cbxChucvu.Text = chucVu.TenChucVu;
                txtNamsinh.Text = dgvQLnhanvien.Rows[rows].Cells[3].Value.ToString().Trim();
                cbxGioiTinh.Text = dgvQLnhanvien.Rows[rows].Cells[4].Value.ToString();
                txtSdt.Text = dgvQLnhanvien.Rows[rows].Cells[5].Value.ToString().Trim();
                txtPassword.Text = dgvQLnhanvien.Rows[rows].Cells[6].Value.ToString().Trim();
                txtMail.Text = dgvQLnhanvien.Rows[rows].Cells[7].Value.ToString().Trim();
                btnThem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNhanVien = maNhanVien;
            nhanVien.HoTen = txtHoten.Text;
            ChucVu cv = cbxChucvu.SelectedItem as ChucVu;
            nhanVien.MaChucVu = cv.MaChucVu;
            nhanVien.Sdt = txtSdt.Text;
            nhanVien.MatKhau = txtPassword.Text;
            nhanVien.Mail = txtMail.Text;
            nhanVien.NamSinh = Convert.ToInt32(txtNamsinh.Text.ToString());
            nhanVien.GioiTinh = cbxGioiTinh.Text.ToString();

            try
            {
                //nhanVienBUS.XoaNhanVien(nhanVien);
                LoadNhanVien();
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (txtTimNhanVien.Text == "")
            {
                LoadNhanVien();
            }
            else
            {
                try
                {
                    string sdt = txtTimNhanVien.Text;
                    foreach (var item in nhanVienBUS.GetNhanViens())
                    {
                        if (item.Sdt == sdt)
                        {
                            //dgvQLnhanvien.DataSource = nhanVienBUS.GetNhanVienSDT(item.SDT);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSdt.MaxLength = 10;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamsinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNamsinh.MaxLength = 4;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}