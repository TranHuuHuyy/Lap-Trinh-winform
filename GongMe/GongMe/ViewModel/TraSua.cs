using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe
{
    class TraSua
    {
        Database db;
        public TraSua()
        {
            db = new Database();
        }

        public DataTable LayDSHoaDonChoDoanhThuTuNgayDenNgay(string tungay, string denngay)
        {
            string sql = string.Format("select *from HOADON where (NGAYXUAT between '{0}' and '{1}') AND TrangThai = N'" + "Đã thanh toán" + "'", tungay, denngay);
            DataTable dt = db.Execute(sql);
            //Gói phương thức truy xuất dữ liệu
            return dt;
        }

        public DataTable LayDSNhapHangTuNgayDenNgay(string tungay, string denngay)
        {
            string sql = string.Format("select *from PhieuNhap where NgayNhap between '{0}' and '{1}'", tungay, denngay);
            DataTable df = db.Execute(sql);
            return df;
        }

        public DataTable LayDsXuatHangTuNgayDenNgay(string tunggay, string denngay)
        {
            string sql = string.Format("select *from PhieuXuat where NgayXuat between '{0}' and '{1}'", tunggay, denngay);
            DataTable dh = db.Execute(sql);
            return dh;
        }
    }
}