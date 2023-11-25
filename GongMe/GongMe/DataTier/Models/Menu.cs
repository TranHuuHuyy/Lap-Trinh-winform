namespace GongMe.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            CTHD = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaMon { get; set; }

        [StringLength(10)]
        public string MaDanhMuc { get; set; }

        [StringLength(50)]
        public string TenMon { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        public long? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHD { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
