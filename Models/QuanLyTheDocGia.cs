namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuanLyTheDocGia")]
    public partial class QuanLyTheDocGia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThe { get; set; }

        public int? MaDocGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCap { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
