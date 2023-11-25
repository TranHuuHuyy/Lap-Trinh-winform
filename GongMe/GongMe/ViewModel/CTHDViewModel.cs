using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.ViewModel
{
    public class CTHDViewModel
    {
        public int MaHD { get; set; }
        public string MaMon { get; set; }
        public int? SoLuong { get; set; }
        public long? DonGia { get; set; }
        public long? ThanhTien { get { return SoLuong * DonGia; } }
    }
}
