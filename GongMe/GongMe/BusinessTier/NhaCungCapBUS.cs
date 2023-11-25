using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.DataTier;
using GongMe.DataTier.Models;

namespace GongMe.BusinessTier
{
    internal class NhaCungCapBUS
    {
       private NhaCungCapDAL NhaCungCapDAL;
        
        public NhaCungCapBUS()
        {
            NhaCungCapDAL = new NhaCungCapDAL();
        }
        public IEnumerable<NhaCungCap> GetNhaCungCaps()
        {
            return NhaCungCapDAL.GetNhaCungCaps();
        }
    }
}
