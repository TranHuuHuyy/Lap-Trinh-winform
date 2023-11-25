namespace GongMe.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPN")]
    public partial class CTPN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieuNhap { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaMatHang { get; set; }

        public int? SoLuong { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
