using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace GongMe.ViewModel
{
    internal class NhanVienViewModel
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public string MaCV { get; set; }
        public int? NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public string Mail { get; set; }
    }
}
