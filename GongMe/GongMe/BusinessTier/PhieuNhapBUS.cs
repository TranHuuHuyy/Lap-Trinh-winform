using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.DataTier;
using GongMe.DataTier.Models;
using GongMe.PresentionTier;
using GongMe.ViewModel;

namespace GongMe.BusinessTier
{
    internal class PhieuNhapBUS
    {
        private PhieuNhapDAL phieunhapDAL;
        private object MaNhanVien { get; set; }

        public object MaNhaCC { get; private set; }

        public PhieuNhapBUS()
        {
            phieunhapDAL = new PhieuNhapDAL();
        }
        public bool ThemPhieuNhap(PhieuNhap phieunhap)
        {
            try
            {
                return phieunhapDAL.ThemPhieuNhap(phieunhap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<PhieuNhapViewModel> GetPhieuNhaps()
        {
            return phieunhapDAL.GetPhieuNhaps();
        }
        public bool SuaPhieuNhap(PhieuNhap phieunhap)
        {
            try
            {
                return phieunhapDAL.SuaPhieuNhap(phieunhap);
            }
            catch (Exception ex) { throw ex; }

        }
        public bool XoaPhieuNhap(PhieuNhap phieunhap)
        {
            try
            {
                return phieunhapDAL.XoaPhieuNhap(phieunhap);
            }
            catch (Exception ex) { throw ex; }
        }


        public IEnumerable<PhieuNhapViewModel> getPhieuNhapMaNhanVien(int maNV)
        {
            return phieunhapDAL.GetPhieuNhapMaNhanVien(maNV);
        }

        public IEnumerable<PhieuNhapViewModel> getPhieuNhapMaNhaCC(int MaNhaCC)
        {
            return phieunhapDAL.GetPhieuNhapMaNhaCC(MaNhaCC);
        }

        internal PhieuNhap getPhieuNhapTheoMa(int maPhieuNhap)
        {
            return phieunhapDAL.getPhieuNhapTheoMa(maPhieuNhap);
        }

        public List<PhieuNhap> TongChi()
        {
            return phieunhapDAL.TongChi();
        }
    }
}
