using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GongMe.BusinessTier;
using GongMe.DataTier;
using GongMe.DataTier.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace GongMe.PresentionTier
{
    public partial class FrmNhapHang : Form
    {
        private readonly PhieuNhapBUS PhieuNhapBUS;
        private MatHangBUS MatHangBUS;
        private TenHangBUS TenHangBUS;
        private DonGiaBUS DonGiaBUS;
        private CTPNBUS CTPNBUS;
        NhaCungCapBUS nhaCungCapBUS;
        NhanVienBUS nhanVienBUS;
        LoaiHangBUS LoaiHangBUS;
        
        private int maHoaDon = -1;
        private long? tongTien = 0;
        private long? tongdoanhthu = 0;

        string MACHUCVU = "";

        System.Globalization.CultureInfo fVND = new System.Globalization.CultureInfo("vi-VN");

        private object NhaphangBUS;
        private object item;
        private int maPhieuNhap = -1;

        private long? TongChi = 0;
        private object mathang;
        private string maMatHang;
        private object txtTongTien;

        public int MaNhanVien { get; private set; }

        public FrmNhapHang()
        {
            InitializeComponent();
            PhieuNhapBUS = new PhieuNhapBUS();
            MatHangBUS = new MatHangBUS();
            TenHangBUS = new TenHangBUS();
            DonGiaBUS = new DonGiaBUS();
            CTPNBUS = new CTPNBUS();
            nhaCungCapBUS = new NhaCungCapBUS();
            nhanVienBUS = new NhanVienBUS();
            LoaiHangBUS = new LoaiHangBUS();
            
            CaiDatDieuKhien();
            this.Load += FrmPhieuNhap_Load;

            this.MACHUCVU = MACHUCVU;
        }

        private void CaiDatDieuKhien()
        {
            cbxNhaCungCap.DisplayMember = "TenNhaCC";
            cbxNhaCungCap.ValueMember = "MaNhaCC";

            cbxNhanVien.DisplayMember = "HoTen";
            cbxNhanVien.ValueMember = "MaNhanVien";

            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.CustomFormat = "dd-MM-yyyy,hh,mi,0";
            dtpNgayNhap.MaxDate = DateTime.Now;
            dtpNgayNhap.Value = DateTime.Today;


            cbxLoaiHang.DisplayMember = "TenLoai";
            cbxLoaiHang.ValueMember = "MaLoai";

            cbxMatHang.DisplayMember = "TenHang";
            cbxMatHang.ValueMember = "MaMatHang";
        }


        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
            LoadNhaCungCap();
            LoadNhanVien();
            LoadTongChi();
            LoadLoaiHang();
            LoadMatHang();
            nudSoLuong.Value = 1;

        }
        private void LoadTongChi()
        {
            TongChi = PhieuNhapBUS.TongChi().Sum(p => p.TongTien).Value;
            txtTongChi.Text = String.Format(fVND, "{0:C0}", (TongChi));
        }

        private void LoadNhanVien()
        {
            cbxNhanVien.DataSource = nhanVienBUS.GetNhanViens();
        }

        private void LoadNhaCungCap()
        {
            cbxNhaCungCap.DataSource = nhaCungCapBUS.GetNhaCungCaps();
        }
        private void LoaddgvPhieuNhap()
        {
            /*dgvPhieuNhap.DataSource = null;*/
        }

        private void LoadPhieuNhap()
        {
            dgvPhieuNhap.DataSource = PhieuNhapBUS.GetPhieuNhaps();
        }
        private void LoaddgvCTPhieuNhap()
        {
            //dgvPhieuNhap.DataSource = ;
        }
        private void LoadCTPN(int maPhieuNhap)
        {
            dgvCTPhieuNhap.DataSource = CTPNBUS.GetCTPN(maPhieuNhap);
        }
        private void LoadMatHang()
        {
            cbxMatHang.DataSource = MatHangBUS.GetMatHangs();
        }
        private void LoadLoaiHang()
        {
            cbxLoaiHang.DataSource = LoaiHangBUS.GetLoaiHangs();
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {

            PhieuNhap pn = new PhieuNhap();
            NhaCungCap nhacungcap = cbxNhaCungCap.SelectedItem as NhaCungCap;
            pn.MaNhaCC = nhacungcap.MaNhaCC;
            pn.NgayNhap = DateTime.Parse(dtpNgayNhap.Value.ToString());
            NhanVien nhanVien = cbxNhanVien.SelectedItem as NhanVien;
            pn.MaNhanVien = nhanVien.MaNhanVien;
            pn.TongTien = 0;
            try
            {
                PhieuNhapBUS.ThemPhieuNhap(pn);
                LoadPhieuNhap();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            if (maPhieuNhap == -1)
            {
                MessageBox.Show("Chưa chọn hóa đơn sao sửa má!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PhieuNhap pn = new PhieuNhap();
            TaoPhieuNhapMoi(pn);
            pn.MaPhieuNhap = maPhieuNhap;
            try
            {
                PhieuNhapBUS.SuaPhieuNhap(pn);
                MessageBox.Show("Sửa hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuNhap();
                LoaddgvCTPhieuNhap();
                btnThemPhieu.Enabled = true;
                btnThemCTPhieu.Enabled = true;
                cbxNhaCungCap.Enabled = true;
                cbxNhanVien.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TaoPhieuNhapMoi(PhieuNhap pn)
        {
            NhaCungCap nhaCungCap = cbxNhaCungCap.SelectedItem as NhaCungCap;
            pn.MaNhaCC = nhaCungCap.MaNhaCC;
            pn.NgayNhap = DateTime.Parse(dtpNgayNhap.Value.ToString());
            NhanVien nhanVien = cbxNhanVien.SelectedItem as NhanVien;
            pn.MaNhanVien = nhanVien.MaNhanVien;
        }
       private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if (maPhieuNhap == -1)
            {
                MessageBox.Show("Chưa chọn hóa đơn sao xóa được má!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PhieuNhap pn = new PhieuNhap();
            NhaCungCap ncc = cbxNhaCungCap.SelectedItem as NhaCungCap;
            pn.MaNhaCC = ncc.MaNhaCC;
            NhanVien nv = cbxNhanVien.SelectedItem as NhanVien;
            pn.MaNhanVien = nv.MaNhanVien;
            pn.NgayNhap = DateTime.Parse(dtpNgayNhap.Value.ToString());
            pn.MaPhieuNhap = maPhieuNhap;
            //txtTongChi.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
            foreach (var item in PhieuNhapBUS.getPhieuNhapTheoMa(maPhieuNhap).CTPN)
            {
                pn.CTPN.Remove(item);
            }
            try
            {
                PhieuNhapBUS.XoaPhieuNhap(pn);
                LoadPhieuNhap();
                LoaddgvCTPhieuNhap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThemCTPhieu_Click(object sender, EventArgs e)
        {
            if (maPhieuNhap == -1)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập  muốn thêm chi tiết!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudSoLuong.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // lưu ctpn cần thêm
            CTPN CTPN = new CTPN();
            CTPN.MaPhieuNhap = maPhieuNhap;

            MatHang mathang = cbxMatHang.SelectedItem as MatHang;
            CTPN.MaMatHang = mathang.MaMatHang;
            CTPN.SoLuong = int.Parse(nudSoLuong.Value.ToString());
            CTPN chitiet = CTPNBUS.getCTPNTheoMa(maPhieuNhap);
            List<CTPN> ListCTPN = CTPNBUS.getListCTPNTheoMa(maPhieuNhap);
            try
            {

                PhieuNhap pn = PhieuNhapBUS.getPhieuNhapTheoMa(maPhieuNhap);
                tongTien =  pn.TongTien +mathang.DonGia * CTPN.SoLuong;
                tongdoanhthu += tongTien;
                txtTongChi.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                pn.TongTien = tongTien;
                tongTien = 0;

                /*tongTien = pn.TongTien + (mathang.DonGia * CTPN.SoLuong);
                txtTongChi.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                pn.TongTien = tongTien;
                tongTien = 0;*/
                //}
                PhieuNhapBUS.SuaPhieuNhap(pn);
                CTPNBUS.ThemCTPhieu(CTPN);
                LoadPhieuNhap();
                LoadMatHang();
                LoadCTPN(maPhieuNhap);
                LoadLoaiHang();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaCTPhieu_Click(object sender, EventArgs e)
        {
            CTPN CTPN = new CTPN();
            CTPN.MaPhieuNhap = maPhieuNhap;
            MatHang mathang= cbxMatHang.SelectedItem as MatHang;
            CTPN.MaMatHang = mathang.MaMatHang;
            CTPN chitiet = CTPNBUS.getCTPNTheoMa(maPhieuNhap);
            CTPN.SoLuong = int.Parse(nudSoLuong.Value.ToString());
            try
            {

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết phieu  nhap này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    CTPNBUS.XoaCTPN(CTPN);
                    PhieuNhap pn = PhieuNhapBUS.getPhieuNhapTheoMa(maPhieuNhap);
                   
                    tongTien = mathang.DonGia* CTPN.SoLuong;
                    pn.TongTien = pn.TongTien - tongTien;
                    tongdoanhthu -= tongTien;
                    txtTongChi.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                    tongTien = 0;


                    LoadCTPN(maPhieuNhap);
                    PhieuNhapBUS.SuaPhieuNhap(pn);
                    LoadPhieuNhap();
                    cbxMatHang.Enabled = true;
                    cbxLoaiHang.Enabled = true;
                    btnThemCTPhieu.Enabled = true;
                    btnSuaCTPhieu.Enabled = true;
                    btnXoaCTPhieu.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rows = e.RowIndex;
                maPhieuNhap = int.Parse(dgvPhieuNhap.Rows[rows].Cells[0].Value.ToString());
                cbxNhaCungCap.SelectedValue = dgvPhieuNhap.Rows[rows].Cells[1].Value.ToString();
                NhaCungCap ncc = cbxNhaCungCap.SelectedItem as NhaCungCap;
                cbxNhaCungCap.Text = ncc.TenNhaCC;
                cbxNhanVien.SelectedValue = int.Parse(dgvPhieuNhap.Rows[rows].Cells[2].Value.ToString());
                NhanVien nv = cbxNhanVien.SelectedItem as NhanVien;
                cbxNhanVien.Text = nv.HoTen;
                dtpNgayNhap.Text = dgvPhieuNhap.Rows[rows].Cells[3].Value.ToString();
                //txtTongChi.Text = dgvPhieuNhap.Rows[rows].Cells[4].Value.ToString();


                LoadCTPN(maPhieuNhap);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaCTPhieu_Click(object sender, EventArgs e)
        {
            CTPN CTPN = new CTPN();
            CTPN.MaPhieuNhap = maPhieuNhap;
            MatHang mathang = cbxMatHang.SelectedItem as MatHang;
            CTPN.MaMatHang = mathang.MaMatHang;
            CTPN.SoLuong = int.Parse(nudSoLuong.Value.ToString());
            CTPN chitiet = CTPNBUS.getCTPNTheoMa(maPhieuNhap);
            List<CTPN> listCTPN = CTPNBUS.getListCTPNTheoMa(maPhieuNhap);
            try
            {
                for (int i = 0; i < listCTPN.Count; i++)
                {
                    if (listCTPN[i].MaMatHang == chitiet.MaMatHang)
                    {
                        chitiet = listCTPN[i];
                        PhieuNhap pn = PhieuNhapBUS.getPhieuNhapTheoMa(maPhieuNhap);
                        tongTien = mathang.DonGia * CTPN.SoLuong - mathang.DonGia * chitiet.SoLuong;
                        pn.TongTien += tongTien;
                        tongdoanhthu += tongTien;
                        txtTongChi.Text = String.Format(fVND, "{0:C0}", (tongdoanhthu));
                        //pn.TongTien = tongTien;

                        tongTien = 0;

                        PhieuNhapBUS.SuaPhieuNhap(pn);
                        CTPNBUS.SuaCTPN(CTPN);
                        LoadPhieuNhap();
                        LoadCTPN(maPhieuNhap);
                        cbxMatHang.Enabled = true;
                        btnThemCTPhieu.Enabled = true;
                        btnSuaCTPhieu.Enabled = true;
                        btnXoaCTPhieu.Enabled = false;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rows = e.RowIndex;
                maPhieuNhap = Convert.ToInt32(dgvCTPhieuNhap.Rows[rows].Cells[0].Value.ToString());
                string maMatHang = dgvCTPhieuNhap.Rows[rows].Cells[1].Value.ToString();
                cbxMatHang.SelectedValue = maMatHang;

                nudSoLuong.Value = int.Parse(dgvCTPhieuNhap.Rows[rows].Cells[2].Value.ToString());
                btnXoaCTPhieu.Enabled = true;
                btnSuaCTPhieu.Enabled = true;
                btnThemCTPhieu.Enabled = true;
                cbxMatHang.Enabled = true;
                cbxLoaiHang.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtTimPhieuNhap.Text == "")
            {
                LoadPhieuNhap();
                LoaddgvCTPhieuNhap();

                txtKetQua.Text = "";
            }
            else
            {
                try
                {
                    int timpn = int.Parse(txtTimPhieuNhap.Text.ToString());
                    foreach (var pn in PhieuNhapBUS.GetPhieuNhaps())
                    {
                        if (pn.MaPhieuNhap == timpn)
                        {
                            dgvPhieuNhap.DataSource = PhieuNhapBUS.getPhieuNhapTheoMa(pn.MaPhieuNhap);
                            txtKetQua.Text = "Phiếu Nhập " + pn.MaPhieuNhap;
                            LoadCTPN(pn.MaPhieuNhap);

                            return;
                        }
                    }
                    foreach (var pn in PhieuNhapBUS.GetPhieuNhaps())
                    {
                        if (pn.MaNhanVien == timpn)
                        {
                            dgvPhieuNhap.DataSource = PhieuNhapBUS.getPhieuNhapMaNhanVien(int.Parse(timpn.ToString()));


                            NhanVien nv = nhanVienBUS.GetNhanViens().Where(p => p.MaNhanVien == pn.MaNhanVien).FirstOrDefault();
                            txtKetQua.Text = nv.HoTen;
                            LoadCTPN(pn.MaPhieuNhap);


                            return;
                        }
                    }
                    txtKetQua.Text = "Không tìm thấy kết quả";
                    LoaddgvPhieuNhap();
                    LoaddgvCTPhieuNhap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        /*private void cbxLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            string maLoai = cbx.SelectedValue.ToString();
            cbxMatHang.DataSource = MatHangBUS.GetMatHangTheoMaLoaiHang(maLoai);
        }*/
      

    }


}



 





