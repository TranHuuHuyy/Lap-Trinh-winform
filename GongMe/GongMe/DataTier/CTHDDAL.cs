using GongMe.BusinessTier;
using GongMe.DataTier.Models;
using GongMe.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GongMe.DataTier
{
    internal class CTHDDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public CTHDDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<CTHDViewModel> GetCTHDs(int maHoaDon)
        {
            var danhSach = tiemTraSuaModel.CTHD
                .Where(p => p.MaHoaDon == maHoaDon)
                .Select(p => new CTHDViewModel
                {
                    MaHD = p.MaHoaDon,
                    MaMon = p.MaMon,
                    SoLuong = p.SoLuong,
                    DonGia = p.Menu.DonGia,
                }).ToList();
            return danhSach;
        }
        public IEnumerable<DanhSachMon> GetCTHDMaBan(int maHoaDon)
        {
            var danhSach = tiemTraSuaModel.CTHD
                .Where(p => p.MaHoaDon == maHoaDon)
                .Select(p => new DanhSachMon
                {
                    TenMon = p.Menu.TenMon,
                    DonGia = p.Menu.DonGia,
                    SoLuong = p.SoLuong,
                }).ToList();
            return danhSach;
        }
        public bool CapNhatMon(CTHD cTHD)
        {
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            CTHD chitiet = tiemTraSuaModel.CTHD.Where(p => p.MaHoaDon == cTHD.MaHoaDon).FirstOrDefault();
            try
            {
                if (chitiet == null)
                {
                    tiemTraSuaModel.CTHD.Add(cTHD);
                    tiemTraSuaModel.SaveChanges();
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var item in hoaDonBUS.GetHoaDonTheoMa(cTHD.MaHoaDon).CTHD)
                    {
                        if (item.MaMon == cTHD.MaMon)
                        {
                            chitiet = item;
                            chitiet.MaHoaDon = cTHD.MaHoaDon;
                            chitiet.SoLuong += cTHD.SoLuong;
                            tiemTraSuaModel.CTHD.AddOrUpdate(chitiet);
                            tiemTraSuaModel.SaveChanges();
                            MessageBox.Show("Thêm chi tiết hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                    tiemTraSuaModel.CTHD.Add(cTHD);
                    tiemTraSuaModel.SaveChanges();
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return false;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool SuaCTHD(CTHD cTHD)
        {
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            CTHD chitiet = tiemTraSuaModel.CTHD.Where(p => p.MaHoaDon == cTHD.MaHoaDon).FirstOrDefault();
            try
            {
                if (chitiet == null)
                {
                    throw new Exception("Lỗi");
                }
                else
                {
                    foreach (var item in hoaDonBUS.GetHoaDonTheoMa(cTHD.MaHoaDon).CTHD)
                    {
                        if (item.MaMon == cTHD.MaMon)
                        {
                            chitiet = item;
                            chitiet.SoLuong = cTHD.SoLuong;
                            tiemTraSuaModel.CTHD.AddOrUpdate(chitiet);
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

        public bool XoaCTHD(CTHD cTHD)
        {
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            try
            {
                CTHD chitiet = tiemTraSuaModel.CTHD.Where(p => p.MaHoaDon == cTHD.MaHoaDon).FirstOrDefault();
                List<CTHD> listCTHD = tiemTraSuaModel.CTHD.Where(p => p.MaHoaDon == cTHD.MaHoaDon).ToList();
                if (chitiet == null)
                {
                    throw new Exception("Lỗi");
                }
                else
                {
                    for (int i = 0; i < listCTHD.Count; i++)
                    {
                        if (listCTHD[i].MaMon == cTHD.MaMon)
                        {
                            chitiet = listCTHD[i];
                            tiemTraSuaModel.CTHD.Remove(chitiet);
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

        public List<CTHD> getListCTHDTheoMa(int maHoaDon)
        {
            return tiemTraSuaModel.CTHD.Where(p => p.MaHoaDon == maHoaDon).ToList();
        }

        public CTHD getCTHDTheoMa(int maHoaDon)
        {
            return tiemTraSuaModel.CTHD.Where(p => p.MaHoaDon == maHoaDon).FirstOrDefault();
        }
    }
}
