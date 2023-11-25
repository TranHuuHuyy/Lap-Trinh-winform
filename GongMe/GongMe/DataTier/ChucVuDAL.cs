using GongMe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.DataTier
{
    internal class ChucVuDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public ChucVuDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<ChucVu> GetCHUCVUs()
        {
            return tiemTraSuaModel.ChucVu.ToList();
        }
    }
}
