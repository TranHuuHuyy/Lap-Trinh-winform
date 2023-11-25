using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.DataTier;
using GongMe.DataTier.Models;

namespace GongMe.BusinessTier
{
    internal class NhanVienBUS
    {
        private NhanVienDAL NhanVienDAL;

        public NhanVienBUS()
        {
            NhanVienDAL = new NhanVienDAL();
        }
        public IEnumerable<NhanVien> GetNhanViens()
        {
            return NhanVienDAL.GetNhanViens();
        }
    }
}
