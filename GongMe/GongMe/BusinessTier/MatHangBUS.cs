using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.DataTier;
using GongMe.DataTier.Models;

namespace GongMe.BusinessTier
{
    internal class MatHangBUS
    {
        private MatHangDAL MatHangDAL;

        public MatHangBUS()
        {
            MatHangDAL = new MatHangDAL();
        }
        public IEnumerable<MatHang> GetMatHangs()
        {
            return MatHangDAL.GetMatHangs();
        }
        /*public IEnumerable<MatHang> GetMatHangTheoMaLoaiHang(string maLoai)
        {
            return MatHangDAL.GetMatHangTheoMaLoaiHang(maLoai);
        }
        internal string GetLoaiHangTheoMaMatHang(string maMatHang)
        {
            return MatHangDAL.GetLoaiHangTheoMaMatHang(maMatHang);
        }
        internal string GetMaLoaiTheoTenHang(string tenHang)
        {
            return MatHangDAL.GetMaLoaiTheoTenHang(tenHang);
        }*/
       
    }
}
