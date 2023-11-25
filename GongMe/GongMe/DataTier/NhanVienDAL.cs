using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.DataTier.Models;

namespace GongMe.DataTier
{
    internal class NhanVienDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public NhanVienDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<NhanVien> GetNhanViens()
        {
            return tiemTraSuaModel.NhanVien.ToList();
        }
    }
}
