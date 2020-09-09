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

        public virtual DbSet<Cosechas> Cosechas { get; set; }
        public virtual DbSet<Periodos> Periodos { get; set; }
        public virtual DbSet<Porteos> Porteos { get; set; }
        public virtual DbSet<Sistemas> Sistemas { get; set; }
        public virtual DbSet<SistemasSubSistemas> SistemasSubSistemas { get; set; }
        public virtual DbSet<Subsistemas> Subsistemas { get; set; }
        public virtual DbSet<Infraestructuras> Infraestructuras { get; set; }
        public virtual DbSet<PeriodosOperacionales> PeriodosOperacionales { get; set; }
        public virtual DbSet<Extraccion> Extraccion { get; set; }
        public virtual DbSet<OperaPozas> OperaPozas { get; set; }
        public virtual DbSet<Reservorios> Reservorios { get; set; }
        public virtual DbSet<TransSistemasCosechas> TransSistemasCosechas { get; set; }

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
            modelBuilder.Entity<Cosechas>(entity =>
            {
                entity.HasKey(e => e.IdCosechas)
                    .HasName("PK_IdCosechas");

                entity.HasIndex(e => new { e.IdPeriodos, e.IdInfraestructuras, e.IdSistemasSubSistemas })
                    .HasName("UK_Cosechas");

                entity.Property(e => e.AlturaPozaM)
                    .HasColumnName("AlturaPoza_m")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Densidad).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.HumPct)
                    .HasColumnName("Hum_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.IdSistemasSubSistemas).HasColumnName("IdSistemas_SubSistemas");

                entity.Property(e => e.ImprgPct)
                    .HasColumnName("Imprg_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 2)");
            });

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

            modelBuilder.Entity<Infraestructuras>(entity =>
            {
                entity.HasKey(e => e.IdInfraestructuras)
                    .HasName("PK_Infraestructuras_IdInfraestructuras");

                entity.HasIndex(e => e.Infraestructura)
                    .HasName("UK_Infraestructuras_Infraestructura")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportarAgrupada)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdInfraestructuraPadreNavigation)
                    .WithMany(p => p.InverseIdInfraestructuraPadreNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraPadre)
                    .HasConstraintName("FK_Infraestructuras_Infraestructuras_IdInfraestructuras");
            });

            modelBuilder.Entity<PeriodosOperacionales>(entity =>
            {
                entity.HasKey(e => e.IdPeriodosOpercionales)
                    .HasName("PK_PeriodoOperacional_IdPeriodoOpercional");

                entity.HasIndex(e => new { e.IdSistemas, e.IdPeriodo })
                    .HasName("UK_PeriodoOperacional")
                    .IsUnique();

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");
            });

            modelBuilder.Entity<Extraccion>(entity =>
            {
                entity.HasKey(e => e.IdExtraccion)
                    .HasName("PK_IdExtraccion");

                entity.HasIndex(e => new { e.Fecha, e.IdInfraestructuraOrigen, e.IdInfraestructuraDestino })
                    .HasName("UK_Extraccion");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.HorasOperacionH)
                    .HasColumnName("HorasOperacion_h")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolTraspasoM3)
                    .HasColumnName("VolTraspaso_m3")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 0)");
            });

            modelBuilder.Entity<OperaPozas>(entity =>
            {
                entity.HasKey(e => e.IdOperaPozas)
                    .HasName("PK_IdOperaPozas");

                entity.HasIndex(e => new { e.IdSistemas, e.IdInfraestructuraOrigen, e.IdInfraestructuraDestino, e.Fecha })
                    .HasName("UK_OperaPozas");

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CaudalInstantaneoM3s)
                    .HasColumnName("CaudalInstantaneo_m3s")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Horometro).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.SatK).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolumenTraspasoM3)
                    .HasColumnName("VolumenTraspaso_m3")
                    .HasColumnType("decimal(19, 3)");
            });

            modelBuilder.Entity<Reservorios>(entity =>
            {
                entity.HasKey(e => e.IdReservorios)
                    .HasName("PK_IdReservorios");

                entity.HasIndex(e => e.NombreReservorio)
                    .HasName("UK_Reservorios")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.NombreReservorio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransSistemasCosechas>(entity =>
            {
                entity.HasKey(e => e.IdTransSistemasCosechas)
                    .HasName("PK_IdTransSistemasCosechas");

                entity.HasIndex(e => new { e.SistemaOrigen, e.SubsistemaOrigen })
                    .HasName("UK_TransSistemasCosechas")
                    .IsUnique();

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubsistemaOrigen)
                    .IsRequired()
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
