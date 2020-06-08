using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace jatek_pont_net.Models
{
    public partial class jatek_pont_netContext : DbContext
    {
        public jatek_pont_netContext()
        {
        }

        public jatek_pont_netContext(DbContextOptions<jatek_pont_netContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ar> Ar { get; set; }
        public virtual DbSet<Beszallitas> Beszallitas { get; set; }
        public virtual DbSet<CsomagF> CsomagF { get; set; }
        public virtual DbSet<CsomagT> CsomagT { get; set; }
        public virtual DbSet<Felhasznalo> Felhasznalo { get; set; }
        public virtual DbSet<Funkcio> Funkcio { get; set; }
        public virtual DbSet<Gyarto> Gyarto { get; set; }
        public virtual DbSet<Jogosultsag> Jogosultsag { get; set; }
        public virtual DbSet<Kedvezmeny> Kedvezmeny { get; set; }
        public virtual DbSet<Keszlet> Keszlet { get; set; }
        public virtual DbSet<KimenoRendelesF> KimenoRendelesF { get; set; }
        public virtual DbSet<KimenoRendelesT> KimenoRendelesT { get; set; }
        public virtual DbSet<Mertekegyseg> Mertekegyseg { get; set; }
        public virtual DbSet<Orszag> Orszag { get; set; }
        public virtual DbSet<Preferencia> Preferencia { get; set; }
        public virtual DbSet<Raktar> Raktar { get; set; }
        public virtual DbSet<RaktarkoziMozgF> RaktarkoziMozgF { get; set; }
        public virtual DbSet<RaktarkoziMozgT> RaktarkoziMozgT { get; set; }
        public virtual DbSet<Reklamacio> Reklamacio { get; set; }
        public virtual DbSet<Szamla> Szamla { get; set; }
        public virtual DbSet<SzamlaTetelReszletekV> SzamlaTetelReszletekV { get; set; }
        public virtual DbSet<SzamlaV> SzamlaV { get; set; }
        public virtual DbSet<SzlevF> SzlevF { get; set; }
        public virtual DbSet<SzlevT> SzlevT { get; set; }
        public virtual DbSet<Termek> Termek { get; set; }
        public virtual DbSet<TermekV> TermekV { get; set; }
        public virtual DbSet<Termekcsoport> Termekcsoport { get; set; }
        public virtual DbSet<Termekmert> Termekmert { get; set; }
        public virtual DbSet<Ugyfel> Ugyfel { get; set; }
        public virtual DbSet<VevoiRendelesAdatokV> VevoiRendelesAdatokV { get; set; }
        public virtual DbSet<VevoiRendelesF> VevoiRendelesF { get; set; }
        public virtual DbSet<VevoiRendelesT> VevoiRendelesT { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=RAJ\\ROKA;Initial Catalog=jatek_pont_net;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ar>(entity =>
            {
                entity.ToTable("AR");

                entity.HasIndex(e => new { e.Termek, e.ErvKezd })
                    .HasName("AR_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ar1)
                    .HasColumnName("AR")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.ErvKezd)
                    .HasColumnName("ERV_KEZD")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErvVeg)
                    .HasColumnName("ERV_VEG")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Termek).HasColumnName("TERMEK");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.TermekNavigation)
                    .WithMany(p => p.Ar)
                    .HasForeignKey(d => d.Termek)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AR_FK1");
            });

            modelBuilder.Entity<Beszallitas>(entity =>
            {
                entity.ToTable("BESZALLITAS");

                entity.HasIndex(e => new { e.BevDat, e.KimenoRendT, e.Sorszam })
                    .HasName("BESZALLITAS_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BevDat)
                    .HasColumnName("BEV_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hivszam)
                    .IsRequired()
                    .HasColumnName("HIVSZAM")
                    .HasMaxLength(20);

                entity.Property(e => e.KimenoRendT).HasColumnName("KIMENO_REND_T");

                entity.Property(e => e.Menny)
                    .HasColumnName("MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.KimenoRendTNavigation)
                    .WithMany(p => p.Beszallitas)
                    .HasForeignKey(d => d.KimenoRendT)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BESZALLITAS_FK1");
            });

            modelBuilder.Entity<CsomagF>(entity =>
            {
                entity.ToTable("CSOMAG_F");

                entity.HasIndex(e => e.Kod)
                    .HasName("CSOMAG_F_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.Raktar).HasColumnName("RAKTAR");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.SzallHatarido)
                    .HasColumnName("SZALL_HATARIDO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Szamla).HasColumnName("SZAMLA");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.RaktarNavigation)
                    .WithMany(p => p.CsomagF)
                    .HasForeignKey(d => d.Raktar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CSOMAG_F_FK1");

                entity.HasOne(d => d.SzamlaNavigation)
                    .WithMany(p => p.CsomagF)
                    .HasForeignKey(d => d.Szamla)
                    .HasConstraintName("CSOMAG_F_FK2");
            });

            modelBuilder.Entity<CsomagT>(entity =>
            {
                entity.ToTable("CSOMAG_T");

                entity.HasIndex(e => new { e.VevoiRendT, e.CsomagF })
                    .HasName("CSOMAG_T_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.CsomagF).HasColumnName("CSOMAG_F");

                entity.Property(e => e.Kedvezmeny).HasColumnName("KEDVEZMENY");

                entity.Property(e => e.Menny)
                    .HasColumnName("MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.Property(e => e.VevoiRendT).HasColumnName("VEVOI_REND_T");

                entity.HasOne(d => d.CsomagFNavigation)
                    .WithMany(p => p.CsomagT)
                    .HasForeignKey(d => d.CsomagF)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CSOMAG_T_FK2");

                entity.HasOne(d => d.KedvezmenyNavigation)
                    .WithMany(p => p.CsomagT)
                    .HasForeignKey(d => d.Kedvezmeny)
                    .HasConstraintName("CSOMAG_T_FK3");

                entity.HasOne(d => d.VevoiRendTNavigation)
                    .WithMany(p => p.CsomagT)
                    .HasForeignKey(d => d.VevoiRendT)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CSOMAG_T_FK1");
            });

            modelBuilder.Entity<Felhasznalo>(entity =>
            {
                entity.ToTable("FELHASZNALO");

                entity.HasIndex(e => e.Kod)
                    .HasName("FELHASZNALO_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Felettes).HasColumnName("FELETTES");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasColumnName("NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Statusz)
                    .IsRequired()
                    .HasColumnName("STATUSZ")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.FelettesNavigation)
                    .WithMany(p => p.InverseFelettesNavigation)
                    .HasForeignKey(d => d.Felettes)
                    .HasConstraintName("FELHASZNALO_FK1");
            });

            modelBuilder.Entity<Funkcio>(entity =>
            {
                entity.ToTable("FUNKCIO");

                entity.HasIndex(e => e.Kod)
                    .HasName("FUNKCIO_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.Leiras)
                    .IsRequired()
                    .HasColumnName("LEIRAS")
                    .HasMaxLength(100);

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Gyarto>(entity =>
            {
                entity.ToTable("GYARTO");

                entity.HasIndex(e => e.Kod)
                    .HasName("GYARTO_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cim)
                    .IsRequired()
                    .HasColumnName("CIM")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Kapcsolattarto).HasColumnName("KAPCSOLATTARTO");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasColumnName("NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.Orszag).HasColumnName("ORSZAG");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.KapcsolattartoNavigation)
                    .WithMany(p => p.Gyarto)
                    .HasForeignKey(d => d.Kapcsolattarto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GYARTO_FK1");

                entity.HasOne(d => d.OrszagNavigation)
                    .WithMany(p => p.Gyarto)
                    .HasForeignKey(d => d.Orszag)
                    .HasConstraintName("GYARTO_FK2");
            });

            modelBuilder.Entity<Jogosultsag>(entity =>
            {
                entity.ToTable("JOGOSULTSAG");

                entity.HasIndex(e => new { e.Felhasznalo, e.Funkcio })
                    .HasName("JOGOSULTSAG_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Felhasznalo).HasColumnName("FELHASZNALO");

                entity.Property(e => e.Funkcio).HasColumnName("FUNKCIO");

                entity.Property(e => e.HozzaferesKezd)
                    .HasColumnName("HOZZAFERES_KEZD")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HozzaferesVeg)
                    .HasColumnName("HOZZAFERES_VEG")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.FelhasznaloNavigation)
                    .WithMany(p => p.Jogosultsag)
                    .HasForeignKey(d => d.Felhasznalo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("JOGOSULTSAG_FK1");

                entity.HasOne(d => d.FunkcioNavigation)
                    .WithMany(p => p.Jogosultsag)
                    .HasForeignKey(d => d.Funkcio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("JOGOSULTSAG_FK2");
            });

            modelBuilder.Entity<Kedvezmeny>(entity =>
            {
                entity.ToTable("KEDVEZMENY");

                entity.HasIndex(e => e.Kod)
                    .HasName("KEDVEZMENY_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErvKezd)
                    .HasColumnName("ERV_KEZD")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErvVeg)
                    .HasColumnName("ERV_VEG")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Szazalek)
                    .HasColumnName("SZAZALEK")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Termekcsoport).HasColumnName("TERMEKCSOPORT");

                entity.Property(e => e.Ugyfel).HasColumnName("UGYFEL");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.TermekcsoportNavigation)
                    .WithMany(p => p.Kedvezmeny)
                    .HasForeignKey(d => d.Termekcsoport)
                    .HasConstraintName("KEDVEZMENY_FK1");

                entity.HasOne(d => d.UgyfelNavigation)
                    .WithMany(p => p.Kedvezmeny)
                    .HasForeignKey(d => d.Ugyfel)
                    .HasConstraintName("KEDVEZMENY_FK2");
            });

            modelBuilder.Entity<Keszlet>(entity =>
            {
                entity.ToTable("KESZLET");

                entity.HasIndex(e => new { e.Termek, e.Raktar })
                    .HasName("KESZLET_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Menny)
                    .HasColumnName("MENNY")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Mertekegyseg).HasColumnName("MERTEKEGYSEG");

                entity.Property(e => e.Raktar).HasColumnName("RAKTAR");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Termek).HasColumnName("TERMEK");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.RaktarNavigation)
                    .WithMany(p => p.Keszlet)
                    .HasForeignKey(d => d.Raktar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("KESZLET_FK2");

                entity.HasOne(d => d.Termekmert)
                    .WithMany(p => p.Keszlet)
                    .HasPrincipalKey(p => new { p.Termek, p.Mertekegyseg })
                    .HasForeignKey(d => new { d.Termek, d.Mertekegyseg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("KESZLET_FK1");
            });

            modelBuilder.Entity<KimenoRendelesF>(entity =>
            {
                entity.ToTable("KIMENO_RENDELES_F");

                entity.HasIndex(e => e.Hivszam)
                    .HasName("KIMENO_RENDELES_F_UK")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.ElkuldDatum)
                    .HasColumnName("ELKULD_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gyarto).HasColumnName("GYARTO");

                entity.Property(e => e.Hivszam)
                    .IsRequired()
                    .HasColumnName("HIVSZAM")
                    .HasMaxLength(20);

                entity.Property(e => e.Megj)
                    .HasColumnName("MEGJ")
                    .HasMaxLength(200);

                entity.Property(e => e.Raktar).HasColumnName("RAKTAR");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.TeljDatum)
                    .HasColumnName("TELJ_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.GyartoNavigation)
                    .WithMany(p => p.KimenoRendelesF)
                    .HasForeignKey(d => d.Gyarto)
                    .HasConstraintName("KIMENO_RENDELES_F_FK1");

                entity.HasOne(d => d.RaktarNavigation)
                    .WithMany(p => p.KimenoRendelesF)
                    .HasForeignKey(d => d.Raktar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("KIMENO_RENDELES_F_FK2");
            });

            modelBuilder.Entity<KimenoRendelesT>(entity =>
            {
                entity.ToTable("KIMENO_RENDELES_T");

                entity.HasIndex(e => new { e.KimenoRendF, e.Termek })
                    .HasName("KIMENO_RENDELES_T_UK")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.KimenoRendF).HasColumnName("KIMENO_REND_F");

                entity.Property(e => e.Menny)
                    .HasColumnName("MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Mertekegyseg).HasColumnName("MERTEKEGYSEG");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");

                entity.Property(e => e.TeljDatum)
                    .HasColumnName("TELJ_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.TeljMenny)
                    .HasColumnName("TELJ_MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Termek).HasColumnName("TERMEK");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.KimenoRendFNavigation)
                    .WithMany(p => p.KimenoRendelesT)
                    .HasForeignKey(d => d.KimenoRendF)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("KIMENO_RENDELES_T_FK1");

                entity.HasOne(d => d.Termekmert)
                    .WithMany(p => p.KimenoRendelesT)
                    .HasPrincipalKey(p => new { p.Termek, p.Mertekegyseg })
                    .HasForeignKey(d => new { d.Termek, d.Mertekegyseg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("KIMENO_RENDELES_T_FK2");
            });

            modelBuilder.Entity<Mertekegyseg>(entity =>
            {
                entity.ToTable("MERTEKEGYSEG");

                entity.HasIndex(e => e.Kod)
                    .HasName("MERTEKEGYSEG_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(6);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasColumnName("NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Orszag>(entity =>
            {
                entity.ToTable("ORSZAG");

                entity.HasIndex(e => e.Kod2)
                    .HasName("ORSZAG_UK1")
                    .IsUnique();

                entity.HasIndex(e => e.Kod3)
                    .HasName("ORSZAG_UK2")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kod2)
                    .IsRequired()
                    .HasColumnName("KOD2")
                    .HasMaxLength(2);

                entity.Property(e => e.Kod3)
                    .IsRequired()
                    .HasColumnName("KOD3")
                    .HasMaxLength(3);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasColumnName("NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Preferencia>(entity =>
            {
                entity.ToTable("PREFERENCIA");

                entity.HasIndex(e => e.Kod)
                    .HasName("PREFERENCIA_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ertek)
                    .HasColumnName("ERTEK")
                    .HasMaxLength(100);

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasColumnName("NEV")
                    .HasMaxLength(200);

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Raktar>(entity =>
            {
                entity.ToTable("RAKTAR");

                entity.HasIndex(e => e.Kod)
                    .HasName("RAKTAR_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cim)
                    .IsRequired()
                    .HasColumnName("CIM")
                    .HasMaxLength(100);

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(10);

                entity.Property(e => e.Leiras)
                    .IsRequired()
                    .HasColumnName("LEIRAS")
                    .HasMaxLength(100);

                entity.Property(e => e.Orszag).HasColumnName("ORSZAG");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Statusz)
                    .IsRequired()
                    .HasColumnName("STATUSZ")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Tipus)
                    .IsRequired()
                    .HasColumnName("TIPUS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('F')");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.OrszagNavigation)
                    .WithMany(p => p.Raktar)
                    .HasForeignKey(d => d.Orszag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RAKTAR_FK1");
            });

            modelBuilder.Entity<RaktarkoziMozgF>(entity =>
            {
                entity.ToTable("RAKTARKOZI_MOZG_F");

                entity.HasIndex(e => e.Hivszam)
                    .HasName("RAKTARKOZI_MOZG_F_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.Hivszam)
                    .IsRequired()
                    .HasColumnName("HIVSZAM")
                    .HasMaxLength(20);

                entity.Property(e => e.Honnan).HasColumnName("HONNAN");

                entity.Property(e => e.Hova).HasColumnName("HOVA");

                entity.Property(e => e.KezdDatum)
                    .HasColumnName("KEZD_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.TeljDatum)
                    .HasColumnName("TELJ_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.HonnanNavigation)
                    .WithMany(p => p.RaktarkoziMozgFHonnanNavigation)
                    .HasForeignKey(d => d.Honnan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RAKTARKOZI_MOZG_F_FK1");

                entity.HasOne(d => d.HovaNavigation)
                    .WithMany(p => p.RaktarkoziMozgFHovaNavigation)
                    .HasForeignKey(d => d.Hova)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RAKTARKOZI_MOZG_F_FK2");
            });

            modelBuilder.Entity<RaktarkoziMozgT>(entity =>
            {
                entity.ToTable("RAKTARKOZI_MOZG_T");

                entity.HasIndex(e => new { e.RaktarkoziMozgF, e.Termek })
                    .HasName("RAKTARKOZI_MOZG_T_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Menny)
                    .HasColumnName("MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Mertekegyseg).HasColumnName("MERTEKEGYSEG");

                entity.Property(e => e.RaktarkoziMozgF).HasColumnName("RAKTARKOZI_MOZG_F");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");

                entity.Property(e => e.Termek).HasColumnName("TERMEK");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.RaktarkoziMozgFNavigation)
                    .WithMany(p => p.RaktarkoziMozgT)
                    .HasForeignKey(d => d.RaktarkoziMozgF)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RAKTARKOZI_MOZG_T_FK1");

                entity.HasOne(d => d.Termekmert)
                    .WithMany(p => p.RaktarkoziMozgT)
                    .HasPrincipalKey(p => new { p.Termek, p.Mertekegyseg })
                    .HasForeignKey(d => new { d.Termek, d.Mertekegyseg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RAKTARKOZI_MOZG_T_FK2");
            });

            modelBuilder.Entity<Reklamacio>(entity =>
            {
                entity.ToTable("REKLAMACIO");

                entity.HasIndex(e => new { e.VevoiRendT, e.VevoiRendFRekl })
                    .HasName("REKLAMACIO_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.Property(e => e.VevoiRendFRekl).HasColumnName("VEVOI_REND_F_REKL");

                entity.Property(e => e.VevoiRendT).HasColumnName("VEVOI_REND_T");

                entity.HasOne(d => d.VevoiRendFReklNavigation)
                    .WithMany(p => p.Reklamacio)
                    .HasForeignKey(d => d.VevoiRendFRekl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("REKLAMACIO_FK2");

                entity.HasOne(d => d.VevoiRendTNavigation)
                    .WithMany(p => p.Reklamacio)
                    .HasForeignKey(d => d.VevoiRendT)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("REKLAMACIO_FK1");
            });

            modelBuilder.Entity<Szamla>(entity =>
            {
                entity.ToTable("SZAMLA");

                entity.HasIndex(e => e.Szlaszam)
                    .HasName("SZAMLA_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.KiallDatum)
                    .HasColumnName("KIALL_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Megrendelo).HasColumnName("MEGRENDELO");

                entity.Property(e => e.Osszeg)
                    .HasColumnName("OSSZEG")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Szlaszam).HasColumnName("SZLASZAM");

                entity.Property(e => e.TeljDatum)
                    .HasColumnName("TELJ_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.MegrendeloNavigation)
                    .WithMany(p => p.Szamla)
                    .HasForeignKey(d => d.Megrendelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SZAMLA_FK1");
            });

            modelBuilder.Entity<SzamlaTetelReszletekV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SZAMLA_TETEL_RESZLETEK_V");

                entity.Property(e => e.CsomagFejKod)
                    .IsRequired()
                    .HasColumnName("CSOMAG_FEJ_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.CsomagTetelKedvezmenyezettAr)
                    .HasColumnName("CSOMAG_TETEL_KEDVEZMENYEZETT_AR")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CsomagTetelMenny)
                    .HasColumnName("CSOMAG_TETEL_MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.KedvezmenySzazalek)
                    .HasColumnName("KEDVEZMENY_SZAZALEK")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.KedvezmenyezettTermekcsoportKod)
                    .HasColumnName("KEDVEZMENYEZETT_TERMEKCSOPORT_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.KedvezmenyezettUgyfelKod)
                    .HasColumnName("KEDVEZMENYEZETT_UGYFEL_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.MegrendeloKod)
                    .IsRequired()
                    .HasColumnName("MEGRENDELO_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.MegrendeloNev)
                    .IsRequired()
                    .HasColumnName("MEGRENDELO_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.MertekegysegKod)
                    .IsRequired()
                    .HasColumnName("MERTEKEGYSEG_KOD")
                    .HasMaxLength(6);

                entity.Property(e => e.MertekegysegNev)
                    .IsRequired()
                    .HasColumnName("MERTEKEGYSEG_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.RaktarKod)
                    .IsRequired()
                    .HasColumnName("RAKTAR_KOD")
                    .HasMaxLength(10);

                entity.Property(e => e.RaktarLeiras)
                    .IsRequired()
                    .HasColumnName("RAKTAR_LEIRAS")
                    .HasMaxLength(100);

                entity.Property(e => e.SzamlaAllapot)
                    .HasColumnName("SZAMLA_ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.SzamlaId).HasColumnName("SZAMLA_ID");

                entity.Property(e => e.SzamlaKiallDatum)
                    .HasColumnName("SZAMLA_KIALL_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.SzamlaOsszeg)
                    .HasColumnName("SZAMLA_OSSZEG")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.SzamlaSzamlaszam).HasColumnName("SZAMLA_SZAMLASZAM");

                entity.Property(e => e.SzamlaTeljDatum)
                    .HasColumnName("SZAMLA_TELJ_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.TermekEgysegar)
                    .HasColumnName("TERMEK_EGYSEGAR")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.TermekKod)
                    .IsRequired()
                    .HasColumnName("TERMEK_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.TermekNev)
                    .IsRequired()
                    .HasColumnName("TERMEK_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.VevoiRendelesFejAllapot)
                    .IsRequired()
                    .HasColumnName("VEVOI_RENDELES_FEJ_ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.VevoiRendelesFejBeerkDat)
                    .HasColumnName("VEVOI_RENDELES_FEJ_BEERK_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VevoiRendelesFejHivszam)
                    .IsRequired()
                    .HasColumnName("VEVOI_RENDELES_FEJ_HIVSZAM")
                    .HasMaxLength(20);

                entity.Property(e => e.VevoiRendelesFejTeljDat)
                    .HasColumnName("VEVOI_RENDELES_FEJ_TELJ_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VevoiRendelesTetelCsomagoltMenny)
                    .HasColumnName("VEVOI_RENDELES_TETEL_CSOMAGOLT_MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.VevoiRendelesTetelMenny)
                    .HasColumnName("VEVOI_RENDELES_TETEL_MENNY")
                    .HasColumnType("numeric(15, 3)");
            });

            modelBuilder.Entity<SzamlaV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SZAMLA_V");

                entity.Property(e => e.CsomagFejKod)
                    .IsRequired()
                    .HasColumnName("CSOMAG_FEJ_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.CsomagFejSzallHatarido)
                    .HasColumnName("CSOMAG_FEJ_SZALL_HATARIDO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FutarKod)
                    .HasColumnName("FUTAR_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.FutarNev)
                    .HasColumnName("FUTAR_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.MegrendeloKod)
                    .IsRequired()
                    .HasColumnName("MEGRENDELO_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.MegrendeloNev)
                    .IsRequired()
                    .HasColumnName("MEGRENDELO_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.RaktarCim)
                    .IsRequired()
                    .HasColumnName("RAKTAR_CIM")
                    .HasMaxLength(100);

                entity.Property(e => e.RaktarKod)
                    .IsRequired()
                    .HasColumnName("RAKTAR_KOD")
                    .HasMaxLength(10);

                entity.Property(e => e.RaktarLeiras)
                    .IsRequired()
                    .HasColumnName("RAKTAR_LEIRAS")
                    .HasMaxLength(100);

                entity.Property(e => e.SzamlaAllapot)
                    .HasColumnName("SZAMLA_ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.SzamlaId).HasColumnName("SZAMLA_ID");

                entity.Property(e => e.SzamlaKiallDatum)
                    .HasColumnName("SZAMLA_KIALL_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.SzamlaOsszeg)
                    .HasColumnName("SZAMLA_OSSZEG")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.SzamlaSzlaszam).HasColumnName("SZAMLA_SZLASZAM");

                entity.Property(e => e.SzamlaTeljDatum)
                    .HasColumnName("SZAMLA_TELJ_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.SzlevFAllapot)
                    .HasColumnName("SZLEV_F_ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.SzlevFAtadDat)
                    .HasColumnName("SZLEV_F_ATAD_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.SzlevFHivszam)
                    .HasColumnName("SZLEV_F_HIVSZAM")
                    .HasMaxLength(20);

                entity.Property(e => e.SzlevTAllapot)
                    .HasColumnName("SZLEV_T_ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.SzlevTSorszam).HasColumnName("SZLEV_T_SORSZAM");
            });

            modelBuilder.Entity<SzlevF>(entity =>
            {
                entity.ToTable("SZLEV_F");

                entity.HasIndex(e => e.Hivszam)
                    .HasName("SZLEV_F_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.AtadDat)
                    .HasColumnName("ATAD_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Futar).HasColumnName("FUTAR");

                entity.Property(e => e.Hivszam)
                    .IsRequired()
                    .HasColumnName("HIVSZAM")
                    .HasMaxLength(20);

                entity.Property(e => e.KiallDat)
                    .HasColumnName("KIALL_DAT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.TeljDat)
                    .HasColumnName("TELJ_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.Property(e => e.VisszavDat)
                    .HasColumnName("VISSZAV_DAT")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.FutarNavigation)
                    .WithMany(p => p.SzlevF)
                    .HasForeignKey(d => d.Futar)
                    .HasConstraintName("SZLEV_F_FK1");
            });

            modelBuilder.Entity<SzlevT>(entity =>
            {
                entity.ToTable("SZLEV_T");

                entity.HasIndex(e => e.CsomagF)
                    .HasName("SZLEV_T_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.CsomagF).HasColumnName("CSOMAG_F");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");

                entity.Property(e => e.SzlevF).HasColumnName("SZLEV_F");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.CsomagFNavigation)
                    .WithOne(p => p.SzlevT)
                    .HasForeignKey<SzlevT>(d => d.CsomagF)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SZLEV_T_FK1");

                entity.HasOne(d => d.SzlevFNavigation)
                    .WithMany(p => p.SzlevT)
                    .HasForeignKey(d => d.SzlevF)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SZLEV_T_FK2");
            });

            modelBuilder.Entity<Termek>(entity =>
            {
                entity.ToTable("TERMEK");

                entity.HasIndex(e => e.Kod)
                    .HasName("TERMEK_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.GyartasKezd)
                    .HasColumnName("GYARTAS_KEZD")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GyartasVeg)
                    .HasColumnName("GYARTAS_VEG")
                    .HasColumnType("datetime");

                entity.Property(e => e.GyartasiOrszag).HasColumnName("GYARTASI_ORSZAG");

                entity.Property(e => e.Gyarto).HasColumnName("GYARTO");

                entity.Property(e => e.IdealisRendszer)
                    .HasColumnName("IDEALIS_RENDSZER")
                    .HasMaxLength(2000);

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.MinKovetelmeny)
                    .HasColumnName("MIN_KOVETELMENY")
                    .HasMaxLength(2000);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasColumnName("NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.Ostermek).HasColumnName("OSTERMEK");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Tcsoport).HasColumnName("TCSOPORT");

                entity.Property(e => e.Tipus)
                    .IsRequired()
                    .HasColumnName("TIPUS")
                    .HasMaxLength(1);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.GyartasiOrszagNavigation)
                    .WithMany(p => p.Termek)
                    .HasForeignKey(d => d.GyartasiOrszag)
                    .HasConstraintName("TERMEK_FK4");

                entity.HasOne(d => d.GyartoNavigation)
                    .WithMany(p => p.Termek)
                    .HasForeignKey(d => d.Gyarto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TERMEK_FK3");

                entity.HasOne(d => d.OstermekNavigation)
                    .WithMany(p => p.InverseOstermekNavigation)
                    .HasForeignKey(d => d.Ostermek)
                    .HasConstraintName("TERMEK_FK2");

                entity.HasOne(d => d.TcsoportNavigation)
                    .WithMany(p => p.Termek)
                    .HasForeignKey(d => d.Tcsoport)
                    .HasConstraintName("TERMEK_FK5");
            });

            modelBuilder.Entity<TermekV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TERMEK_V");

                entity.Property(e => e.GyartasiOrszagKod)
                    .HasColumnName("GYARTASI_ORSZAG_KOD")
                    .HasMaxLength(2);

                entity.Property(e => e.GyartasiOrszagNev)
                    .HasColumnName("GYARTASI_ORSZAG_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.GyartoKod)
                    .IsRequired()
                    .HasColumnName("GYARTO_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.GyartoNev)
                    .IsRequired()
                    .HasColumnName("GYARTO_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.KeszletMenny)
                    .HasColumnName("KESZLET_MENNY")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.KeszletMertekegysegKod)
                    .HasColumnName("KESZLET_MERTEKEGYSEG_KOD")
                    .HasMaxLength(6);

                entity.Property(e => e.KeszletMertekegysegNev)
                    .HasColumnName("KESZLET_MERTEKEGYSEG_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.OstermekKod)
                    .HasColumnName("OSTERMEK_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.OstermekNev)
                    .HasColumnName("OSTERMEK_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.RaktarKod)
                    .HasColumnName("RAKTAR_KOD")
                    .HasMaxLength(10);

                entity.Property(e => e.RaktarLeiras)
                    .HasColumnName("RAKTAR_LEIRAS")
                    .HasMaxLength(100);

                entity.Property(e => e.RaktarOrszagKod)
                    .HasColumnName("RAKTAR_ORSZAG_KOD")
                    .HasMaxLength(2);

                entity.Property(e => e.RaktarOrszagNev)
                    .HasColumnName("RAKTAR_ORSZAG_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.TermekGyartasKezd)
                    .HasColumnName("TERMEK_GYARTAS_KEZD")
                    .HasColumnType("datetime");

                entity.Property(e => e.TermekGyartasVeg)
                    .HasColumnName("TERMEK_GYARTAS_VEG")
                    .HasColumnType("datetime");

                entity.Property(e => e.TermekId).HasColumnName("TERMEK_ID");

                entity.Property(e => e.TermekKod)
                    .IsRequired()
                    .HasColumnName("TERMEK_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.TermekNev)
                    .IsRequired()
                    .HasColumnName("TERMEK_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.TermekTipus)
                    .HasColumnName("TERMEK_TIPUS")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TermekcsoportKod)
                    .HasColumnName("TERMEKCSOPORT_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.TermekcsoportNev)
                    .HasColumnName("TERMEKCSOPORT_NEV")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Termekcsoport>(entity =>
            {
                entity.ToTable("TERMEKCSOPORT");

                entity.HasIndex(e => e.Kod)
                    .HasName("TERMEKCSOPORT_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasColumnName("NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Termekmert>(entity =>
            {
                entity.ToTable("TERMEKMERT");

                entity.HasIndex(e => new { e.Termek, e.Mertekegyseg })
                    .HasName("TERMEKMERT_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alape)
                    .IsRequired()
                    .HasColumnName("ALAPE")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.Mertekegyseg).HasColumnName("MERTEKEGYSEG");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Szorzo)
                    .HasColumnName("SZORZO")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Termek).HasColumnName("TERMEK");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.MertekegysegNavigation)
                    .WithMany(p => p.Termekmert)
                    .HasForeignKey(d => d.Mertekegyseg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TERMEKMERT_FK2");

                entity.HasOne(d => d.TermekNavigation)
                    .WithMany(p => p.Termekmert)
                    .HasForeignKey(d => d.Termek)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TERMEKMERT_FK1");
            });

            modelBuilder.Entity<Ugyfel>(entity =>
            {
                entity.ToTable("UGYFEL");

                entity.HasIndex(e => e.Kod)
                    .HasName("UGYFEL_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cim)
                    .IsRequired()
                    .HasColumnName("CIM")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(20);

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasColumnName("KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.Mobil)
                    .HasColumnName("MOBIL")
                    .HasMaxLength(20);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasColumnName("NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .HasColumnName("TELEFON")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipus)
                    .HasColumnName("TIPUS")
                    .HasMaxLength(1);

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<VevoiRendelesAdatokV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VEVOI_RENDELES_ADATOK_V");

                entity.Property(e => e.CsomagFejKod)
                    .HasColumnName("CSOMAG_FEJ_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.CsomagTetelKedvezmenyezettAr)
                    .HasColumnName("CSOMAG_TETEL_KEDVEZMENYEZETT_AR")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CsomagTetelMenny)
                    .HasColumnName("CSOMAG_TETEL_MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.FutarKod)
                    .HasColumnName("FUTAR_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.FutarNev)
                    .HasColumnName("FUTAR_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.GyartoOrszagKod)
                    .HasColumnName("GYARTO_ORSZAG_KOD")
                    .HasMaxLength(2);

                entity.Property(e => e.GyartoOrszagNev)
                    .HasColumnName("GYARTO_ORSZAG_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.KedvezmenySzazalek)
                    .HasColumnName("KEDVEZMENY_SZAZALEK")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.KedvezmenyezettTermekcsoportKod)
                    .HasColumnName("KEDVEZMENYEZETT_TERMEKCSOPORT_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.KedvezmenyezettUgyfelKod)
                    .HasColumnName("KEDVEZMENYEZETT_UGYFEL_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.MegrendeloKod)
                    .IsRequired()
                    .HasColumnName("MEGRENDELO_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.MegrendeloNev)
                    .IsRequired()
                    .HasColumnName("MEGRENDELO_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.MertekegysegKod)
                    .IsRequired()
                    .HasColumnName("MERTEKEGYSEG_KOD")
                    .HasMaxLength(6);

                entity.Property(e => e.MertekegysegNev)
                    .IsRequired()
                    .HasColumnName("MERTEKEGYSEG_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.RaktarKod)
                    .HasColumnName("RAKTAR_KOD")
                    .HasMaxLength(10);

                entity.Property(e => e.RaktarLeiras)
                    .HasColumnName("RAKTAR_LEIRAS")
                    .HasMaxLength(100);

                entity.Property(e => e.SzamlaAllapot)
                    .HasColumnName("SZAMLA_ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.SzamlaKiallDatum)
                    .HasColumnName("SZAMLA_KIALL_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.SzamlaOsszeg)
                    .HasColumnName("SZAMLA_OSSZEG")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.SzamlaSzamlaszam).HasColumnName("SZAMLA_SZAMLASZAM");

                entity.Property(e => e.SzamlaTeljDatum)
                    .HasColumnName("SZAMLA_TELJ_DATUM")
                    .HasColumnType("datetime");

                entity.Property(e => e.SzamlaUgyfelKod)
                    .HasColumnName("SZAMLA_UGYFEL_KOD")
                    .HasMaxLength(30);

                entity.Property(e => e.SzamlaUgyfelNev)
                    .HasColumnName("SZAMLA_UGYFEL_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.TermekEgysegar)
                    .HasColumnName("TERMEK_EGYSEGAR")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.TermekGyartoKod)
                    .IsRequired()
                    .HasColumnName("TERMEK_GYARTO_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.TermekGyartoNev)
                    .IsRequired()
                    .HasColumnName("TERMEK_GYARTO_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.TermekKod)
                    .IsRequired()
                    .HasColumnName("TERMEK_KOD")
                    .HasMaxLength(20);

                entity.Property(e => e.TermekNev)
                    .IsRequired()
                    .HasColumnName("TERMEK_NEV")
                    .HasMaxLength(100);

                entity.Property(e => e.VevoiRendelesFejAllapot)
                    .IsRequired()
                    .HasColumnName("VEVOI_RENDELES_FEJ_ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.VevoiRendelesFejBeerkDat)
                    .HasColumnName("VEVOI_RENDELES_FEJ_BEERK_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VevoiRendelesFejHivszam)
                    .IsRequired()
                    .HasColumnName("VEVOI_RENDELES_FEJ_HIVSZAM")
                    .HasMaxLength(20);

                entity.Property(e => e.VevoiRendelesFejId).HasColumnName("VEVOI_RENDELES_FEJ_ID");

                entity.Property(e => e.VevoiRendelesFejTeljDat)
                    .HasColumnName("VEVOI_RENDELES_FEJ_TELJ_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VevoiRendelesTetelCsomagoltMenny)
                    .HasColumnName("VEVOI_RENDELES_TETEL_CSOMAGOLT_MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.VevoiRendelesTetelId).HasColumnName("VEVOI_RENDELES_TETEL_ID");

                entity.Property(e => e.VevoiRendelesTetelMenny)
                    .HasColumnName("VEVOI_RENDELES_TETEL_MENNY")
                    .HasColumnType("numeric(15, 3)");
            });

            modelBuilder.Entity<VevoiRendelesF>(entity =>
            {
                entity.ToTable("VEVOI_RENDELES_F");

                entity.HasIndex(e => e.Hivszam)
                    .HasName("VEVOI_RENDELES_F_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.BeerkDat)
                    .HasColumnName("BEERK_DAT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hivszam)
                    .IsRequired()
                    .HasColumnName("HIVSZAM")
                    .HasMaxLength(20);

                entity.Property(e => e.Megrendelo).HasColumnName("MEGRENDELO");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.TeljDat)
                    .HasColumnName("TELJ_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.HasOne(d => d.MegrendeloNavigation)
                    .WithMany(p => p.VevoiRendelesF)
                    .HasForeignKey(d => d.Megrendelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("VEVOI_RENDELES_F_FK1");
            });

            modelBuilder.Entity<VevoiRendelesT>(entity =>
            {
                entity.ToTable("VEVOI_RENDELES_T");

                entity.HasIndex(e => new { e.VevoiRendF, e.Termek })
                    .HasName("VEVOI_RENDELES_T_UK1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allapot)
                    .IsRequired()
                    .HasColumnName("ALLAPOT")
                    .HasMaxLength(1);

                entity.Property(e => e.CsomagoltMenny)
                    .HasColumnName("CSOMAGOLT_MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Menny)
                    .HasColumnName("MENNY")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Mertekegyseg).HasColumnName("MERTEKEGYSEG");

                entity.Property(e => e.Rkd)
                    .HasColumnName("RKD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rkf)
                    .HasColumnName("RKF")
                    .HasMaxLength(30);

                entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");

                entity.Property(e => e.Termek).HasColumnName("TERMEK");

                entity.Property(e => e.Umd)
                    .HasColumnName("UMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Umf)
                    .HasColumnName("UMF")
                    .HasMaxLength(30);

                entity.Property(e => e.VevoiRendF).HasColumnName("VEVOI_REND_F");

                entity.HasOne(d => d.VevoiRendFNavigation)
                    .WithMany(p => p.VevoiRendelesT)
                    .HasForeignKey(d => d.VevoiRendF)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("VEVOI_RENDELES_T_FK1");

                entity.HasOne(d => d.Termekmert)
                    .WithMany(p => p.VevoiRendelesT)
                    .HasPrincipalKey(p => new { p.Termek, p.Mertekegyseg })
                    .HasForeignKey(d => new { d.Termek, d.Mertekegyseg })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("VEVOI_RENDELES_T_FK2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
