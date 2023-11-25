using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe.ViewModel
{
    public class HoaDonViewModel
    {
        public int MaHD { get; set; }
        public int? MaNV { get; set; }
        public string MaBan { get; set; }
        public DateTime? NgayBan { get; set; }
        public long? TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
