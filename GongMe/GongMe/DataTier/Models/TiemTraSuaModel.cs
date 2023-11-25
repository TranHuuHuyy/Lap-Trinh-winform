using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GongMe.DataTier.Models
{
    public partial class TiemTraSuaModel : DbContext
    {
        public TiemTraSuaModel()
            : base("name=TiemTraSuaModel1")
        {
        }

        public virtual DbSet<Ban> Ban { get; set; }
        public virtual DbSet<CTPN> CTPN { get; set; }
        public virtual DbSet<CTPX> CTPX { get; set; }
        public virtual DbSet<CTHD> CTHD { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<LoaiHang> LoaiHang { get; set; }
        public virtual DbSet<MatHang> MatHang { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuat { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .Property(e => e.MaBan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTPN>()
                .Property(e => e.MaMatHang)
                .IsFixedLength();

            modelBuilder.Entity<CTPX>()
                .Property(e => e.MaMatHang)
                .IsFixedLength();

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaMon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaChucVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.MaDanhMuc)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaBan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHD)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiHang>()
                .Property(e => e.MaLoai)
                .IsFixedLength();

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaMatHang)
                .IsFixedLength();

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaLoai)
                .IsFixedLength();

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.CTPN)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.CTPX)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.MaMon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.MaDanhMuc)
                .IsFixedLength();

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.CTHD)
                .WithRequired(e => e.Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNhaCC)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Sdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaChucVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Sdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Mail)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNhaCC)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.CTPN)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuXuat>()
                .HasMany(e => e.CTPX)
                .WithRequired(e => e.PhieuXuat)
                .WillCascadeOnDelete(false);
        }
    }
}
