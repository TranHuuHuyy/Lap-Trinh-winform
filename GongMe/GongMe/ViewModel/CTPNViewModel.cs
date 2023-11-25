using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.ViewModel
{
    internal class CTPNViewModel
    {
      
            public int MaPhieuNhap { get; set; }
            public string MaMatHang { get; set; }
            public int? SoLuong { get; set; }
            public long? DonGia { get; set; }
            public long? ThanhTien { get { return SoLuong * DonGia; } }

       
    }
}
