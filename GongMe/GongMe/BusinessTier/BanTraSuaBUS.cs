using GongMe.DataTier;
using GongMe.DataTier.Models;
using System.Collections.Generic;

namespace GongMe.BusinessTier
{
    internal class BanTraSuaBUS
    {
        private BanTraSuaDAL banTraSuaDAL;
        public BanTraSuaBUS()
        {
            banTraSuaDAL = new BanTraSuaDAL();
        }
        public IEnumerable<Ban> GetBANs()
        {
            return banTraSuaDAL.getBANs();
        }
    }
}
