using GongMe.DataTier;
using System.Collections.Generic;
using GongMe.DataTier.Models;
using System;

namespace GongMe.BusinessTier
{
    internal class MenuBUS
    {
        private MenuDAL menuDAL;
        public MenuBUS()
        {
            menuDAL = new MenuDAL();
        }
        public IEnumerable<Menu> getMENUs()
        {
            return menuDAL.getMENUs();
        }
        public IEnumerable<Menu> GetMonTheoMaDanhMuc(string maDanhMuc)
        {
            return menuDAL.GetMonTheoMaDanhMuc(maDanhMuc);
        }

        internal string GetMaDanhMucTheoMaMon(string maMon)
        {
            return menuDAL.GetMaDanhMucTheoMaMon(maMon);
        }

        internal string GetMaDanhMucTheoTenMon(string tenMon)
        {
            return menuDAL.GetMaDanhMucTheoTenMon(tenMon);
        }
    }
}
