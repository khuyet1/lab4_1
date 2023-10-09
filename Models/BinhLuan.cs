namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BinhLuan")]
    public partial class BinhLuan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBinhLuan { get; set; }

        public int? MaThe { get; set; }

        public int? MaSach { get; set; }

        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        public DateTime? ThoiGianBinhLuan { get; set; }

        public virtual Sach Sach { get; set; }

        public virtual TheDocGia TheDocGia { get; set; }
    }
}
