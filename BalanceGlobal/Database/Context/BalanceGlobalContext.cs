using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BalanceGlobal.Database.Tables;

namespace BalanceGlobal.Database.Context
{
    public partial class BalanceGlobalContext : DbContext
    {
        public BalanceGlobalContext()
        {
        }

        public BalanceGlobalContext(DbContextOptions<BalanceGlobalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Periodos> Periodos { get; set; }
        public virtual DbSet<Porteos> Porteos { get; set; }
        public virtual DbSet<Sistemas> Sistemas { get; set; }
        public virtual DbSet<SistemasSubSistemas> SistemasSubSistemas { get; set; }
        public virtual DbSet<Subsistemas> Subsistemas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=sqm-sql-srv.database.windows.net;Database=BalanceGlobal_des;User id=geovalidata;Password=geova1C2f3S@12@;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Periodos>(entity =>
            {
                entity.HasKey(e => e.IdPeriodos)
                    .HasName("PK_Periodos_IdPeriodos");

                entity.HasIndex(e => e.Periodo)
                    .HasName("UK_Periodos_Periodo")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Porteos>(entity =>
            {
                entity.HasKey(e => e.IdPorteos)
                    .HasName("PK_IdPorteos");

                entity.HasIndex(e => new { e.IdSistemasSubsistemas, e.FechaHora })
                    .HasName("UK_Porteos")
                    .IsUnique();

                entity.Property(e => e.CaSalmPct)
                    .HasColumnName("Ca_Salm_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CaSolPct)
                    .HasColumnName("Ca_Sol_Pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClSalmPct)
                    .HasColumnName("Cl_Salm_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClSolPct)
                    .HasColumnName("Cl_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.DensSalmGml)
                    .HasColumnName("Dens_Salm_gml")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.FechaHora).HasColumnType("datetime2(3)");

                entity.Property(e => e.FlujoRepulpeo).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.H2o170gcSolPct)
                    .HasColumnName("H2O170gc_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.H3bo3SolPct)
                    .HasColumnName("H3BO3_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.KSolPct)
                    .HasColumnName("K_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LiSalmPct)
                    .HasColumnName("Li_Salm_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LiSolPct)
                    .HasColumnName("Li_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MgSalmPct)
                    .HasColumnName("Mg_Salm_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MgSolPct)
                    .HasColumnName("Mg_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaSalmPct)
                    .HasColumnName("Na_Salm_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaSolPct)
                    .HasColumnName("Na_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.So4SalmPct)
                    .HasColumnName("SO4_Salm_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.So4SolPct)
                    .HasColumnName("SO4_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.TkLimsSolPct)
                    .HasColumnName("TK_LIMS_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.TkSiproSolPct)
                    .HasColumnName("TK_SIPRO_Sol_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.Porteos)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Sistemas>(entity =>
            {
                entity.HasKey(e => e.IdSistemas)
                    .HasName("PK_Sistemas_IdSistema");

                entity.HasIndex(e => e.Sistema)
                    .HasName("UK_Sistemas_Sistema")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SistemasSubSistemas>(entity =>
            {
                entity.HasKey(e => e.IdSistemasSubsistemas)
                    .HasName("PK_Sistemas_SubSistemas_IdSistemas_Subsistemas2")
                    .IsClustered(false);

                entity.ToTable("Sistemas_SubSistemas");

                entity.HasIndex(e => new { e.IdSistemas, e.IdSubsistemas })
                    .HasName("UK_Sistemas_SubSistemas")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.HasOne(d => d.IdSistemasNavigation)
                    .WithMany(p => p.SistemasSubSistemas)
                    .HasForeignKey(d => d.IdSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSubsistemasNavigation)
                    .WithMany(p => p.SistemasSubSistemas)
                    .HasForeignKey(d => d.IdSubsistemas);
            });

            modelBuilder.Entity<Subsistemas>(entity =>
            {
                entity.HasKey(e => e.IdSubsistemas)
                    .HasName("PK_Subsistemas_IdSubsistemas");

                entity.HasIndex(e => e.Subsistema)
                    .HasName("UK_Subsistemas_Subsistemas")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
