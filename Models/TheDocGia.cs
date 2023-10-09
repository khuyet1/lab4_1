namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheDocGia")]
    public partial class TheDocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TheDocGia()
        {
            BinhLuan = new HashSet<BinhLuan>();
            DangKyMuonSach = new HashSet<DangKyMuonSach>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThe { get; set; }

        public int? MaDocGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyMuonSach> DangKyMuonSach { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
