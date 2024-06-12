using Microsoft.EntityFrameworkCore;

namespace Sube2.HelloMvc.Models
{
    public class OkulDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=cerendb;Integrated Security=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(40).IsRequired();

            //Ders table Ayarları
            modelBuilder.Entity<Ders>().ToTable("tblDersler");
            modelBuilder.Entity<Ders>().Property(o => o.Dersad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Ders>().Property(o => o.Kredi).HasColumnType("varchar").HasMaxLength(40).IsRequired();

            //OgrenciDers table Ayarları
            modelBuilder.Entity<OgrenciDers>().ToTable("tblOgrenciDersler");

            modelBuilder.Entity<OgrenciDers>()
               .HasKey(e => new { e.OgrenciId, e.DersId });

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(e => e.Ogrenci)
                .WithMany(o => o.OgrenciDersler)
                .HasForeignKey(e => e.OgrenciId);

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(e => e.Ders)
                .WithMany(d => d.OgrenciDersler)
                .HasForeignKey(e => e.DersId);
        }
    }
}
