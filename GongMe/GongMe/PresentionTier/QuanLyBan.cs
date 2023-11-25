using GongMe.BusinessTier;
using GongMe.DataTier.Models;
using GongMe.PresentionTier;
using GongMe.ViewModel;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Menu = GongMe.DataTier.Models.Menu;

namespace GongMe
{
    public partial class FrmQuanLyBan : Form
    {
        int MaNhanVienHoatDong = -1;
        private const int W = 75;
        private const int H = 75;
        private const int dis = 85;
        private FrmTraSuaGongMe frmTraSuaGongMe;
        private const int col = 5;
        private BanTraSuaBUS banTraSuaBUS;
        private DanhMucBUS danhMucBUS;
        private MenuBUS menuBUS;
        private CTHDBUS chitietBUS;
        private HoaDonBUS hoaDonBUS;
        private Button banChon = null;
        private int maHD = -1;
        private long? tongTien = 0;
        System.Globalization.CultureInfo fVND = new System.Globalization.CultureInfo("vi-VN");
        List<HoaDon> listHoaDonTrangThai;

        public FrmQuanLyBan(string maNhanVienHoatDong)
        {
            InitializeComponent();
            CaidatDieuKhien();
            frmTraSuaGongMe = new FrmTraSuaGongMe();
            banTraSuaBUS = new BanTraSuaBUS();
            danhMucBUS = new DanhMucBUS();
            menuBUS = new MenuBUS();
            hoaDonBUS = new HoaDonBUS();
            chitietBUS = new CTHDBUS();
            listHoaDonTrangThai = hoaDonBUS.GetHoaDonChuaThanhToan();
            this.MaNhanVienHoatDong = int.Parse(maNhanVienHoatDong);
        }
        private void CaidatDieuKhien()
        {
            cbxDanhMuc.DisplayMember = "TenDanhMuc";
            cbxDanhMuc.ValueMember = "MaDanhMuc";
            
            cbxDoiBan.DisplayMember = "TenBan";
            cbxDoiBan.ValueMember = "MaBan";

            cbxMon.DisplayMember = "TenMon";
            cbxMon.ValueMember = "MaMon";
        }

        private void LoadDanhSachMon(int maHoaDon)
        {
            if (maHoaDon == -1)
            {
                dgvDanhSachMon.DataSource = null;
                return;
            }
            dgvDanhSachMon.DataSource = chitietBUS.GetCTHDMaBan(maHoaDon);
        }

        private void FrmQuanLyBan_Load(object sender, EventArgs e)
        {
            KhoiTaoSoLuongBan();
            LoadDanhSachBan();
            LoadDanhMuc();
            nudSoLuong.Value = 1;
        }
        private void KhoiTaoSoLuongBan()
        {
            int x = 20;
            int y = 30;
            int i = 0;
            foreach (Ban ban in banTraSuaBUS.GetBANs())
            {
                TaoBan(x, y, ban);
                i++;
                if (i % col == 0)
                {
                    y += dis;
                    x = 20;
                    continue;
                }
                x += dis;
            }
        }
        private void TaoBan(int x, int y, Ban ban)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Text = ban.TenBan;
            btn.Tag = ban.MaBan;
            btn.Size = new Size(W, H);
            btn.BackColor = Color.White;
            btn.Click += Btn_Click;
            btn.Font = new Font("Arial", 10);
            btn.ForeColor = Color.Black;
            foreach (var item in hoaDonBUS.GetHoaDonTrangThai())
            {
                if (item.MaBan == ban.MaBan)
                {
                    btn.Image = Image.FromFile("../../Resources/lytrasua.png");
                }
            }
            pnlBan.Controls.Add(btn);
        }

        private void LoadDanhMuc()
        {
            cbxDanhMuc.DataSource = danhMucBUS.GetDANHMUCs();
        }

        private void LoadDanhSachBan()
        {
            cbxDoiBan.DataSource = banTraSuaBUS.GetBANs();
        }

