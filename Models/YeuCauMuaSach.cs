namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YeuCauMuaSach")]
    public partial class YeuCauMuaSach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaYeuCau { get; set; }

        public int? MaDocGia { get; set; }

        [Required]
        [StringLength(255)]
        public string TenSach { get; set; }

        [Column(TypeName = "text")]
        public string MoTaYeuCau { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
