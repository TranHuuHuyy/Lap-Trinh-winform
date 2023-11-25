using GongMe.DataTier;
using GongMe.DataTier.Models;
using GongMe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.BusinessTier
{
    internal class CTHDBUS
    {
        private CTHDDAL cTHDDAL;
        public CTHDBUS()
        {
            cTHDDAL = new CTHDDAL();
        }
        public IEnumerable<CTHDViewModel> GetCTHDs(int maHoaDon)
        {
            return cTHDDAL.GetCTHDs(maHoaDon);
        }
        public IEnumerable<DanhSachMon> GetCTHDMaBan(int maHoaDon)
        {
            return cTHDDAL.GetCTHDMaBan(maHoaDon);
        }
        public bool CapNhatMon(CTHD cTHD)
        {
            try
            {
                return cTHDDAL.CapNhatMon(cTHD);
            }
            catch (Exception ex) { throw ex; }
        }
        public bool XoaCTHD(CTHD cTHD)
        {
            try
            {
                return cTHDDAL.XoaCTHD(cTHD);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<CTHD> getListCTHDTheoMa(int maHoaDon)
        {
            return cTHDDAL.getListCTHDTheoMa(maHoaDon);
        }

        public bool SuaCTHD(CTHD cTHD)
        {
            try
            {
                return cTHDDAL.SuaCTHD(cTHD);
            }
            catch (Exception ex) { throw ex; }
        }

        public CTHD getCTHDTheoMa(int maHoaDon)
        {
            return cTHDDAL.getCTHDTheoMa(maHoaDon);
        }
    }
}