        private void cbxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            string maDanhMuc = cbx.SelectedValue.ToString();
            cbxMon.DataSource = menuBUS.GetMonTheoMaDanhMuc(maDanhMuc);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button ban = sender as Button;
            if (banChon == null)
            {
                banChon = ban;
                banChon.BackColor = Color.DeepSkyBlue;
            }
            else if (banChon == ban)
            {
                banChon.BackColor = Color.White;
                banChon = null;
                maHD = -1;
                LoadDanhSachMon(maHD);
                tongTien = 0;
                txtTongTien.Text = "";
                return;
            }
            else
            {
                banChon.BackColor = Color.White;
                banChon = ban;
                ban.BackColor = Color.DeepSkyBlue;
            }
            string maSoBanChon = banChon.Tag.ToString();
            foreach (var item in hoaDonBUS.GetHoaDonTrangThai())
            {
                if (item.MaBan == maSoBanChon)
                {
                    maHD = item.MaHD;
                    LoadDanhSachMon(maHD);
                    tongTien = item.TongTien;
                    txtTongTien.Text = String.Format(fVND, "{0:C0}", tongTien);
                    return;
                }
            }
            maHD = -1;
            dgvDanhSachMon.DataSource = null;
            tongTien = 0;
            txtTongTien.Text = "";
        }
       
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng món!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string maSoBanChon = banChon.Tag.ToString();
            CTHD chitiet = new CTHD();
            Menu m = cbxMon.SelectedItem as Menu;
            chitiet.MaMon = m.MaMon;
            chitiet.SoLuong = int.Parse(nudSoLuong.Value.ToString());
            for (int i = 0; i < listHoaDonTrangThai.Count; i++)
            {
                if (listHoaDonTrangThai[i].MaBan == maSoBanChon)
                {
                    maHD = listHoaDonTrangThai[i].MaHoaDon;
                    chitiet.MaHoaDon = maHD;
                    List<CTHD> listCTHD = chitietBUS.getListCTHDTheoMa(maHD);
                    CTHD cTHD = chitietBUS.getCTHDTheoMa(maHD);
                    listHoaDonTrangThai[i].TongTien += chitiet.SoLuong * m.DonGia;
                    tongTien = listHoaDonTrangThai[i].TongTien;
                    txtTongTien.Text = String.Format(fVND, "{0:C0}", tongTien);
                    hoaDonBUS.SuaHoaDon(listHoaDonTrangThai[i]);
                    chitietBUS.CapNhatMon(chitiet);
                    LoadDanhSachMon(maHD);
                    return;
                }
            }
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaBan = maSoBanChon;
            hoaDon.MaNhanVien = MaNhanVienHoatDong;
            hoaDon.NgayXuat = DateTime.Now;
            hoaDon.TrangThai = "Chưa thanh toán";
            banChon.Image = Image.FromFile("../../Resources/lytrasua.png");
            hoaDon.TongTien = chitiet.SoLuong * m.DonGia;
            hoaDonBUS.LuuHoaDon(hoaDon);
            maHD = hoaDon.MaHoaDon;
            chitiet.MaHoaDon = hoaDon.MaHoaDon;
            chitietBUS.CapNhatMon(chitiet);
            LoadDanhSachMon(maHD);
            tongTien = hoaDon.TongTien;
            txtTongTien.Text = String.Format(fVND, "{0:C0}", tongTien);
        }

        private void btnDoiBan_Click(object sender, EventArgs e)
        {
            Button banDich = null;
            string maSoBanChuyen, maSoBanDich;
            if (banChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            maSoBanChuyen = banChon.Tag.ToString();
            maSoBanDich = cbxDoiBan.SelectedValue.ToString();
            if (maSoBanDich == null)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển đến", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HoaDon hoaDonChuyen = listHoaDonTrangThai.Where(p => p.MaBan == maSoBanChuyen).FirstOrDefault();
            HoaDon hoaDonDich = listHoaDonTrangThai.Where(p => p.MaBan == maSoBanDich).FirstOrDefault();
            banDich = pnlBan.Controls.OfType<Button>().Where(x => x.Tag.ToString() == maSoBanDich.ToString()).FirstOrDefault();
            if (hoaDonChuyen == null)
            {
                MessageBox.Show("Không thể chuyển bàn trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hoaDonDich == null)
            {
                hoaDonDich = new HoaDon();
                hoaDonDich.MaBan = maSoBanDich;
                hoaDonDich.MaNhanVien = hoaDonChuyen.MaNhanVien;
                hoaDonDich.NgayXuat = hoaDonChuyen.NgayXuat;
                banDich.Image = Image.FromFile("../../Resources/lytrasua.png");
                hoaDonBUS.LuuHoaDon(hoaDonDich);
            }
            for (int i = 0; i < listHoaDonTrangThai.Count; i++)
            {
                /*if (listHoaDonTrangThai[i].MaHoaDon == hoaDonChuyen.MaHoaDon)
                {
                    CTHD ct = new CTHD();
                    ct.MaMon = chitiet.MaMon;
                    ct.SoLuong = chitiet.SoLuong;
                    ct.MaHoaDon = hoaDonDich.MaHoaDon;
                    hoaDonDich.TongTien += chitiet.SoLuong * chitiet.Menu.DonGia;
                    chitietBUS.XoaCTHD(chitiet);
                    chitietBUS.CapNhatMon(ct);
                    hoaDonBUS.SuaHoaDon(hoaDonDich);
                }*/
            }
            hoaDonBUS.XoaHoaDon(hoaDonChuyen);
            maHD = hoaDonDich.MaHoaDon;
            LoadDanhSachMon(maHD);
            tongTien = hoaDonDich.TongTien;
            txtTongTien.Text = String.Format(fVND, "{0:C0}", tongTien);
            banChon.Image = null;
            banChon.BackColor = Color.White;
            banChon = banDich;
            banChon.BackColor = Color.DeepSkyBlue;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan f = new FrmThanhToan();
            f.ShowDialog();
        }

        //Chưa làm

        /*private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần thanh toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string maSoBanChon = banChon.Tag.ToString();
            ThongTinDatBan thongTinDatBan = danhSachDatBan.Where(x => x.MaBan == maSoBanChon).FirstOrDefault();
            if (thongTinDatBan == null)
            {
                MessageBox.Show("Bàn chưa đặt món nào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HoaDon hoaDon = new HoaDon();
            hoaDon.TongTien = long.Parse(tongTien.ToString());
            hoaDon.MaBan = banChon.Tag.ToString();
            hoaDon.NgayXuat = DateTime.Now;
            hoaDon.MaNhanVien = MaNhanVienHoatDong;
            //Chi tiết
            CTHD chiTietHoaDon;
            foreach (var item in thongTinDatBan.DanhSachMon)
            {
                chiTietHoaDon = new CTHD();
                chiTietHoaDon.SoLuong = item.SoLuong;
                chiTietHoaDon.MaMon = item.MaMon;
                hoaDon.CTHD.Add(chiTietHoaDon);
            }
            try
            {
                hoaDonBUS.LuuHoaDon(hoaDon);
                //Mặc định thông tin
                banChon.Image = null;
                dgvDanhSachMon.Rows.Clear();
                txtTongTien.Text = "";
                danhSachDatBan.Remove(thongTinDatBan);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string maSoBanChon = banChon.Tag.ToString();
            ThongTinDatBan thongTinDatBan = danhSachDatBan.Where(x => x.MaBan == maSoBanChon).FirstOrDefault();
            MonDat monDat = new MonDat();
            monDat.TenMon = cbxMon.Text;
            monDat.SoLuong = int.Parse(nudSoLuong.Value.ToString());
            Menu m = (Menu)cbxMon.SelectedItem;
            monDat.DonGia = (double)m.DonGia;
            monDat.MaMon = m.MaMon;
            thongTinDatBan.SuaDSMon(monDat);
            HienThiDanhSachMon(thongTinDatBan.DanhSachMon);
            tongTien = thongTinDatBan.DanhSachMon.Sum(x => x.ThanhTien);
            txtTongTien.Text = String.Format(fVND, "{0:C0}", tongTien);
            cbxDanhMuc.Enabled = true;
            cbxMon.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string maSoBanChon = banChon.Tag.ToString();
            ThongTinDatBan thongTinDatBan = danhSachDatBan.Where(x => x.MaBan == maSoBanChon).FirstOrDefault();
            MonDat monDat = new MonDat();
            monDat.TenMon = cbxMon.Text;
            monDat.SoLuong = int.Parse(nudSoLuong.Value.ToString());
            Menu m = (Menu)cbxMon.SelectedItem;
            monDat.DonGia = (double)m.DonGia;
            monDat.MaMon = m.MaMon;
            thongTinDatBan.XoaMon(monDat);
            HienThiDanhSachMon(thongTinDatBan.DanhSachMon);
            tongTien = thongTinDatBan.DanhSachMon.Sum(x => x.ThanhTien);
            txtTongTien.Text = String.Format(fVND, "{0:C0}", tongTien);
            cbxDanhMuc.Enabled = true;
            cbxMon.Enabled = true;
        }

        private void dgvDanhSachMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rows = e.RowIndex;
                string tenMon = dgvDanhSachMon.Rows[rows].Cells[0].Value.ToString();
                string maDanhMuc = menuBUS.GetMaDanhMucTheoTenMon(tenMon);
                cbxDanhMuc.SelectedValue = maDanhMuc;
                cbxMon.Text = tenMon;
                nudSoLuong.Value = int.Parse(dgvDanhSachMon.Rows[rows].Cells[1].Value.ToString());
                cbxDanhMuc.Enabled = false;
                cbxMon.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
}


