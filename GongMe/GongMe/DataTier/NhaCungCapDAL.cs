using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.DataTier.Models
{
    internal class NhaCungCapDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public NhaCungCapDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<NhaCungCap> GetNhaCungCaps()
        {
            return tiemTraSuaModel.NhaCungCap.ToList();
        }
    }
}
