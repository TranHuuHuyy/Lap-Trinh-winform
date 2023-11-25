using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.DataTier.Models;

namespace GongMe.DataTier
{
    internal class MatHangDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        public MatHangDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<MatHang> GetMatHangs()
        {
            return tiemTraSuaModel.MatHang.ToList();
        }
       /* public IEnumerable<MatHang> GetMatHangTheoMaLoaiHang(string maLoai)
        {
            return tiemTraSuaModel.MatHang.Where(x => x.MaLoai == maLoai).ToList();
        }
        internal string GetLoaiHangTheoMaMatHang(string maMatHang)
        {
            return tiemTraSuaModel.MatHang.Where(x => x.MaMatHang == maMatHang).FirstOrDefault().MaMatHang;
        }
        internal string GetMaLoaiTheoTenHang(string tenHang)
        {
            return tiemTraSuaModel.MatHang.Where(x => x.TenHang == tenHang).FirstOrDefault().MaMatHang;
        }*/
    }
}
