using GongMe.DataTier;
using GongMe.DataTier.Models;
using System.Collections.Generic;

namespace GongMe.BusinessTier
{
    internal class DanhMucBUS
    {
        private DanhMucDAL danhMucDAL;
        public DanhMucBUS()
        {
            danhMucDAL = new DanhMucDAL();
        }
        public IEnumerable<DanhMuc> GetDANHMUCs()
        {
            return danhMucDAL.getDANHMUCs();
        }
        public IEnumerable<DanhMuc> getDANHMUCtheomons(string maDanhMuc)
        {
            return danhMucDAL.getDANHMUCtheomons(maDanhMuc);
        }

    }
}
