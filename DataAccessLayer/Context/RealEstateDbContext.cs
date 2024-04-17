using System;
using System.Collections.Generic;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.Context;

public partial class RealEstateDBContext : IdentityDbContext<User, Role, string>
{

    public virtual DbSet<Arsa> Arsalar { get; set; }

    public virtual DbSet<Daire> Daireler { get; set; }

    public virtual DbSet<Depo> Depolar { get; set; }

    public virtual DbSet<Dukkan> Dukkanlar { get; set; }

    public virtual DbSet<IlanTalepTipi> IlanTalepTipleri { get; set; }

    public virtual DbSet<Ilan> Ilanlar { get; set; }

    public virtual DbSet<Danisan> Danisanlar { get; set; }

    public virtual DbSet<Talep> Talepler { get; set; }

    public virtual DbSet<Tarla> Tarlalar { get; set; }

    public RealEstateDBContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=BERKE;Database=RealEstateDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Arsa>(entity =>
        {
            entity.ToTable("Arsa");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.ImarDurumu).HasColumnName("Imar durumu");
            entity.Property(e => e.MetrekareFiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaftaNo).HasColumnName("PaftaNo.");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");

        });

        modelBuilder.Entity<Daire>(entity =>
        {
            entity.ToTable("Daire");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Isıtma).HasMaxLength(50);
            entity.Property(e => e.KullanimDurumu).HasMaxLength(50);

            entity.HasOne(i => i.Ilan)
            .WithOne(a => a.Daire)
            .HasForeignKey<Daire>(a => a.Id);

        });

        modelBuilder.Entity<Depo>(entity =>
        {
            entity.ToTable("Depo");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");

            entity.HasOne(i => i.Ilan)
            .WithOne(a => a.Depo)
            .HasForeignKey<Depo>(a => a.Id);
        });

        modelBuilder.Entity<Dukkan>(entity =>
        {
            entity.ToTable("Dukkan");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Isıtma).HasMaxLength(50);
            entity.Property(e => e.KullanimDurumu).HasMaxLength(50);

            entity.HasOne(i => i.Ilan)
            .WithOne(a => a.Dukkan)
            .HasForeignKey<Dukkan>(a => a.Id);

        });

        modelBuilder.Entity<IlanTalepTipi>(entity =>
        {
            entity.ToTable("IlanTalepTipleri");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TipAdi).HasMaxLength(50);

        });

        modelBuilder.Entity<Ilan>(entity =>
        {
            entity.ToTable("Ilanlar");
            entity.HasKey(t => t.Id);

            entity.Property(e => e.Id).HasMaxLength(50);

            entity.Navigation("Arsa");

            entity.HasOne(i => i.Satici)
            .WithMany(s => s.Ilanlar)
            .HasForeignKey(i => i.SaticiId);

            entity.HasOne(i=>i.IlanTalepTipi)
            .WithMany(itt=>itt.Ilanlar)
            .HasForeignKey(i=>i.IlanTalepTipiId);

            entity.HasOne(i => i.Arsa)
            .WithOne(a => a.Ilan)
            .HasForeignKey<Arsa>(a => a.Id);

            entity.HasOne(i => i.Daire)
            .WithOne(a => a.Ilan)
            .HasForeignKey<Daire>(d => d.Id);

            entity.HasOne(i => i.Depo)
            .WithOne(a => a.Ilan)
            .HasForeignKey<Depo>(d => d.Id);

            entity.HasOne(i => i.Dukkan)
            .WithOne(a => a.Ilan)
            .HasForeignKey<Dukkan>(d => d.Id);

            entity.HasOne(i => i.Tarla)
            .WithOne(a => a.Ilan)
            .HasForeignKey<Tarla>(t => t.Id);


        });

        modelBuilder.Entity<Danisan>(entity =>
        {
            entity.ToTable("Danisanlar");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdSoyad).HasMaxLength(50);
            entity.Property(e => e.MailAdresi).HasMaxLength(50);
            entity.Property(e => e.TelefonNo)
                .HasMaxLength(50)
                .HasColumnName("TelefonNo.");

            entity.HasMany(d => d.Ilanlar)
            .WithOne(i => i.Satici)
            .HasForeignKey(i => i.SaticiId);
        });

        modelBuilder.Entity<Talep>(entity =>
        {
            entity.ToTable("Talepler");

            entity.Property(e => e.Id).HasMaxLength(50);

            entity.HasOne(t => t.IlanTalepTipi)
            .WithMany(itt=>itt.Talepler)
            .HasForeignKey(t => t.IlanTalepTipiId);
        });

        modelBuilder.Entity<Tarla>(entity =>
        {
            entity.ToTable("Tarla");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AdaNo).HasColumnName("AdaNo.");
            entity.Property(e => e.MetrekareFiyat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaftaNo).HasColumnName("PaftaNo.");
            entity.Property(e => e.ParselNo).HasColumnName("ParselNo.");

            entity.HasOne(i => i.Ilan)
            .WithOne(a => a.Tarla)
            .HasForeignKey<Tarla>(t => t.Id);

        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasMany(u => u.Danisanlar)
            .WithOne(s => s.User)
            .HasForeignKey(s => s.UserId);

            entity.HasMany(u => u.Ilanlar)
            .WithOne(i => i.User)
            .HasForeignKey(s => s.UserId);

            entity.HasMany(u => u.Talepler)
            .WithOne(t => t.User)
            .HasForeignKey(s => s.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
