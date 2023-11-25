using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.DataTier.Models
{
    internal class LoaiHangDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public LoaiHangDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<LoaiHang> GetLoaiHangs()
        {
            return tiemTraSuaModel.LoaiHang.ToList();
        }
    }
}
