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

        public virtual DbSet<ConsInvCarmen> ConsInvCarmen { get; set; }
        public virtual DbSet<ConsumoEnergetico> ConsumoEnergetico { get; set; }
        public virtual DbSet<Faenas> Faenas { get; set; }
        public virtual DbSet<FaenasSistemas> FaenasSistemas { get; set; }
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
        public virtual DbSet<ImportDestino> ImportDestino { get; set; }
        public virtual DbSet<Importaciones> Importaciones { get; set; }
        public virtual DbSet<ImportacionesUserParValues> ImportacionesUserParValues { get; set; }
        public virtual DbSet<Importadores> Importadores { get; set; }
        public virtual DbSet<MensajesImportacion> MensajesImportacion { get; set; }
        public virtual DbSet<OrigenesDatos> OrigenesDatos { get; set; }
        public virtual DbSet<SchemaColumns> SchemaColumns { get; set; }
        public virtual DbSet<SchemaColumnsWarning> SchemaColumnsWarning { get; set; }
        public virtual DbSet<SchemaDef> SchemaDef { get; set; }
        public virtual DbSet<Bombas> Bombas { get; set; }
        public virtual DbSet<TipoInfraestructuras> TipoInfraestructuras { get; set; }

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

            modelBuilder.Entity<ImportDestino>(entity =>
            {
                entity.HasKey(e => e.IdImportDestino)
                    .HasName("PK_Destination_IdDestination");

                entity.ToTable("ImportDestino", "imports");

                entity.HasIndex(e => new { e.ImportJobNombre, e.ImportJobSeq, e.IdSchemaDef })
                    .HasName("UK_Destination")
                    .IsUnique();

                entity.Property(e => e.Activa).HasDefaultValueSql("((1))");

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.ImportJobNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PyRef).IsUnicode(false);

                entity.Property(e => e.Sqlref)
                    .IsRequired()
                    .HasColumnName("SQLRef")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSchemaDefNavigation)
                    .WithMany(p => p.ImportDestino)
                    .HasForeignKey(d => d.IdSchemaDef)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Importaciones>(entity =>
            {
                entity.HasKey(e => e.IdImportaciones);

                entity.ToTable("Importaciones", "imports");

                entity.Property(e => e.IdImportaciones).ValueGeneratedNever();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdImportadoresNavigation)
                    .WithMany(p => p.Importaciones)
                    .HasForeignKey(d => d.IdImportadores)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdMensagesImportacionNavigation)
                    .WithMany(p => p.Importaciones)
                    .HasForeignKey(d => d.IdMensagesImportacion)
                    .HasConstraintName("FK_Importaciones_MensajesImportacion_IdMensajesImportacion");
            });

            modelBuilder.Entity<ImportacionesUserParValues>(entity =>
            {
                entity.HasKey(e => e.IdImportacionesUserParValues)
                    .HasName("PK_ImportUserPar_IdImportUserPar");

                entity.ToTable("ImportacionesUserParValues", "imports");

                entity.HasIndex(e => new { e.IdImportadoresUserPar, e.IdImportaciones })
                    .HasName("UK_ImportUserPar")
                    .IsUnique();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdImportacionesNavigation)
                    .WithMany(p => p.ImportacionesUserParValues)
                    .HasForeignKey(d => d.IdImportaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Importadores>(entity =>
            {
                entity.HasKey(e => e.IdImportadores);

                entity.ToTable("Importadores", "imports");

                entity.HasIndex(e => e.Nombre)
                    .HasName("UQ_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MensajesImportacion>(entity =>
            {
                entity.HasKey(e => e.IdMensajesImportacion)
                    .HasName("PK_MensajesImportacion_IdMensajesImportacion");

                entity.ToTable("MensajesImportacion", "imports");

                entity.HasIndex(e => new { e.IdOrigenesDatos, e.IdTipoMensaje, e.ErrorCounter })
                    .HasName("IDX_MensajesImportacion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fila)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdOrigenesDatosNavigation)
                    .WithMany(p => p.MensajesImportacion)
                    .HasForeignKey(d => d.IdOrigenesDatos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrigenesDatos>(entity =>
            {
                entity.HasKey(e => e.IdOrigenesDatos)
                    .HasName("PK_OrigenesDatos_IdOrigenesDatos");

                entity.ToTable("OrigenesDatos", "imports");

                entity.HasIndex(e => new { e.OrigenDatos, e.Tab })
                    .HasName("IDX_OrigenesDatos")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrigenDatos)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tab)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdImportadoresNavigation)
                    .WithMany(p => p.OrigenesDatos)
                    .HasForeignKey(d => d.IdImportadores)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SchemaColumns>(entity =>
            {
                entity.HasKey(e => e.IdSchemaColumns)
                    .HasName("PK_SchemaDefErrors_IdSchemaDefErrors");

                entity.ToTable("SchemaColumns", "imports");

                entity.HasIndex(e => new { e.IdSchemaDef, e.NombreCol })
                    .HasName("UK_SchemaColumns")
                    .IsUnique();

                entity.Property(e => e.FormatoFechaRegex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormatoTextoRegex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RangoFechaFin).HasColumnType("datetime2(3)");

                entity.Property(e => e.RangoFechaInicio).HasColumnType("datetime2(3)");

                entity.Property(e => e.RangoNumFin).HasColumnType("decimal(19, 7)");

                entity.Property(e => e.RangoNumInicio).HasColumnType("decimal(19, 7)");

                entity.Property(e => e.Requerido).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unico).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdSchemaDefNavigation)
                    .WithMany(p => p.SchemaColumns)
                    .HasForeignKey(d => d.IdSchemaDef)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SchemaColumnsWarning>(entity =>
            {
                entity.HasKey(e => e.IdSchemaColumnsWarning)
                    .HasName("PK_SchemaColumnsWarning_IdSchemaColumns");

                entity.ToTable("SchemaColumnsWarning", "imports");

                entity.HasIndex(e => new { e.IdSchemaDef, e.NombreCol })
                    .HasName("UK_SchemaColumns")
                    .IsUnique();

                entity.Property(e => e.FormatoFechaRegex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormatoTextoRegex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RangoFechaFin).HasColumnType("datetime2(3)");

                entity.Property(e => e.RangoFechaInicio).HasColumnType("datetime2(3)");

                entity.Property(e => e.RangoNumFin).HasColumnType("decimal(19, 7)");

                entity.Property(e => e.RangoNumInicio).HasColumnType("decimal(19, 7)");

                entity.Property(e => e.Requerido).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unico).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdSchemaDefNavigation)
                    .WithMany(p => p.SchemaColumnsWarning)
                    .HasForeignKey(d => d.IdSchemaDef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchemaColumnsWarning_IdSchemaDef");
            });

            modelBuilder.Entity<SchemaDef>(entity =>
            {
                entity.HasKey(e => e.IdSchemaDef)
                    .HasName("PK_SchemaPar_IdSchemaPar");

                entity.ToTable("SchemaDef", "imports");

                entity.Property(e => e.SkiprowsList).IsUnicode(false);

                entity.Property(e => e.UniqueKeyList).IsUnicode(false);

                entity.HasOne(d => d.IdOrigenesDatosNavigation)
                    .WithMany(p => p.SchemaDef)
                    .HasForeignKey(d => d.IdOrigenesDatos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConsInvCarmen>(entity =>
            {
                entity.HasKey(e => e.IdConsInvCarmen)
                    .HasName("PK_IdConsInvCarmen");

                entity.HasIndex(e => new { e.Fecha, e.IdSistemasSubSistemas, e.IdInfraestructuras })
                    .HasName("UK_ConsInvCarmen")
                    .IsUnique();

                entity.Property(e => e.DensidadTomm3)
                    .HasColumnName("Densidad_tomm3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdSistemasSubSistemas).HasColumnName("IdSistemas_SubSistemas");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaBalanceLceTon)
                    .HasColumnName("MasaBalanceLCE_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaLceTon)
                    .HasColumnName("MasaLCE_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 2)");
            });

            modelBuilder.Entity<ConsumoEnergetico>(entity =>
            {
                entity.HasKey(e => e.IdConsumoEnergetico)
                    .HasName("PK_ConsumoEnergetico_IdConsumoEnergetico");

                entity.HasIndex(e => new { e.IdPeriodos, e.Up, e.Concepto })
                    .HasName("UK_ConsumoEnergetico")
                    .IsUnique();

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoD)
                    .HasColumnName("Concepto_D")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Um)
                    .HasColumnName("UM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Up)
                    .IsRequired()
                    .HasColumnName("UP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpD)
                    .HasColumnName("UP_D")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 7)");
            });

            modelBuilder.Entity<Faenas>(entity =>
            {
                entity.HasKey(e => e.IdFaenas)
                    .HasName("PK_Faenas_IdFaenas");

                entity.HasIndex(e => e.Faena)
                    .HasName("UK_Faenas_Faena")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Faena)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FaenasSistemas>(entity =>
            {
                entity.HasKey(e => e.IdFaenasSistemas)
                    .HasName("PK_Faenas_sistemas_IdFaenas_Sistemas");

                entity.ToTable("Faenas_Sistemas");

                entity.HasIndex(e => new { e.IdFaenas, e.IdSistemas })
                    .HasName("UK_Faenas_sistemas")
                    .IsUnique();

                entity.Property(e => e.IdFaenasSistemas).HasColumnName("IdFaenas_Sistemas");

                entity.HasOne(d => d.IdFaenasNavigation)
                    .WithMany(p => p.FaenasSistemas)
                    .HasForeignKey(d => d.IdFaenas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

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

            modelBuilder.Entity<Bombas>(entity =>
            {
                entity.HasKey(e => e.IdBombas)
                    .HasName("PK_Bombas_IdBombas");

                entity.HasIndex(e => e.Bomba)
                    .HasName("UK_Bombas_Bomba")
                    .IsUnique();

                entity.Property(e => e.Bomba)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoInfraestructuras>(entity =>
            {
                entity.HasKey(e => e.IdTipoInfraestructuras)
                    .HasName("PK_TipoInfraestructuras_IdTipoInfraestructuras");

                entity.HasIndex(e => e.TipoInfraestructuras1)
                    .HasName("UK_TipoInfraestructuras_TipoInfraestructuras")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoInfraestructuras1)
                    .IsRequired()
                    .HasColumnName("TipoInfraestructuras")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
