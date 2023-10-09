namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            BinhLuan = new HashSet<BinhLuan>();
            DangKyMuonSach = new HashSet<DangKyMuonSach>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ISBN { get; set; }

        [Required]
        [StringLength(255)]
        public string TenSach { get; set; }

        [Required]
        [StringLength(255)]
        public string TacGia { get; set; }

        [StringLength(100)]
        public string TheLoai { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string ViTri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyMuonSach> DangKyMuonSach { get; set; }
    }
}
