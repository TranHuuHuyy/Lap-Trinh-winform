using GongMe.DataTier;
using GongMe.DataTier.Models;
using GongMe.ViewModel;
using System;
using System.Collections.Generic;

namespace GongMe.BusinessTier
{
    internal class HoaDonBUS
    {
        private HoaDonDAL hoaDonDAL;
        public HoaDonBUS()
        {
            hoaDonDAL = new HoaDonDAL();
        }
        public bool LuuHoaDon(HoaDon hoaDon)
        {
            try
            {
                return hoaDonDAL.LuuHoaDon(hoaDon);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<HoaDonViewModel> GetHoaDons()
        {
            return hoaDonDAL.GetHoaDons();
        }
        public bool SuaHoaDon(HoaDon hoaDon)
        {
            try
            {
                return hoaDonDAL.SuaHoaDon(hoaDon);
            }
            catch (Exception ex) { throw ex; }

        }
        public bool XoaHoaDon(HoaDon hoaDon)
        {
            try
            {
                return hoaDonDAL.XoaHoaDon(hoaDon);
            }
            catch (Exception ex) { throw ex; }
        }

        public HoaDon GetHoaDonTheoMa(int maHoaDon)
        {
            return hoaDonDAL.GetHoaDonTheoMa(maHoaDon);
        }

        public IEnumerable<HoaDonViewModel> GetHoaDonMaNV(int maNV)
        {
            return hoaDonDAL.GetHoaDonMaNV(maNV);
        }

        public IEnumerable<HoaDonViewModel> GetHoaDonMaHD(int MaHD)
        {
            return hoaDonDAL.GetHoaDonMaHD(MaHD);
        }
        public List<HoaDon> GetHoaDonChuaThanhToan()
        {
            return hoaDonDAL.GetHoaDonChuaThanhToan();
        }
        public List<HoaDon> GetHoaDonDaThanhToan()
        {
            return hoaDonDAL.GetHoaDonDaThanhToan();
        }

        public IEnumerable<HoaDonViewModel> GetHoaDonTrangThai()
        {
            return hoaDonDAL.GetHoaDonTrangThai();
        }
    }
}
