using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.ViewModel
{
    internal class DanhSachMon
    {
        public string TenMon { get; set; }
        public int? SoLuong { get; set; }
        public long? DonGia { get; set; }
        public long? ThanhTien { get { return SoLuong * DonGia; } }
    }
}
