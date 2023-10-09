namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Open : DbContext
    {
        public Open()
            : base("name=Open")
        {
        }

        public virtual DbSet<BinhLuan> BinhLuan { get; set; }
        public virtual DbSet<DangKyMuonSach> DangKyMuonSach { get; set; }
        public virtual DbSet<DocGia> DocGia { get; set; }
        public virtual DbSet<QuanLyTheDocGia> QuanLyTheDocGia { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }
        public virtual DbSet<TheDocGia> TheDocGia { get; set; }
        public virtual DbSet<YeuCauMuaSach> YeuCauMuaSach { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinhLuan>()
                .Property(e => e.NoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<DangKyMuonSach>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.TenDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<QuanLyTheDocGia>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.TenSach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.TacGia)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.TheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.ViTri)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.BinhLuan)
                .WithOptional(e => e.Sach)
                .HasForeignKey(e => e.MaSach);

            modelBuilder.Entity<TheDocGia>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);

            modelBuilder.Entity<YeuCauMuaSach>()
                .Property(e => e.TenSach)
                .IsUnicode(false);

            modelBuilder.Entity<YeuCauMuaSach>()
                .Property(e => e.MoTaYeuCau)
                .IsUnicode(false);

            modelBuilder.Entity<YeuCauMuaSach>()
                .Property(e => e.TrangThai)
                .IsUnicode(false);
        }
    }
}
