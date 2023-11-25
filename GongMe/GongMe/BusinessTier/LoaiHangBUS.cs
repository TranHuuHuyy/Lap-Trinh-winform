using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.DataTier.Models;
using GongMe.DataTier;

namespace GongMe.BusinessTier
{
    internal class LoaiHangBUS
    {
        private LoaiHangDAL LoaiHangDAL;

        public LoaiHangBUS()
        {
            LoaiHangDAL = new LoaiHangDAL();
        }
        public IEnumerable<LoaiHang> GetLoaiHangs()
        {
            return LoaiHangDAL.GetLoaiHangs();
        }
    }
}
