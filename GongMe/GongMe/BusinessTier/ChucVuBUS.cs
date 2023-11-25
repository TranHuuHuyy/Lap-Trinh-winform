using GongMe.DataTier.Models;
using GongMe.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.BusinessTier
{
    internal class ChucVuBUS
    {
        private ChucVuDAL chucVuDAL;
        public ChucVuBUS()
        {
            chucVuDAL = new ChucVuDAL();
        }
        public IEnumerable<ChucVu> GetCHUCVUs()
        {
            return chucVuDAL.GetCHUCVUs();
        }
    }
}
