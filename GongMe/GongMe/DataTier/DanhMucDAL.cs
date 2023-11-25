using GongMe.DataTier.Models;
using System.Collections.Generic;
using System.Linq;

namespace GongMe.DataTier
{
    internal class DanhMucDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public DanhMucDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<DanhMuc> getDANHMUCs()
        {
            return tiemTraSuaModel.DanhMuc.ToList();
        }
        public IEnumerable<DanhMuc>getDANHMUCtheomons(string maDanhMuc)
        {
            return tiemTraSuaModel.DanhMuc.Where(p => p.MaDanhMuc == maDanhMuc).ToList();
        }
    }
}
