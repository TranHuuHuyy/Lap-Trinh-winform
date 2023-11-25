using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.BusinessTier;
using System.Windows.Forms;
using GongMe.ViewModel;

namespace GongMe.DataTier.Models
{
    internal class CTPNDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public CTPNDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }

        //public int MaPhieuNhap { get; private set; }

        public IEnumerable<CTPNViewModel> GetCTPN(int maPhieuNhap)
        {
            var danhSach = tiemTraSuaModel.CTPN
                .Where(p => p.MaPhieuNhap == maPhieuNhap)
                .Select(p => new CTPNViewModel
                {
                    MaPhieuNhap = p.MaPhieuNhap,
                    MaMatHang = p.MaMatHang,
                    SoLuong = p.SoLuong,
                    DonGia = p.MatHang.DonGia,
                }).ToList();
            return danhSach;
        }

        public CTPN getCTPNTheoMa(int maPhieuNhap)
        {
            return tiemTraSuaModel.CTPN.Where(p => p.MaPhieuNhap == maPhieuNhap).FirstOrDefault();
        }
       

        public List<CTPN> getListCTPNTheoMa(int maPhieuNhap)
        {
            return tiemTraSuaModel.CTPN.Where(p => p.MaPhieuNhap == maPhieuNhap).ToList();
        }

        public bool SuaCTPN(CTPN cTPN)
        {
            PhieuNhapBUS phieunhapBUS = new PhieuNhapBUS();
            CTPN chitiet = tiemTraSuaModel.CTPN.Where(p => p.MaPhieuNhap == cTPN.MaPhieuNhap).FirstOrDefault();
            try
            {
                if (chitiet == null)
                {
                    throw new Exception("Lỗi");
                }
                else
                {
                    foreach (var item in phieunhapBUS.getPhieuNhapTheoMa(cTPN.MaPhieuNhap).CTPN)
                    {
                        if (item.MaMatHang == cTPN.MaMatHang)
                        {
                            chitiet = item;
                            chitiet.SoLuong = cTPN.SoLuong;
                            tiemTraSuaModel.CTPN.AddOrUpdate(chitiet);
                            tiemTraSuaModel.SaveChanges();
                            MessageBox.Show("Sửa chi tiết hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                            
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public bool ThemCTPhieu(CTPN CTPN)
        {
            PhieuNhapBUS phieunhapBUS = new PhieuNhapBUS();
            CTPN chitiet = tiemTraSuaModel.CTPN.Where(p => p.MaPhieuNhap == CTPN.MaPhieuNhap).FirstOrDefault();
            try
            {
                if (chitiet == null)
                {
                    tiemTraSuaModel.CTPN.Add(CTPN);
                    tiemTraSuaModel.SaveChanges();
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var item in phieunhapBUS.getPhieuNhapTheoMa(CTPN.MaPhieuNhap).CTPN)
                    {
                        if (item.MaMatHang == CTPN.MaMatHang)
                        {
                            chitiet = item;
                            chitiet.MaPhieuNhap = CTPN.MaPhieuNhap;
                            chitiet.SoLuong += CTPN.SoLuong;
                            chitiet.MatHang = CTPN.MatHang;
                            tiemTraSuaModel.CTPN.AddOrUpdate(chitiet);
                            tiemTraSuaModel.SaveChanges();
                            MessageBox.Show("Thêm chi tiết hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                    tiemTraSuaModel.CTPN.Add(CTPN);
                    tiemTraSuaModel.SaveChanges();
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return false;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool XoaCTPN(CTPN cTPN)
        {
            PhieuNhapBUS phieunhapBUS = new PhieuNhapBUS();
            try
            {
                CTPN chitiet = tiemTraSuaModel.CTPN.Where(p => p.MaPhieuNhap == cTPN.MaPhieuNhap).FirstOrDefault();
                List<CTPN> listCTPN = tiemTraSuaModel.CTPN.Where(p => p.MaPhieuNhap == cTPN.MaPhieuNhap).ToList();
                if (chitiet==null )
                {
                    throw new Exception("Lỗi");
                }
                else
                {
                    for (int i = 0; i < listCTPN.Count; i++)
                    {
                        if (listCTPN[i].MaMatHang == cTPN.MaMatHang)
                        {
                            chitiet = listCTPN[i];
                            tiemTraSuaModel.CTPN.Remove(chitiet);
                            tiemTraSuaModel.SaveChanges();
                            MessageBox.Show("Xóa chi tiết hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
        }

    }
}
