using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RestApi.Repository.Models;

namespace RestApi.Repository
{
    public partial class bitapDbContext : DbContext
    {
        public bitapDbContext()
        {
        }

        public bitapDbContext(DbContextOptions<bitapDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Duyuru> Duyurus { get; set; } = null!;
        public virtual DbSet<DuyuruAlt> DuyuruAlts { get; set; } = null!;
        public virtual DbSet<Hakkımızdum> Hakkımızda { get; set; } = null!;
        public virtual DbSet<HayPazVerileri> HayPazVerileris { get; set; } = null!;
        public virtual DbSet<HayvanBilgileri> HayvanBilgileris { get; set; } = null!;
        public virtual DbSet<HayvanSat> HayvanSats { get; set; } = null!;
        public virtual DbSet<HesapOzeti> HesapOzetis { get; set; } = null!;
        public virtual DbSet<Iletisim> Iletisims { get; set; } = null!;
        public virtual DbSet<IsletmeBilgileri> IsletmeBilgileris { get; set; } = null!;
        public virtual DbSet<Market> Markets { get; set; } = null!;
        public virtual DbSet<SosyalAg> SosyalAgs { get; set; } = null!;
        public virtual DbSet<SutDestek> SutDesteks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=37.148.212.235;Initial Catalog=bitap;User ID=as;Password=Monywood1900");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DuyuruAlt>(entity =>
            {
                entity.HasKey(e => e.Duyuruid)
                    .HasName("PK_DuyuruKatılım");

                entity.HasOne(d => d.GonderiNoNavigation)
                    .WithMany(p => p.DuyuruAlts)
                    .HasForeignKey(d => d.GonderiNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DuyuruKatılım_Duyuru");
            });

            modelBuilder.Entity<Hakkımızdum>(entity =>
            {
                entity.Property(e => e.Bilinmeyen).IsFixedLength();
            });

            modelBuilder.Entity<HesapOzeti>(entity =>
            {
                entity.Property(e => e.HesapId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Iletisim>(entity =>
            {
                entity.Property(e => e.Bilinmeyen).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
