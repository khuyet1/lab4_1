namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKyMuonSach")]
    public partial class DangKyMuonSach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDangKy { get; set; }

        public int? MaThe { get; set; }

        public int? ISBN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKy { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual TheDocGia TheDocGia { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
