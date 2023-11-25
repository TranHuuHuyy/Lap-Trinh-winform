using GongMe.DataTier.Models;
using System.Collections.Generic;
using System.Linq;

namespace GongMe.DataTier
{
    internal class BanTraSuaDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public BanTraSuaDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<Ban> getBANs()
        {
            return tiemTraSuaModel.Ban.ToList();
        }
    }
}
