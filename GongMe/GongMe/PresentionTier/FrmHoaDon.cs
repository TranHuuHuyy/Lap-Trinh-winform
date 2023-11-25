using GongMe.BusinessTier;
using GongMe.DataTier.Models;
using GongMe.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = GongMe.DataTier.Models.Menu;

namespace GongMe
{
    public partial class FrmHoaDon : Form
    {
        TiemTraSuaModel context = new TiemTraSuaModel();
        private readonly HoaDonBUS hoaDonBUS;
        private DanhMucBUS danhMucBUS;
        private CTHDBUS cTHDBUS;
        private MenuBUS menuBUS;
        private int maHoaDon = -1;
        private long? tongTien = 0;
        private long? tongdoanhthu = 0;

        string MACHUCVU = "";

        System.Globalization.CultureInfo fVND = new System.Globalization.CultureInfo("vi-VN");

        public FrmHoaDon(string MACHUCVU)
        {
            InitializeComponent();
            hoaDonBUS = new HoaDonBUS();
            danhMucBUS = new DanhMucBUS();
            menuBUS = new MenuBUS();
            cTHDBUS = new CTHDBUS();
            CaiDatDieuKhien();
            this.Load += FrmHoaDon_Load;

            this.MACHUCVU = MACHUCVU;
        }

        /*public FrmHoaDon(string MACHUCVU)
        {
            InitializeComponent();
            this.MACHUCVU = MACHUCVU;
        }*/

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadBan();
            LoadHoaDon();
            LoadDanhMuc();
            LoadDoanhThu();
            /*List<HOADON> hoaDon = context.HOADONs.ToList();
            tongdoanhthu = hoaDon.Sum(p => p.TONGTIEN).Value;
            txtTongTien.Text = tongdoanhthu.ToString();*/
            nupSoluong.Value = 1;
        }

        private void LoadBan()
        {
            cbxTenban.DataSource = context.Ban.ToList();
        }
        private void LoadNhanVien()
        {
            cbxNhanvien.DataSource = context.NhanVien.ToList();
        }
        private void LoadDanhMuc()
        {
            cbxDanhMuc.DataSource = danhMucBUS.GetDANHMUCs();
        }
        private void LoadHoaDon()
        {
            dgvHoaDon.DataSource = hoaDonBUS.GetHoaDons();
        }
        private void LoadDoanhThu()
        {
            //tongdoanhthu = context.HoaDon.ToList().Sum(p => p.TongTien).Value;
            txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
        }
        private void LoadCTHD(int maHoaDon)
        {
            dgvCTHD.DataSource = cTHDBUS.GetCTHDs(maHoaDon);
        }
        private void LoaddgvCTHD()
        {
            dgvCTHD.DataSource = null;
            maHoaDon = -1;
        }

        private void LoaddgvHD()
        {
            dgvHoaDon.DataSource = null;
        }

        private void CaiDatDieuKhien()
        {
            cbxTenban.DisplayMember = "TENBAN";
            cbxTenban.ValueMember = "MABAN";

            cbxNhanvien.DisplayMember = "HOTEN";
            cbxNhanvien.ValueMember = "MANHANVIEN";

            cbxDanhMuc.DisplayMember = "TENDANHMUC";
            cbxDanhMuc.ValueMember = "MADANHMUC";

            dtpNgayban.Format = DateTimePickerFormat.Custom;
            dtpNgayban.CustomFormat = "dd-MM-yyyy";
            dtpNgayban.MaxDate = DateTime.Now;
            dtpNgayban.Value = DateTime.Today;

            cbxTenMon.DisplayMember = "TENMON";
            cbxTenMon.ValueMember = "MAMON";
        }

