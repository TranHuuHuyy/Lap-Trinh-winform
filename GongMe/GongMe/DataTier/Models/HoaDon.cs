namespace GongMe.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            CTHD = new HashSet<CTHD>();
        }

        [Key]
        public int MaHoaDon { get; set; }

        public int? MaNhanVien { get; set; }

        [StringLength(10)]
        public string MaBan { get; set; }

        public DateTime? NgayXuat { get; set; }

        public long? TongTien { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual Ban Ban { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHD { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
