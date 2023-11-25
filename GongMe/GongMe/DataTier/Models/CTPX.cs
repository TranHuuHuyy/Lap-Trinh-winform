namespace GongMe.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPX")]
    public partial class CTPX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaMatHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieuXuat { get; set; }

        public int? SoLuong { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }
    }
}