        private void TaoHoaDonMoi(HoaDon hd)
        {
            Ban ban = cbxTenban.SelectedItem as Ban;
            hd.MaBan = ban.MaBan;
            hd.NgayXuat = DateTime.Parse(dtpNgayban.Value.ToString());
            NhanVien nhanVien = cbxNhanvien.SelectedItem as NhanVien;
            hd.MaNhanVien = nhanVien.MaNhanVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (maHoaDon == -1)
                {
                    HoaDon hd = new HoaDon();
                    TaoHoaDonMoi(hd);
                    hd.TongTien = 0;
                    hd.TrangThai = "Đã thanh toán";
                    hoaDonBUS.LuuHoaDon(hd);
                    LoadHoaDon();
                    return;
                }
                else
                {
                    HoaDon hd2 = hoaDonBUS.GetHoaDonTheoMa(maHoaDon);
                    hd2.TrangThai = "Đã thanh toán";
                    tongdoanhthu += hd2.TongTien;
                    txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                    hoaDonBUS.SuaHoaDon(hd2);
                    MessageBox.Show("Cập nhật trạng thái thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHoaDon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maHoaDon == -1)
            {
                MessageBox.Show("Chưa chọn hóa đơn sao sửa má!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HoaDon hd = new HoaDon();
            TaoHoaDonMoi(hd);
            hd.MaHoaDon = maHoaDon;
            try
            {
                hoaDonBUS.SuaHoaDon(hd);
                MessageBox.Show("Sửa hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon();
                LoaddgvCTHD();
                btnThem.Enabled = true;
                btnThemCT.Enabled = true;
                cbxDanhMuc.Enabled = true;
                cbxTenMon.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            string maDanhMuc = cbx.SelectedValue.ToString();
            cbxTenMon.DataSource = menuBUS.GetMonTheoMaDanhMuc(maDanhMuc);
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rows = e.RowIndex;
                maHoaDon = Convert.ToInt32(dgvHoaDon.Rows[rows].Cells[0].Value.ToString());
                cbxNhanvien.SelectedValue = Convert.ToInt32(dgvHoaDon.Rows[rows].Cells[1].Value.ToString());
                NhanVien nhanVien = cbxNhanvien.SelectedItem as NhanVien;
                cbxNhanvien.Text = nhanVien.HoTen;
                cbxTenban.SelectedValue = dgvHoaDon.Rows[rows].Cells[2].Value;
                Ban ban = cbxTenban.SelectedItem as Ban;
                cbxTenban.Text = ban.TenBan;
                dtpNgayban.Text = dgvHoaDon.Rows[rows].Cells[3].Value.ToString();

                LoadCTHD(maHoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maHoaDon == -1)
            {
                MessageBox.Show("Chưa chọn hóa đơn sao xóa được má!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HoaDon hd = new HoaDon();
            TaoHoaDonMoi(hd);
            hd.MaHoaDon = maHoaDon;
            HoaDon hoaDon = hoaDonBUS.GetHoaDonTheoMa(maHoaDon);
            tongdoanhthu -= hoaDon.TongTien;
            txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
            foreach (var item in hoaDonBUS.GetHoaDonTheoMa(maHoaDon).CTHD)
            {
                hd.CTHD.Remove(item);
            }
            try
            {
                hoaDonBUS.XoaHoaDon(hd);
                LoadHoaDon();
                LoaddgvCTHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (maHoaDon == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn thêm chi tiết!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nupSoluong.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // lưu cthd cần thêm
            CTHD cTHD = new CTHD();
            cTHD.MaHoaDon = maHoaDon;
            Menu meNu = cbxTenMon.SelectedItem as Menu;
            cTHD.MaMon = meNu.MaMon;
            cTHD.SoLuong = int.Parse(nupSoluong.Value.ToString());
            // lấy ra cthd đầu tiên của hóa đơn
            CTHD chitiet = cTHDBUS.getCTHDTheoMa(maHoaDon);
            List<CTHD> listCTHD = cTHDBUS.getListCTHDTheoMa(maHoaDon);
            try
            {
                HoaDon hd = hoaDonBUS.GetHoaDonTheoMa(maHoaDon);
                if (hd.TrangThai == "Đã thanh toán")
                {
                    tongTien = hd.TongTien + meNu.DonGia * cTHD.SoLuong;
                    tongdoanhthu = tongdoanhthu + tongTien - hd.TongTien;
                    txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                    hd.TongTien = tongTien;
                    tongTien = 0;
                }
                else
                {
                    tongTien = hd.TongTien + meNu.DonGia * cTHD.SoLuong;
                    txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                    hd.TongTien = tongTien;
                    tongTien = 0;
                }
                hoaDonBUS.SuaHoaDon(hd);
                cTHDBUS.CapNhatMon(cTHD);
                LoadHoaDon();
                LoadCTHD(maHoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rows = e.RowIndex;
                maHoaDon = Convert.ToInt32(dgvCTHD.Rows[rows].Cells[0].Value.ToString());
                string maMon = dgvCTHD.Rows[rows].Cells[1].Value.ToString();
                string maDanhMuc = menuBUS.GetMaDanhMucTheoMaMon(maMon);
                cbxDanhMuc.SelectedValue = maDanhMuc;
                cbxTenMon.SelectedValue = maMon;
                nupSoluong.Value = int.Parse(dgvCTHD.Rows[rows].Cells[2].Value.ToString());
                btnXoaCT.Enabled = true;
                btnSua_CT.Enabled = true;
                btnThemCT.Enabled = false;
                cbxDanhMuc.Enabled = false;
                cbxTenMon.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            CTHD cTHD = new CTHD();
            cTHD.MaHoaDon = maHoaDon;
            Menu meNu = cbxTenMon.SelectedItem as Menu;
            cTHD.MaMon = meNu.MaMon;
            cTHD.SoLuong = int.Parse(nupSoluong.Value.ToString());
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết hóa đơn này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cTHDBUS.XoaCTHD(cTHD);
                    HoaDon hd = hoaDonBUS.GetHoaDonTheoMa(maHoaDon);
                    if (hd.TrangThai == "Đã thanh toán")
                    {
                        tongTien = meNu.DonGia * cTHD.SoLuong;
                        hd.TongTien = hd.TongTien - tongTien;
                        tongdoanhthu += tongTien;
                        txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                        tongTien = 0;
                    }
                    else
                    {
                        tongTien = meNu.DonGia * cTHD.SoLuong;
                        hd.TongTien = hd.TongTien - tongTien;
                        txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                        tongTien = 0;
                    }
                    LoadCTHD(maHoaDon);
                    hoaDonBUS.SuaHoaDon(hd);
                    LoadHoaDon();
                    cbxDanhMuc.Enabled = true;
                    cbxTenMon.Enabled = true;
                    btnThemCT.Enabled = true;
                    btnSua_CT.Enabled = true;
                    btnXoaCT.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_CT_Click(object sender, EventArgs e)
        {
            CTHD cTHD = new CTHD();
            cTHD.MaHoaDon = maHoaDon;
            Menu meNu = cbxTenMon.SelectedItem as Menu;
            cTHD.MaMon = meNu.MaMon;
            cTHD.SoLuong = int.Parse(nupSoluong.Value.ToString());
            CTHD chitiet = cTHDBUS.getCTHDTheoMa(maHoaDon);
            List<CTHD> listCTHD = cTHDBUS.getListCTHDTheoMa(maHoaDon);
            try
            {
                for (int i = 0; i < listCTHD.Count; i++)
                {
                    if (listCTHD[i].MaMon == cTHD.MaMon)
                    {
                        chitiet = listCTHD[i];
                        HoaDon hd = hoaDonBUS.GetHoaDonTheoMa(maHoaDon);
                        if (hd.TrangThai == "Đã thanh toán")
                        {
                            tongTien = meNu.DonGia * cTHD.SoLuong - meNu.DonGia * chitiet.SoLuong;
                            hd.TongTien += tongTien;
                            tongdoanhthu += tongTien;
                            txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                            tongTien = 0;
                        }
                        else
                        {
                            tongTien = meNu.DonGia * cTHD.SoLuong - meNu.DonGia * chitiet.SoLuong;
                            hd.TongTien += tongTien;
                            txtTongTien.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                            tongTien = 0;
                        }
                        hoaDonBUS.SuaHoaDon(hd);
                        cTHDBUS.SuaCTHD(cTHD);
                        LoadHoaDon();
                        LoadCTHD(maHoaDon);
                        cbxDanhMuc.Enabled = true;
                        cbxTenMon.Enabled = true;
                        btnThemCT.Enabled = true;
                        btnSua_CT.Enabled = false;
                        btnXoaCT.Enabled = false;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (txtTimHoaDon.Text == "")
            {
                LoadHoaDon();
                LoaddgvCTHD();
                txtKetQua.Text = "";
            }
            else
            {
                try
                {
                    int timhd = int.Parse(txtTimHoaDon.Text.ToString());
                    foreach (var hd in hoaDonBUS.GetHoaDons())
                    {
                        if (hd.MaHD == timhd)
                        {
                            dgvHoaDon.DataSource = hoaDonBUS.GetHoaDonMaHD(hd.MaHD);
                            txtKetQua.Text = "Hóa đơn " + hd.MaHD;
                            LoadCTHD(hd.MaHD);
                            return;
                        }
                    }
                    foreach (var hd in hoaDonBUS.GetHoaDons())
                    {
                        if (hd.MaNV == timhd)
                        {
                            dgvHoaDon.DataSource = hoaDonBUS.GetHoaDonMaNV(int.Parse(timhd.ToString()));
                            NhanVien nv = context.NhanVien.Where(p => p.MaNhanVien == hd.MaNV).FirstOrDefault();
                            txtKetQua.Text = nv.HoTen;
                            LoadCTHD(hd.MaHD);
                            return;
                        }
                    }
                    txtKetQua.Text = "Không tìm thấy kết quả";
                    LoaddgvHD();
                    LoaddgvCTHD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLuuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                List<HoaDon> hoaDonChuaThanhToan = hoaDonBUS.GetHoaDonChuaThanhToan().ToList();
                for (int i = 0; i < hoaDonChuaThanhToan.Count; i++)
                {
                    if (hoaDonChuaThanhToan[i].MaBan == cbxTenban.SelectedValue.ToString())
                    {
                        MessageBox.Show("Bàn đang có khách!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                HoaDon hd = new HoaDon();
                TaoHoaDonMoi(hd);
                hd.TrangThai = "Chưa thanh toán";
                hd.TongTien = tongTien;
                hoaDonBUS.LuuHoaDon(hd);
                LoadHoaDon();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoaddgvCTHD();
            maHoaDon = -1;
            btnSua_CT.Enabled = false;
            btnXoaCT.Enabled = false;
            cbxDanhMuc.Enabled = true;
            cbxTenMon.Enabled = true;
            btnThemCT.Enabled = true;
        }

        private void txtTimHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

