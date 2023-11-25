using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GongMe.DataTier.Models;
using GongMe.ViewModel;
public class PhieuNhapViewModel
{
    public int MaPhieuNhap { get; internal set; }
    public string MaNhaCC { get; internal set; }
    public int? MaNhanVien { get; internal set; }
    public DateTime? NgayNhap { get; internal set; }
    public long? TongTien { get; internal set; }
    
}

namespace GongMe.DataTier
{
    internal class PhieuNhapDAL
    {
        private TiemTraSuaModel tiemTraSuaModel;
        private object phieunhap;
        private object pn;

        public int? MaNhanVien { get; private set; }
        public string MaNhaCC { get; private set; }

        public PhieuNhapDAL()
        {
            tiemTraSuaModel = new TiemTraSuaModel();
        }
        public IEnumerable<PhieuNhapViewModel> GetPhieuNhaps()
        {
            var danhSach = tiemTraSuaModel.PhieuNhap
                .Select(p => new PhieuNhapViewModel
                {
                    MaPhieuNhap = p.MaPhieuNhap,
                    MaNhaCC = p.MaNhaCC,
                    MaNhanVien = p.MaNhanVien,
                    NgayNhap = p.NgayNhap,
                    TongTien = p.TongTien,
                }).ToList();
            return danhSach;
        }
        public bool ThemPhieuNhap(PhieuNhap pn)
        {
            try
            {
                tiemTraSuaModel.PhieuNhap.Add(pn);
                tiemTraSuaModel.SaveChanges();
                MessageBox.Show("Them thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool SuaPhieuNhap(PhieuNhap pn)
        {
            try
            {
                PhieuNhap phieunhap = tiemTraSuaModel.PhieuNhap.Where(p => p.MaPhieuNhap == pn.MaPhieuNhap).FirstOrDefault();
                if (phieunhap == null)
                {
                    throw new Exception("Lỗi");
                }
                else
                {
                    phieunhap.MaNhanVien = pn.MaNhanVien;
                    phieunhap.NgayNhap = pn.NgayNhap;
                    phieunhap.MaNhaCC = pn.MaNhaCC;
                    tiemTraSuaModel.PhieuNhap.AddOrUpdate(phieunhap);
                    tiemTraSuaModel.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex) { throw ex; }
        }
        public bool XoaPhieuNhap(PhieuNhap pn)
        {
            try
            {
                PhieuNhap phieuNhap = tiemTraSuaModel.PhieuNhap.Where(p => p.MaPhieuNhap == pn.MaPhieuNhap).FirstOrDefault();
                if (phieuNhap == null)
                {
                    throw new Exception("Lỗi");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        tiemTraSuaModel.PhieuNhap.Remove(phieuNhap);
                        tiemTraSuaModel.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        internal IEnumerable<PhieuNhapViewModel> GetPhieuNhapMaNhanVien(int maNhanVien)
        {
            var danhSach = tiemTraSuaModel.PhieuNhap
                .Where(p => p.MaNhanVien == maNhanVien)
                .Select(p => new PhieuNhapViewModel
                {
                    MaNhaCC = p.MaNhaCC,
                    MaPhieuNhap = p.MaPhieuNhap,
                    MaNhanVien = p.MaNhanVien,
                    NgayNhap = p.NgayNhap,
                     TongTien = p.TongTien,
                }).ToList();
            return danhSach;
        }


        internal IEnumerable<PhieuNhapViewModel> GetPhieuNhapMaNhaCC(int maNhaCC)
        {
            var danhSach = tiemTraSuaModel.PhieuNhap
                .Where(p => p.MaNhaCC == MaNhaCC)
                .Select(p => new PhieuNhapViewModel
                {
                    MaNhaCC = p.MaNhaCC,
                    MaPhieuNhap = p.MaPhieuNhap,
                    MaNhanVien = p.MaNhanVien,
                    NgayNhap = p.NgayNhap,
                    TongTien = p.TongTien,
                }).ToList();
            return danhSach;
        }

        internal PhieuNhap getPhieuNhapTheoMa(int maPhieuNhap)
        {
            return tiemTraSuaModel.PhieuNhap.Where(p => p.MaPhieuNhap == maPhieuNhap).FirstOrDefault();
        }
         public  List<PhieuNhap>TongChi()
        {
            return tiemTraSuaModel.PhieuNhap.ToList();
        }
    }

}
