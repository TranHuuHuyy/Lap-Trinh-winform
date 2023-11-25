using GongMe.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GongMe.DataTier
{
    internal class MenuDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public MenuDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<Menu> getMENUs()
        {
            return tiemTraSuaModel.Menu.ToList();
        }
        public IEnumerable<Menu> GetMonTheoMaDanhMuc(string maDanhMuc)
        {
            return tiemTraSuaModel.Menu.Where(x => x.MaDanhMuc == maDanhMuc).ToList();
        }

        internal string GetMaDanhMucTheoMaMon(string maMon)
        {
            return tiemTraSuaModel.Menu.Where(x => x.MaMon == maMon).FirstOrDefault().MaDanhMuc;
        }

        internal string GetMaDanhMucTheoTenMon(string tenMon)
        {
            return tiemTraSuaModel.Menu.Where(x => x.TenMon == tenMon).FirstOrDefault().MaDanhMuc;
        }
    }
}
