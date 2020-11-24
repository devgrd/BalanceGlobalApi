using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Database.Queries;

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

        public virtual DbSet<Ctcatalog> Ctcatalog { get; set; }
        public virtual DbSet<Aliases> Aliases { get; set; }
        public virtual DbSet<TipoDatoColOrigen> TipoDatoColOrigen { get; set; }
        public virtual DbSet<Bombas> Bombas { get; set; }
        public virtual DbSet<CargaPlataformas> CargaPlataformas { get; set; }
        public virtual DbSet<CategoriaConsumoAgua> CategoriaConsumoAgua { get; set; }
        public virtual DbSet<CkmopIiquimaPorteo> CkmopIiquimaPorteo { get; set; }
        public virtual DbSet<CkmopIivolaPorteo> CkmopIivolaPorteo { get; set; }
        public virtual DbSet<ConsDespacho> ConsDespacho { get; set; }
        public virtual DbSet<ConsInvCarmen> ConsInvCarmen { get; set; }
        public virtual DbSet<ConsLi2Co3> ConsLi2Co3 { get; set; }
        public virtual DbSet<ConsLitioLiCo3mensual> ConsLitioLiCo3mensual { get; set; }
        public virtual DbSet<ConsPlantaLiOh> ConsPlantaLiOh { get; set; }
        public virtual DbSet<ConsReactivos> ConsReactivos { get; set; }
        public virtual DbSet<ConsRilesyRises> ConsRilesyRises { get; set; }
        public virtual DbSet<ConsumoAgua> ConsumoAgua { get; set; }
        public virtual DbSet<ConsumoEnergetico> ConsumoEnergetico { get; set; }
        public virtual DbSet<CorrienteGlobal> CorrienteGlobal { get; set; }
        public virtual DbSet<CorrienteLi2Co3> CorrienteLi2Co3 { get; set; }
        public virtual DbSet<CorrientePci> CorrientePci { get; set; }
        public virtual DbSet<Corrientes> Corrientes { get; set; }
        public virtual DbSet<CorrientesRilesyRises> CorrientesRilesyRises { get; set; }
        public virtual DbSet<Cosechas> Cosechas { get; set; }
        public virtual DbSet<DatosEnLista> DatosEnLista { get; set; }
        public virtual DbSet<DescargaInfraestructurasDestino> DescargaInfraestructurasDestino { get; set; }
        public virtual DbSet<DescargaPlataformas> DescargaPlataformas { get; set; }
        public virtual DbSet<DetallePerfil> DetallePerfil { get; set; }
        public virtual DbSet<EvaporacionInfiltracion> EvaporacionInfiltracion { get; set; }
        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<Extraccion> Extraccion { get; set; }
        public virtual DbSet<ExtraccionAgua> ExtraccionAgua { get; set; }
        public virtual DbSet<FactoresImpregnacion> FactoresImpregnacion { get; set; }
        public virtual DbSet<Faenas> Faenas { get; set; }
        public virtual DbSet<FaenasSistemas> FaenasSistemas { get; set; }
        public virtual DbSet<Flujos> Flujos { get; set; }
        public virtual DbSet<ImportDestino> ImportDestino { get; set; }
        public virtual DbSet<Importaciones> Importaciones { get; set; }
        public virtual DbSet<ImportacionesUserParValues> ImportacionesUserParValues { get; set; }
        public virtual DbSet<Importadores> Importadores { get; set; }
        public virtual DbSet<ImportadoresUserPar> ImportadoresUserPar { get; set; }
        public virtual DbSet<ImpregnacionCosechas> ImpregnacionCosechas { get; set; }
        public virtual DbSet<ImpregnacionSistemaRef> ImpregnacionSistemaRef { get; set; }
        public virtual DbSet<Infraestructuras> Infraestructuras { get; set; }
        public virtual DbSet<InfraestructurasReinyeccion> InfraestructurasReinyeccion { get; set; }
        public virtual DbSet<InventariosAtacama> InventariosAtacama { get; set; }
        public virtual DbSet<Mensajes> Mensajes { get; set; }
        public virtual DbSet<MensajesImportacion> MensajesImportacion { get; set; }
        public virtual DbSet<ModalidadPci> ModalidadPci { get; set; }
        public virtual DbSet<ModalidadPlantas> ModalidadPlantas { get; set; }
        public virtual DbSet<OperaPozas> OperaPozas { get; set; }
        public virtual DbSet<OrigenesDatos> OrigenesDatos { get; set; }
        public virtual DbSet<OrigenesTraspasoPlataformas> OrigenesTraspasoPlataformas { get; set; }
        public virtual DbSet<PciacopiosCli> PciacopiosCli { get; set; }
        public virtual DbSet<PciacopiosOrigen> PciacopiosOrigen { get; set; }
        public virtual DbSet<Pcimodos> Pcimodos { get; set; }
        public virtual DbSet<PerfilesUsuario> PerfilesUsuario { get; set; }
        public virtual DbSet<Periodos> Periodos { get; set; }
        public virtual DbSet<PeriodosOperacionales> PeriodosOperacionales { get; set; }
        public virtual DbSet<Permeabilidad> Permeabilidad { get; set; }
        public virtual DbSet<Porteos> Porteos { get; set; }
        public virtual DbSet<ProdyDespSdeAconsProdK> ProdyDespSdeAconsProdK { get; set; }
        public virtual DbSet<ProdyDespSdeAconsProdK1> ProdyDespSdeAconsProdK1 { get; set; }
        public virtual DbSet<ProdyDespSdeAvariablesNum> ProdyDespSdeAvariablesNum { get; set; }
        public virtual DbSet<QuimicaPlataformas> QuimicaPlataformas { get; set; }
        public virtual DbSet<Reactivos> Reactivos { get; set; }
        public virtual DbSet<Reinyeccion> Reinyeccion { get; set; }
        public virtual DbSet<Reservorios> Reservorios { get; set; }
        public virtual DbSet<RiegoPlataformas> RiegoPlataformas { get; set; }
        public virtual DbSet<SchemaColumns> SchemaColumns { get; set; }
        public virtual DbSet<SchemaColumnsWarning> SchemaColumnsWarning { get; set; }
        public virtual DbSet<SchemaDef> SchemaDef { get; set; }
        public virtual DbSet<Sistemas> Sistemas { get; set; }
        public virtual DbSet<SistemasSubSistemas> SistemasSubSistemas { get; set; }
        public virtual DbSet<SubSistemas> SubSistemas { get; set; }
        public virtual DbSet<SuscripcionEventos> SuscripcionEventos { get; set; }
        public virtual DbSet<TasaEvaporacion> TasaEvaporacion { get; set; }
        public virtual DbSet<TipoInfraestructuras> TipoInfraestructuras { get; set; }
        public virtual DbSet<TipoPci> TipoPci { get; set; }
        public virtual DbSet<TipoSal> TipoSal { get; set; }
        public virtual DbSet<TiposInventario> TiposInventario { get; set; }
        public virtual DbSet<TransSistemasCosechas> TransSistemasCosechas { get; set; }
        public virtual DbSet<TraspasosPlataformas> TraspasosPlataformas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosPerfilesUsuario> UsuariosPerfilesUsuario { get; set; }
        public virtual DbSet<WorkflowItem> WorkflowItem { get; set; }
        public virtual DbSet<ChangeTrackingDetail> ChangeTrackingDetail { get; set; }
        public virtual DbSet<ChangeTrackingHeader> ChangeTrackingHeader { get; set; }


        public virtual DbSet<WorkFlowItemQuery> WorkFlowItemQuery { get; set; }


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
            modelBuilder.Entity<Ctcatalog>(entity =>
            {
                entity.HasKey(e => e.IdCtcatalog)
                    .HasName("PK__CTCatalo__E8844DA3FAC33553");

                entity.ToTable("CTCatalog", "AuditLog");

                entity.Property(e => e.IdCtcatalog).HasColumnName("IdCTCatalog");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TablePkfield)
                    .IsRequired()
                    .HasColumnName("TablePKField")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingFields)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingFrom)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImportadoresUserPar>(entity =>
            {
                entity.HasKey(e => e.IdImportadoresUserPar)
                    .HasName("PK_ImportadoresUserPar_IdImportadoresUserPar");

                entity.ToTable("ImportadoresUserPar", "imports");

                entity.HasIndex(e => new { e.UserPar, e.IdImportadores })
                    .HasName("UK_ImportadoresUserPar")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserPar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchemaColumns>(entity =>
            {
                entity.HasKey(e => e.IdSchemaColumns)
                    .HasName("PK_SchemaDefErrors_IdSchemaDefErrors");

                entity.ToTable("SchemaColumns", "imports");

                entity.HasIndex(e => new { e.IdSchemaDef, e.NombreCol })
                    .HasName("UK_SchemaColumns")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdSchemaDef, e.NombreCol, e.PosicionCol })
                    .HasName("UK_SchemaColumns_Pos")
                    .IsUnique();

                entity.Property(e => e.FormatoFechaRegex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormatoTextoRegex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Guide)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Si no hay datos esta columna se saltara toda la fila");

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

                entity.HasOne(d => d.IdFilteredByControlNavigation)
                    .WithMany(p => p.SchemaColumns)
                    .HasForeignKey(d => d.IdFilteredByControl)
                    .HasConstraintName("FK_SchemaColumns_ImportadoresUserPar_IdImportadoresUserPar");
            });


            modelBuilder.Entity<ChangeTrackingDetail>(entity =>
            {
                entity.HasKey(e => e.IdChangeTrackingDetail)
                    .HasName("PK__ChangeTr__E5A18A5D8B4FC093");

                entity.ToTable("ChangeTrackingDetail", "AuditLog");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Pkvalue).HasColumnName("PKValue");

                entity.HasOne(d => d.IdChangeTrackingHeaderNavigation)
                    .WithMany(p => p.ChangeTrackingDetail)
                    .HasForeignKey(d => d.IdChangeTrackingHeader)
                    .HasConstraintName("FK_ChangeTrackingDetail_ChangeTrackingHeader");
            });

            modelBuilder.Entity<ChangeTrackingHeader>(entity =>
            {
                entity.HasKey(e => e.IdChangeTrackingHeader)
                    .HasName("PK__ChangeTr__1638CDD0E9139A64");

                entity.ToTable("ChangeTrackingHeader", "AuditLog");

                entity.Property(e => e.IdChangeTrackingHeader).ValueGeneratedNever();

                entity.Property(e => e.Pkname)
                    .IsRequired()
                    .HasColumnName("PKName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime2(3)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransactionUser)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aliases>(entity =>
            {
                entity.HasKey(e => e.IdAliases)
                    .HasName("PK_Aliases_IdAliases");

                entity.ToTable("Aliases", "imports");

                entity.HasIndex(e => new { e.Importador, e.Campo, e.ValorOriginal })
                    .HasName("UK_Aliases")
                    .IsUnique();

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Importador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAlias)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ValorOriginal)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDatoColOrigen>(entity =>
            {
                entity.HasKey(e => e.IdTipoDatoColOrigen)
                    .HasName("PK_TipoDatoOrigen_IdTipoDatoOrigen");

                entity.ToTable("TipoDatoColOrigen", "imports");

                entity.HasIndex(e => e.TipoDatoColOrigen1)
                    .HasName("UK_TipoDatoOrigen_TipoDatOrigen")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.PyEquiv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlequiv)
                    .HasColumnName("SQLEquiv")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDatoColOrigen1)
                    .IsRequired()
                    .HasColumnName("TipoDatoColOrigen")
                    .HasMaxLength(50)
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

            modelBuilder.Entity<CargaPlataformas>(entity =>
            {
                entity.HasKey(e => e.IdCargaPlataformas)
                    .HasName("PK_IdCargaPlataformas");

                entity.HasIndex(e => new { e.Fecha, e.IdInfraestructuraOrigen, e.IdPlataforma, e.IdTipoSal })
                    .HasName("UK_CargaPlataformas")
                    .IsUnique();

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 1)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInfraestructuraOrigenNavigation)
                    .WithMany(p => p.CargaPlataformasIdInfraestructuraOrigenNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargaPlataformas_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.CargaPlataformas)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPlataformaNavigation)
                    .WithMany(p => p.CargaPlataformasIdPlataformaNavigation)
                    .HasForeignKey(d => d.IdPlataforma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargaPlataformas_IdPlat_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdTipoSalNavigation)
                    .WithMany(p => p.CargaPlataformas)
                    .HasForeignKey(d => d.IdTipoSal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargaPlataformas_IdTipoSal");
            });

            modelBuilder.Entity<CategoriaConsumoAgua>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaConsumoAgua)
                    .HasName("PK_IdCategoriaConsumoAgua");

                entity.HasIndex(e => e.CategoriasConsumoAgua)
                    .HasName("UK_CategoriaConsumoAgua")
                    .IsUnique();

                entity.Property(e => e.CategoriasConsumoAgua)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.SuperGrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CkmopIiquimaPorteo>(entity =>
            {
                entity.HasKey(e => e.IdCkmopIiquimaPorteo)
                    .HasName("PK_IdCKMopIIQuimaPorteo");

                entity.ToTable("CKMopIIQuimaPorteo");

                entity.HasIndex(e => new { e.IdInfraestructuras, e.Fecha })
                    .HasName("UK_CKMopIIQuimaPorteo")
                    .IsUnique();

                entity.Property(e => e.IdCkmopIiquimaPorteo).HasColumnName("IdCKMopIIQuimaPorteo");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.CkmopIiquimaPorteo)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.CkmopIiquimaPorteo)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CkmopIivolaPorteo>(entity =>
            {
                entity.HasKey(e => e.IdCkmopIivolaPorteo)
                    .HasName("PK_IdCKMopIIVolaPorteo");

                entity.ToTable("CKMopIIVolaPorteo");

                entity.HasIndex(e => new { e.IdInfraestructuras, e.Fecha })
                    .HasName("UK_CKMopIIVolaPorteo")
                    .IsUnique();

                entity.Property(e => e.IdCkmopIivolaPorteo).HasColumnName("IdCKMopIIVolaPorteo");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3dia)
                    .HasColumnName("Volumen_m3dia")
                    .HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.CkmopIivolaPorteo)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.CkmopIivolaPorteo)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConsDespacho>(entity =>
            {
                entity.HasKey(e => e.IdConsDespacho)
                    .HasName("PK_IdConsDespacho");

                entity.HasIndex(e => e.Fecha)
                    .HasName("UK_ConsDespacho")
                    .IsUnique();

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DensTonm3)
                    .HasColumnName("Dens_tonm3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaDespachadaTon)
                    .HasColumnName("MasaDespachada_ton")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsDespacho)
                    .HasForeignKey(d => d.IdPeriodos)
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 2)");

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.ConsInvCarmen)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsInvCarmen_IdInfraestructuras");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsInvCarmen)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasSubSistemasNavigation)
                    .WithMany(p => p.ConsInvCarmen)
                    .HasForeignKey(d => d.IdSistemasSubSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsInvCarmen_IdSistemas_SubSistemas");
            });

            modelBuilder.Entity<ConsLi2Co3>(entity =>
            {
                entity.HasKey(e => e.IdConsLi2Co3)
                    .HasName("PK_IdConsLi2CO3");

                entity.ToTable("ConsLi2CO3");

                entity.HasIndex(e => new { e.Fecha, e.IdCorrienteLi2Co3 })
                    .HasName("UK_ConsLiOH")
                    .IsUnique();

                entity.Property(e => e.IdConsLi2Co3).HasColumnName("IdConsLi2CO3");

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Co3Pct)
                    .HasColumnName("CO3_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.DensTonm3)
                    .HasColumnName("Dens_tonm3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H2oPct)
                    .HasColumnName("H2O_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.IdCorrienteLi2Co3).HasColumnName("IdCorrienteLi2CO3");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.OhPct)
                    .HasColumnName("OH_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolM3)
                    .HasColumnName("Vol_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdCorrienteGlobalNavigation)
                    .WithMany(p => p.ConsLi2Co3)
                    .HasForeignKey(d => d.IdCorrienteGlobal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsLiOH_CorrienteGlobal_IdCorrienteGlobal");

                entity.HasOne(d => d.IdCorrienteLi2Co3Navigation)
                    .WithMany(p => p.ConsLi2Co3)
                    .HasForeignKey(d => d.IdCorrienteLi2Co3)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsLiOH_CorrienteLi2CO3_IdCorrienteLi2CO3");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsLi2Co3)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsLiOH_Periodos_IdPeriodos");
            });

            modelBuilder.Entity<ConsLitioLiCo3mensual>(entity =>
            {
                entity.HasKey(e => e.IdConsLitioLiCo3mensual)
                    .HasName("PK_ConsLi2CO3Mensual_IdConsLi2CO3");

                entity.ToTable("ConsLitioLiCO3Mensual");

                entity.HasIndex(e => new { e.IdPeriodos, e.IdCorrienteLi2Co3, e.IdSistemasSubSistemas })
                    .HasName("UK_ConsLitioLiCO3Mensual")
                    .IsUnique();

                entity.Property(e => e.IdConsLitioLiCo3mensual).HasColumnName("IdConsLitioLiCO3Mensual");

                entity.Property(e => e.CarbonatoTon)
                    .HasColumnName("Carbonato_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCorrienteLi2Co3).HasColumnName("IdCorrienteLi2CO3");

                entity.Property(e => e.IdSistemasSubSistemas).HasColumnName("IdSistemas_SubSistemas");

                entity.Property(e => e.Li2Co3FrescaTon)
                    .HasColumnName("Li2CO3_Fresca_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Li2Co3TotalTon)
                    .HasColumnName("Li2CO3_Total_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LitioFrescoTon)
                    .HasColumnName("Litio_Fresco_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCorrienteLi2Co3Navigation)
                    .WithMany(p => p.ConsLitioLiCo3mensual)
                    .HasForeignKey(d => d.IdCorrienteLi2Co3)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsLi2CO3Mensual_IdCorrienteLi2CO3");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsLitioLiCo3mensual)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsLi2CO3Mensual_IdPeriodos");

                entity.HasOne(d => d.IdSistemasSubSistemasNavigation)
                    .WithMany(p => p.ConsLitioLiCo3mensual)
                    .HasForeignKey(d => d.IdSistemasSubSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsLitioLiCO3Mensual_IdSistemas_SubSistemas");
            });

            modelBuilder.Entity<ConsPlantaLiOh>(entity =>
            {
                entity.HasKey(e => e.IdConsPlantaLiOh)
                    .HasName("PK_IdConsPlantaLiOH");

                entity.ToTable("ConsPlantaLiOH");

                entity.HasIndex(e => e.Fecha)
                    .HasName("UK_ConsPlantaLiOH")
                    .IsUnique();

                entity.Property(e => e.IdConsPlantaLiOh).HasColumnName("IdConsPlantaLiOH");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Li2Co3Pct)
                    .HasColumnName("Li2CO3_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsPlantaLiOh)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConsReactivos>(entity =>
            {
                entity.HasKey(e => e.IdConsReactivos)
                    .HasName("PK_IdConsReactivos");

                entity.HasIndex(e => new { e.Fecha, e.IdReactivos, e.IdSistemasSubSistemas })
                    .HasName("UK_ConsReactivos")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistemasSubSistemas).HasColumnName("IdSistemas_SubSistemas");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsReactivos)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdReactivosNavigation)
                    .WithMany(p => p.ConsReactivos)
                    .HasForeignKey(d => d.IdReactivos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsReactivos_IdReactivos");

                entity.HasOne(d => d.IdSistemasSubSistemasNavigation)
                    .WithMany(p => p.ConsReactivos)
                    .HasForeignKey(d => d.IdSistemasSubSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsReactivos_IdSistemas_SubSistemas");
            });

            modelBuilder.Entity<ConsRilesyRises>(entity =>
            {
                entity.HasKey(e => e.IdConsRilesyRises)
                    .HasName("PK_IdConsRilesyRises");

                entity.HasIndex(e => new { e.Fecha, e.IdCorrienteRilesyRises, e.IdSistemas })
                    .HasName("UK_ConsRilesyRises")
                    .IsUnique();

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
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

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCorrienteRilesyRisesNavigation)
                    .WithMany(p => p.ConsRilesyRises)
                    .HasForeignKey(d => d.IdCorrienteRilesyRises)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsRilesyRises_CorrientesRilesyRises_IdCorrientesRilesyRises");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsRilesyRises)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasNavigation)
                    .WithMany(p => p.ConsRilesyRises)
                    .HasForeignKey(d => d.IdSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsRilesyRises_IdSistemas");
            });

            modelBuilder.Entity<ConsumoAgua>(entity =>
            {
                entity.HasKey(e => e.IdConsumoAgua)
                    .HasName("PK_IdConsumoAgua");

                entity.HasIndex(e => new { e.IdCategoriaConsumoAgua, e.Fecha })
                    .HasName("UK_ConsumoAgua")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolAguaM3)
                    .HasColumnName("VolAgua_m3")
                    .HasColumnType("decimal(19, 4)");
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 7)");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsumoEnergetico)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsumoEnergetico_IdPeriodo");
            });

            modelBuilder.Entity<CorrienteGlobal>(entity =>
            {
                entity.HasKey(e => e.IdCorrienteGlobal)
                    .HasName("PK_IdCorrienteGlobal");

                entity.HasIndex(e => e.CorrienteGlobal1)
                    .HasName("UK_CorrienteGlobal")
                    .IsUnique();

                entity.Property(e => e.CorrienteGlobal1)
                    .IsRequired()
                    .HasColumnName("CorrienteGlobal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descipcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorrienteLi2Co3>(entity =>
            {
                entity.HasKey(e => e.IdCorrienteLi2Co3)
                    .HasName("PK_IdCorrienteLi2CO3");

                entity.ToTable("CorrienteLi2CO3");

                entity.HasIndex(e => e.CorrienteLi2Co31)
                    .HasName("UK_CorrienteLi2CO3")
                    .IsUnique();

                entity.Property(e => e.IdCorrienteLi2Co3).HasColumnName("IdCorrienteLi2CO3");

                entity.Property(e => e.CorrienteLi2Co31)
                    .IsRequired()
                    .HasColumnName("CorrienteLi2CO3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descipcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorrientePci>(entity =>
            {
                entity.HasKey(e => e.IdCorrientePci)
                    .HasName("PK_IdCorrientePCI");

                entity.ToTable("CorrientePCI");

                entity.HasIndex(e => e.CorrientePci1)
                    .HasName("UK_CorrientePCI")
                    .IsUnique();

                entity.Property(e => e.IdCorrientePci).HasColumnName("IdCorrientePCI");

                entity.Property(e => e.CorrientePci1)
                    .IsRequired()
                    .HasColumnName("CorrientePCI")
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

            modelBuilder.Entity<Corrientes>(entity =>
            {
                entity.HasKey(e => e.IdCorrientes)
                    .HasName("PK_IdCorrientes");

                entity.HasIndex(e => e.Corriente)
                    .HasName("UK_Corrientes")
                    .IsUnique();

                entity.Property(e => e.Corriente)
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

            modelBuilder.Entity<CorrientesRilesyRises>(entity =>
            {
                entity.HasKey(e => e.IdCorrientesRilesyRises)
                    .HasName("PK_IdCorrienteRilesyRises");

                entity.HasIndex(e => e.CorrientesRilesyRises1)
                    .HasName("UK_CorrientesRilesyRises")
                    .IsUnique();

                entity.Property(e => e.CorrientesRilesyRises1)
                    .IsRequired()
                    .HasColumnName("CorrientesRilesyRises")
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
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Densidad).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.HumPct)
                    .HasColumnName("Hum_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.IdSistemasSubSistemas).HasColumnName("IdSistemas_SubSistemas");

                entity.Property(e => e.ImprgPct)
                    .HasColumnName("Imprg_pct")
                    .HasColumnType("decimal(19, 2)");

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

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.Cosechas)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.Cosechas)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasSubSistemasNavigation)
                    .WithMany(p => p.Cosechas)
                    .HasForeignKey(d => d.IdSistemasSubSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cosechas_Sistemas_SubSistemas_IdSistemas_Subsistemas");
            });

            modelBuilder.Entity<DatosEnLista>(entity =>
            {
                entity.HasKey(e => e.IdDatosEnLista)
                    .HasName("PK_DatosEnLista_IdDatosEnLista");

                entity.ToTable("DatosEnLista", "imports");

                entity.HasIndex(e => e.DatosEnLista1)
                    .HasName("UK_DatosEnLista_DatosEnLista")
                    .IsUnique();

                entity.Property(e => e.DatosEnLista1)
                    .IsRequired()
                    .HasColumnName("DatosEnLista")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lista)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DescargaInfraestructurasDestino>(entity =>
            {
                entity.HasKey(e => e.IdDescargaInfraestructurasDestino)
                    .HasName("PK_InfraestructurasDestino_IdInfraestructurasDestino");

                entity.HasIndex(e => new { e.IdInfraestructura, e.IdDescargaPlataformas })
                    .HasName("UK_DescargaInfraestructurasDestino")
                    .IsUnique();

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDescargaPlataformasNavigation)
                    .WithMany(p => p.DescargaInfraestructurasDestino)
                    .HasForeignKey(d => d.IdDescargaPlataformas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdInfraestructuraNavigation)
                    .WithMany(p => p.DescargaInfraestructurasDestino)
                    .HasForeignKey(d => d.IdInfraestructura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfraestructurasDestino_IdInfraestructura");
            });

            modelBuilder.Entity<DescargaPlataformas>(entity =>
            {
                entity.HasKey(e => e.IdDescargaPlataformas)
                    .HasName("PK_IdDescargaPlataformas");

                entity.HasIndex(e => new { e.Fecha, e.IdPlataforma, e.IdTipoSal })
                    .HasName("UK_DescargaPlataformas")
                    .IsUnique();

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 2)");

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

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolSalidaM3)
                    .HasColumnName("VolSalida_m3")
                    .HasColumnType("decimal(19, 1)");

                entity.Property(e => e.VolenPlataformaM3)
                    .HasColumnName("VolenPlataforma_m3")
                    .HasColumnType("decimal(19, 1)");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.DescargaPlataformas)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPlataformaNavigation)
                    .WithMany(p => p.DescargaPlataformas)
                    .HasForeignKey(d => d.IdPlataforma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DescargaPlataformas_IdPlat_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdTipoSalNavigation)
                    .WithMany(p => p.DescargaPlataformas)
                    .HasForeignKey(d => d.IdTipoSal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DescargaPlataformas_IdTipoSal");
            });

            modelBuilder.Entity<DetallePerfil>(entity =>
            {
                entity.HasKey(e => e.IdDetallePerfil);

                entity.ToTable("DetallePerfil", "internals");

                entity.HasOne(d => d.IdPerfilUsuarioNavigation)
                    .WithMany(p => p.DetallePerfil)
                    .HasForeignKey(d => d.IdPerfilUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetallePerfil_PerfilesUsuario");

                entity.HasOne(d => d.IdWorkflowItemNavigation)
                    .WithMany(p => p.DetallePerfil)
                    .HasForeignKey(d => d.IdWorkflowItem)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EvaporacionInfiltracion>(entity =>
            {
                entity.HasKey(e => e.IdEvaporacionInfiltracion)
                    .HasName("PK_IdEvaporacionInfiltracion");

                entity.HasIndex(e => new { e.IdSistemas, e.IdInfraestructuras, e.Fecha })
                    .HasName("UK_Infiltracion")
                    .IsUnique();

                entity.Property(e => e.AlturaSalmueraM)
                    .HasColumnName("AlturaSalmuera_m")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
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

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.EvaporacionInfiltracion)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.EvaporacionInfiltracion)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasNavigation)
                    .WithMany(p => p.EvaporacionInfiltracion)
                    .HasForeignKey(d => d.IdSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Eventos>(entity =>
            {
                entity.HasKey(e => e.IdEventos)
                    .HasName("PK_Eventos_IdEvento")
                    .IsClustered(false);

                entity.ToTable("Eventos", "internals");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Evento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolTraspasoM3)
                    .HasColumnName("VolTraspaso_m3")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 0)");

                entity.HasOne(d => d.IdInfraestructuraDestinoNavigation)
                    .WithMany(p => p.ExtraccionIdInfraestructuraDestinoNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Extraccion_Infraestructuras_InfDes_IdInfraestructuras");

                entity.HasOne(d => d.IdInfraestructuraOrigenNavigation)
                    .WithMany(p => p.ExtraccionIdInfraestructuraOrigenNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Extraccion_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.Extraccion)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ExtraccionAgua>(entity =>
            {
                entity.HasKey(e => e.IdExtraccionAgua)
                    .HasName("PK_IdExtraccionAgua");

                entity.HasIndex(e => new { e.IdInfraestructuraOrigen, e.IdInfraestructuraDestino, e.Fecha })
                    .HasName("UK_ExtraccionAgua")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlujoM3h)
                    .HasColumnName("Flujo_m3h")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolFinalM3)
                    .HasColumnName("VolFinal_m3")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.VolInicialM3)
                    .HasColumnName("VolInicial_m3")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.VolTotalDia)
                    .HasColumnName("VolTotal_dia")
                    .HasColumnType("decimal(19, 0)");

                entity.HasOne(d => d.IdInfraestructuraDestinoNavigation)
                    .WithMany(p => p.ExtraccionAguaIdInfraestructuraDestinoNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExtraccionAgua_Infraestructuras_IdInfDes_IdInfraestructuras");

                entity.HasOne(d => d.IdInfraestructuraOrigenNavigation)
                    .WithMany(p => p.ExtraccionAguaIdInfraestructuraOrigenNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExtraccionAgua_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ExtraccionAgua)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExtraccionAgua_IdPeriodos");
            });

            modelBuilder.Entity<FactoresImpregnacion>(entity =>
            {
                entity.HasKey(e => e.IdFactoresImpregnacion)
                    .HasName("PK_IdFactoresImpregnacion");

                entity.HasIndex(e => new { e.IdSistema, e.IdTipoSal })
                    .HasName("UK_FactoresImpregnacion")
                    .IsUnique();

                entity.Property(e => e.FactorM3m2)
                    .HasColumnName("Factor_m3m2")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoSalNavigation)
                    .WithMany(p => p.FactoresImpregnacion)
                    .HasForeignKey(d => d.IdTipoSal)
                    .OnDelete(DeleteBehavior.ClientSetNull);
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFaenasNavigation)
                    .WithMany(p => p.FaenasSistemas)
                    .HasForeignKey(d => d.IdFaenas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasNavigation)
                    .WithMany(p => p.FaenasSistemas)
                    .HasForeignKey(d => d.IdSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Flujos>(entity =>
            {
                entity.HasKey(e => e.IdFlujos)
                    .HasName("PK_IdFlujos");

                entity.HasIndex(e => new { e.IdSistemasSubsistemas, e.IdBombas, e.Fecha })
                    .HasName("UK_Flujos")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("datetime2(3)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.TotalizadorM3)
                    .HasColumnName("Totalizador_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBombasNavigation)
                    .WithMany(p => p.Flujos)
                    .HasForeignKey(d => d.IdBombas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.Flujos)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.Flujos)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Flujos_IdSistemas_Subsistemas");
            });

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

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.IdImportadoresNavigation)
                    .WithMany(p => p.Importaciones)
                    .HasForeignKey(d => d.IdImportadores)
                    .OnDelete(DeleteBehavior.ClientSetNull);
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

            modelBuilder.Entity<ImpregnacionCosechas>(entity =>
            {
                entity.HasKey(e => e.IdImpregnacionCosechas)
                    .HasName("PK_IdImpregnacionCosechas");

                entity.HasIndex(e => new { e.IdPeriodos, e.IdInfraestructuras, e.IdSistemasSubsistemas, e.Prioridad })
                    .HasName("UK_ImpregnacionCosechas")
                    .IsUnique();

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.HumedadPct)
                    .HasColumnName("Humedad_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

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

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((1))");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.ImpregnacionCosechas)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ImpregnacionCosechas)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.ImpregnacionCosechas)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ImpregnacionSistemaRef>(entity =>
            {
                entity.HasKey(e => e.IdImpregnacionSistemaRef)
                    .HasName("PK_IdImpregnacionSIstemaRef");

                entity.HasIndex(e => e.IdSubSistemas)
                    .HasName("UK_ImpregnacionSistemaRef");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImpregnacionTotal).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSubSistemasNavigation)
                    .WithMany(p => p.ImpregnacionSistemaRef)
                    .HasForeignKey(d => d.IdSubSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Infraestructuras>(entity =>
            {
                entity.HasKey(e => e.IdInfraestructuras)
                    .HasName("PK_Infraestructuras_IdInfraestructuras");

                entity.HasIndex(e => new { e.IdInfraestructuraPadre, e.Infraestructura })
                    .HasName("UK_Infraestructuras_Infraestructura")
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

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportarAgrupada)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInfraestructuraPadreNavigation)
                    .WithMany(p => p.InverseIdInfraestructuraPadreNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraPadre)
                    .HasConstraintName("FK_Infraestructuras_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdTipoInfraestructurasNavigation)
                    .WithMany(p => p.Infraestructuras)
                    .HasForeignKey(d => d.IdTipoInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InfraestructurasReinyeccion>(entity =>
            {
                entity.HasKey(e => e.IdInfraestructurasReinyeccion)
                    .HasName("PK_InfraestruturasReinyeccion_IdInfraestructurasReinyeccion");

                entity.HasIndex(e => e.IdInfraestructuras)
                    .HasName("UK_InfraestruturasReinyeccion_IdInfraestructura")
                    .IsUnique();

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithOne(p => p.InfraestructurasReinyeccion)
                    .HasForeignKey<InfraestructurasReinyeccion>(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfraestruturasReinyeccion_IdInfraestructura");

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.InfraestructurasReinyeccion)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfraestruturasReinyeccion_IdSistema_Subsistema");
            });

            modelBuilder.Entity<InventariosAtacama>(entity =>
            {
                entity.HasKey(e => e.IdInventariosAtacama)
                    .HasName("PK_IdInventariosAtacama");

                entity.HasIndex(e => new { e.IdSistemasSubsistemas, e.Factor, e.IdInfraestructuras, e.IdPeriodo })
                    .HasName("IX_InvetariosAtacama_IdPeriodo");

                entity.HasIndex(e => new { e.IdSistemasSubsistemas, e.IdPeriodo, e.IdInfraestructuras, e.IdTiposInventario, e.Prioridad })
                    .HasName("UK_InventariosAtacama");

                entity.Property(e => e.AlturaSalmueraM)
                    .HasColumnName("AlturaSalmuera_m")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ComparacionVol)
                    .HasColumnName("Comparacion_vol")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DensGcm3)
                    .HasColumnName("Dens_gcm3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Factor).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.K2so4Eqv)
                    .HasColumnName("K2SO4_eqv")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.KclPct)
                    .HasColumnName("KCL_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Li2Co3Eqv)
                    .HasColumnName("Li2CO3_eqv")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.MgCl26h2o)
                    .HasColumnName("MgCl2_6H2O")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((1))");

                entity.Property(e => e.SatK).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Ton)
                    .HasColumnName("ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Volumen).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.VolumenCalculado)
                    .HasColumnName("Volumen_Calculado")
                    .HasColumnType("decimal(19, 2)");

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.InventariosAtacama)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodoNavigation)
                    .WithMany(p => p.InventariosAtacama)
                    .HasForeignKey(d => d.IdPeriodo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventariosAtacama_Periodos_IdPeriodos");

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.InventariosAtacama)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdTiposInventarioNavigation)
                    .WithMany(p => p.InventariosAtacama)
                    .HasForeignKey(d => d.IdTiposInventario)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Mensajes>(entity =>
            {
                entity.HasKey(e => e.IdMensajes);

                entity.ToTable("Mensajes", "internals");

                entity.HasIndex(e => new { e.Tipo, e.Idioma, e.Codigo })
                    .HasName("UQ_Mensajes_PK")
                    .IsUnique();

                entity.Property(e => e.Cuerpo)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Idioma)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MensajesImportacion>(entity =>
            {
                entity.HasKey(e => e.IdMensajesImportacion)
                    .HasName("PK_MensajesImportacion_IdMensajesImportacion");

                entity.ToTable("MensajesImportacion", "imports");

                entity.HasIndex(e => new { e.IdImportaciones, e.IdTipoMensaje, e.ErrorCounter })
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

                entity.HasOne(d => d.IdImportacionesNavigation)
                    .WithMany(p => p.MensajesImportacion)
                    .HasForeignKey(d => d.IdImportaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ModalidadPci>(entity =>
            {
                entity.HasKey(e => e.IdModalidadPci)
                    .HasName("PK_IdModalidadPCI");

                entity.ToTable("ModalidadPCI");

                entity.HasIndex(e => e.ModalidadPci1)
                    .HasName("UK_ModalidadPCI")
                    .IsUnique();

                entity.Property(e => e.IdModalidadPci).HasColumnName("IdModalidadPCI");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModalidadPci1)
                    .IsRequired()
                    .HasColumnName("ModalidadPCI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModalidadPlantas>(entity =>
            {
                entity.HasKey(e => e.IdModalidadPlantas)
                    .HasName("PK_IdModalidadPlantas");

                entity.HasIndex(e => e.ModalidadPlanta)
                    .HasName("UK_ModalidadPlantas")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModalidadPlanta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperaPozas>(entity =>
            {
                entity.HasKey(e => e.IdOperaPozas)
                    .HasName("PK_IdOperaPozas");

                entity.HasIndex(e => new { e.IdPeriodos, e.IdSistemas, e.IdInfraestructuraOrigen, e.IdInfraestructuraDestino, e.Fecha })
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.VolumenTraspasoM3)
                    .HasColumnName("VolumenTraspaso_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdInfraestructuraDestinoNavigation)
                    .WithMany(p => p.OperaPozasIdInfraestructuraDestinoNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperaPozas_Infraestructuras_IdInfraDes_IdInfraestructuras");

                entity.HasOne(d => d.IdInfraestructuraOrigenNavigation)
                    .WithMany(p => p.OperaPozasIdInfraestructuraOrigenNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperaPozas_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.OperaPozas)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasNavigation)
                    .WithMany(p => p.OperaPozas)
                    .HasForeignKey(d => d.IdSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperaPozas_IdSistemas");
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

            modelBuilder.Entity<OrigenesTraspasoPlataformas>(entity =>
            {
                entity.HasKey(e => e.IdOrigenesTraspasoPlataformas)
                    .HasName("PK_OrigenesTraspasoPlataformas_IdIdOrigenesTraspasoPlataformas");

                entity.HasIndex(e => new { e.IdInfraestructuras, e.IdTraspasosPlataformas })
                    .HasName("UK_OrigenesTraspasoPlataformas")
                    .IsUnique();

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.OrigenesTraspasoPlataformas)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrigenesTraspasoPlataformas_IdInfraestructuras");

                entity.HasOne(d => d.IdTraspasosPlataformasNavigation)
                    .WithMany(p => p.OrigenesTraspasoPlataformas)
                    .HasForeignKey(d => d.IdTraspasosPlataformas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PciacopiosCli>(entity =>
            {
                entity.HasKey(e => e.IdPciacopiosCli)
                    .HasName("PK_IdPCIAcopiosCLi");

                entity.ToTable("PCIAcopiosCLi");

                entity.HasIndex(e => new { e.IdPciacopiosOrigen, e.IdPeriodos, e.Prioridad })
                    .HasName("UK_PCIAcopiosCLi")
                    .IsUnique();

                entity.Property(e => e.IdPciacopiosCli).HasColumnName("IdPCIAcopiosCLi");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdPciacopiosOrigen).HasColumnName("IdPCIAcopiosOrigen");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdPciacopiosOrigenNavigation)
                    .WithMany(p => p.PciacopiosCli)
                    .HasForeignKey(d => d.IdPciacopiosOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.PciacopiosCli)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PciacopiosOrigen>(entity =>
            {
                entity.HasKey(e => e.IdPciacopiosOrigen)
                    .HasName("PK_IdPCIAcopiosOrigen");

                entity.ToTable("PCIAcopiosOrigen");

                entity.HasIndex(e => e.Acopio)
                    .HasName("UK_PCIAcopiosOrigen")
                    .IsUnique();

                entity.Property(e => e.IdPciacopiosOrigen).HasColumnName("IdPCIAcopiosOrigen");

                entity.Property(e => e.Acopio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaOrigen).HasColumnType("datetime2(3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSubSistemasNavigation)
                    .WithMany(p => p.PciacopiosOrigen)
                    .HasForeignKey(d => d.IdSubSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Pcimodos>(entity =>
            {
                entity.HasKey(e => e.IdPcimodos)
                    .HasName("PK_IdPCIModos");

                entity.ToTable("PCIModos");

                entity.HasIndex(e => new { e.IdModalidadPci, e.IdCorrientePci, e.IdInfrestructuras, e.IdTipoPci, e.IdPeriodos, e.IdSistemasSubsistemas })
                    .HasName("UK_PCIModos")
                    .IsUnique();

                entity.Property(e => e.IdPcimodos).HasColumnName("IdPCIModos");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCorrientePci).HasColumnName("IdCorrientePCI");

                entity.Property(e => e.IdModalidadPci).HasColumnName("IdModalidadPCI");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.IdTipoPci).HasColumnName("IdTipoPCI");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.MasaLceTon)
                    .HasColumnName("Masa_LCE_ton")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCorrientePciNavigation)
                    .WithMany(p => p.Pcimodos)
                    .HasForeignKey(d => d.IdCorrientePci)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdInfrestructurasNavigation)
                    .WithMany(p => p.Pcimodos)
                    .HasForeignKey(d => d.IdInfrestructuras)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCIModos_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdModalidadPciNavigation)
                    .WithMany(p => p.Pcimodos)
                    .HasForeignKey(d => d.IdModalidadPci)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.Pcimodos)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.Pcimodos)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdTipoPciNavigation)
                    .WithMany(p => p.Pcimodos)
                    .HasForeignKey(d => d.IdTipoPci)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PerfilesUsuario>(entity =>
            {
                entity.HasKey(e => e.IdPerfilUsuario)
                    .HasName("PK_PerfilUsuario_IdPerfilUsuario");

                entity.ToTable("PerfilesUsuario", "internals");

                entity.Property(e => e.DescripcionPerfiles)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePerfilUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeriodosOperacionales>(entity =>
            {
                entity.HasKey(e => e.IdPeriodosOperacionales)
                    .HasName("PK_PeriodoOperacional_IdPeriodoOpercional");

                entity.HasIndex(e => new { e.IdSistemas, e.IdPeriodo })
                    .HasName("UK_PeriodoOperacional")
                    .IsUnique();

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodoNavigation)
                    .WithMany(p => p.PeriodosOperacionales)
                    .HasForeignKey(d => d.IdPeriodo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PeriodoOperacional_Periodos_IdPeriodos");

                entity.HasOne(d => d.IdSistemasNavigation)
                    .WithMany(p => p.PeriodosOperacionales)
                    .HasForeignKey(d => d.IdSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Permeabilidad>(entity =>
            {
                entity.HasKey(e => e.IdPermeabilidad)
                    .HasName("PK_IdPermeabilidad");

                entity.HasIndex(e => e.IdSistemasSubsistemas)
                    .HasName("UK_Permeabilidad")
                    .IsUnique();

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.PermeabilidadM3m2dia)
                    .HasColumnName("Permeabilidad_m3m2dia")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithOne(p => p.Permeabilidad)
                    .HasForeignKey<Permeabilidad>(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permeabilidad_IdSistemas_Subsistemas");
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.Porteos)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProdyDespSdeAconsProdK>(entity =>
            {
                entity.HasKey(e => e.IdProdyDespSdeAconsProdK)
                    .HasName("PK_IdProdyDespSdeAConsProdK");

                entity.ToTable("ProdyDespSdeAConsProdK");

                entity.HasIndex(e => new { e.IdModalidadPlantas, e.IdCorrientes, e.Fecha, e.IdSistemasSubsistemas, e.IdInfraestructuraPlanta, e.IdProdyDespSdeAvariablesNum })
                    .HasName("UK_ProdyDespSdeAConsProdK")
                    .IsUnique();

                entity.Property(e => e.IdProdyDespSdeAconsProdK).HasColumnName("IdProdyDespSdeAConsProdK");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdProdyDespSdeAvariablesNum).HasColumnName("IdProdyDespSdeAVariablesNum");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdCorrientesNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK)
                    .HasForeignKey(d => d.IdCorrientes)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdInfraestructuraPlantaNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK)
                    .HasForeignKey(d => d.IdInfraestructuraPlanta)
                    .HasConstraintName("FK_ProdyDespSdeAConsProdK_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdModalidadPlantasNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK)
                    .HasForeignKey(d => d.IdModalidadPlantas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdProdyDespSdeAvariablesNumNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK)
                    .HasForeignKey(d => d.IdProdyDespSdeAvariablesNum)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdyDespSdeAConsProdK_IdSistemas_Subsistemas");
            });

            modelBuilder.Entity<ProdyDespSdeAconsProdK1>(entity =>
            {
                entity.HasKey(e => e.IdProdyDespSdeAconsProdK1)
                    .HasName("PK_IdProdyDespSdeAConsProdK1");

                entity.ToTable("ProdyDespSdeAConsProdK1");

                entity.HasIndex(e => new { e.IdModalidadPlantas, e.IdCorrientes, e.Fecha, e.IdInfraestructuraPlanta, e.IdSistemasSubsistemas, e.IdProdyDespSdeAvariablesNum })
                    .HasName("UK_ProdyDespSdeAConsProdK1")
                    .IsUnique();

                entity.Property(e => e.IdProdyDespSdeAconsProdK1).HasColumnName("IdProdyDespSdeAConsProdK1");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdProdyDespSdeAvariablesNum).HasColumnName("IdProdyDespSdeAVariablesNum");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdCorrientesNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK1)
                    .HasForeignKey(d => d.IdCorrientes)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdInfraestructuraPlantaNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK1)
                    .HasForeignKey(d => d.IdInfraestructuraPlanta)
                    .HasConstraintName("FK_ProdyDespSdeAConsProdK1_Infraestructuras_IdInfraestructuras");

                entity.HasOne(d => d.IdModalidadPlantasNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK1)
                    .HasForeignKey(d => d.IdModalidadPlantas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK1)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdProdyDespSdeAvariablesNumNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK1)
                    .HasForeignKey(d => d.IdProdyDespSdeAvariablesNum)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.ProdyDespSdeAconsProdK1)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProdyDespSdeAvariablesNum>(entity =>
            {
                entity.HasKey(e => e.IdProdyDespSdeAvariablesNum)
                    .HasName("PK_ProdyDespSdeAVariablesNum_IdProdyDespSdeAVariablesNum");

                entity.ToTable("ProdyDespSdeAVariablesNum");

                entity.HasIndex(e => e.Variable)
                    .HasName("UK_ProdyDespSdeAVariablesNum_Variable")
                    .IsUnique();

                entity.Property(e => e.IdProdyDespSdeAvariablesNum).HasColumnName("IdProdyDespSdeAVariablesNum");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Variable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuimicaPlataformas>(entity =>
            {
                entity.HasKey(e => e.IdQuimicaPlataformas)
                    .HasName("PK_IdQuimicaPlataforma");

                entity.HasIndex(e => new { e.IdPlataforma, e.Fecha })
                    .HasName("UK_QuimicaPlataforma")
                    .IsUnique();

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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 3)");

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

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.QuimicaPlataformas)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuimicaPlataforma_Periodos_IdPeriodos");

                entity.HasOne(d => d.IdPlataformaNavigation)
                    .WithMany(p => p.QuimicaPlataformas)
                    .HasForeignKey(d => d.IdPlataforma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuimicaPlataformas_Infraestructuras_IdInfraestructuras");
            });

            modelBuilder.Entity<Reactivos>(entity =>
            {
                entity.HasKey(e => e.IdReactivos)
                    .HasName("PK_IdReactivos");

                entity.HasIndex(e => new { e.Reactivo, e.Unidad })
                    .HasName("UK_Reactivos")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reactivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reinyeccion>(entity =>
            {
                entity.HasKey(e => e.IdReinyeccion)
                    .HasName("PK_IdReinyeccion");

                entity.HasIndex(e => new { e.IdSistemasSubsitemas, e.Fecha })
                    .HasName("UK_Reinyeccion")
                    .IsUnique();

                entity.Property(e => e.EvapAreaExpuestaM3dia)
                    .HasColumnName("EvapAreaExpuesta_m3dia")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.EvapAreaImpM3dia)
                    .HasColumnName("EvapAreaImp_m3dia")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistemasSubsitemas).HasColumnName("IdSistemas_Subsitemas");

                entity.Property(e => e.SalmueraInfiltradaM3dia)
                    .HasColumnName("SalmueraInfiltrada_m3dia")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.Reinyeccion)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasSubsitemasNavigation)
                    .WithMany(p => p.Reinyeccion)
                    .HasForeignKey(d => d.IdSistemasSubsitemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reinyeccion_IdSistemas_Subsitemas");
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreReservorio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RiegoPlataformas>(entity =>
            {
                entity.HasKey(e => e.IdRiegoPlataformas)
                    .HasName("PK_IdRiegoPlataformas");

                entity.HasIndex(e => e.IdPeriodos)
                    .HasName("UK_RiegoPlataformas");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolConsumoH2oM3)
                    .HasColumnName("VolConsumoH2O_m3")
                    .HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.RiegoPlataformas)
                    .HasForeignKey(d => d.IdPeriodos)
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

                entity.HasOne(d => d.IdDatosEnListaNavigation)
                    .WithMany(p => p.SchemaColumnsWarning)
                    .HasForeignKey(d => d.IdDatosEnLista)
                    .HasConstraintName("FK_SchemaColumnsWarning_IdDatosEnLista");

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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SistemasSubSistemas>(entity =>
            {
                entity.HasKey(e => e.IdSistemasSubsistemas)
                    .HasName("PK_Sistemas_SubSistemas_IdSistemas_Subsistemas2")
                    .IsClustered(false);

                entity.ToTable("Sistemas_SubSistemas");

                entity.HasIndex(e => new { e.IdSistemas, e.IdSubSistemas })
                    .HasName("UK_Sistemas_SubSistemas")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSistemasNavigation)
                    .WithMany(p => p.SistemasSubSistemas)
                    .HasForeignKey(d => d.IdSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSubSistemasNavigation)
                    .WithMany(p => p.SistemasSubSistemas)
                    .HasForeignKey(d => d.IdSubSistemas);
            });

            modelBuilder.Entity<SubSistemas>(entity =>
            {
                entity.HasKey(e => e.IdSubSistemas)
                    .HasName("PK_Subsistemas_IdSubsistemas");

                entity.HasIndex(e => e.SubSistema)
                    .HasName("UK_Subsistemas_Subsistemas")
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

                entity.Property(e => e.SubSistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuscripcionEventos>(entity =>
            {
                entity.HasKey(e => e.IdSuscripcionEventos)
                    .HasName("PK_SuscripcionEventos_IdSuscripcionEvento");

                entity.ToTable("SuscripcionEventos", "internals");

                entity.HasOne(d => d.IdEventosNavigation)
                    .WithMany(p => p.SuscripcionEventos)
                    .HasForeignKey(d => d.IdEventos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.SuscripcionEventos)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TasaEvaporacion>(entity =>
            {
                entity.HasKey(e => e.IdTasaEvaporacion)
                    .HasName("PK_IdTasaEvaporacion");

                entity.HasIndex(e => new { e.IdSistemas, e.Fecha })
                    .HasName("UK_TasaEvaporacion")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TasaEvaporacionMmdia)
                    .HasColumnName("TasaEvaporacion_mmdia")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.TasaEvaporacion)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSistemasNavigation)
                    .WithMany(p => p.TasaEvaporacion)
                    .HasForeignKey(d => d.IdSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TipoInfraestructuras>(entity =>
            {
                entity.HasKey(e => e.IdTipoInfraestructuras)
                    .HasName("PK_TipoInfraestructuras_IdTipoInfraestructuras");

                entity.HasIndex(e => e.TipoInfraestructura)
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

                entity.Property(e => e.TipoInfraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPci>(entity =>
            {
                entity.HasKey(e => e.IdTipoPci)
                    .HasName("PK_IdTipoPCI");

                entity.ToTable("TipoPCI");

                entity.HasIndex(e => e.TipoPci1)
                    .HasName("UK_TipoPCI")
                    .IsUnique();

                entity.Property(e => e.IdTipoPci).HasColumnName("IdTipoPCI");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoPci1)
                    .IsRequired()
                    .HasColumnName("TipoPCI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoSal>(entity =>
            {
                entity.HasKey(e => e.IdTipoSal)
                    .HasName("PK_IdTipoSal");

                entity.HasIndex(e => e.TipoSal1)
                    .HasName("UK_TipoSal")
                    .IsUnique();

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoSal1)
                    .IsRequired()
                    .HasColumnName("TipoSal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposInventario>(entity =>
            {
                entity.HasKey(e => e.IdTiposInventario)
                    .HasName("PK_IdTiposInventario");

                entity.HasIndex(e => e.TipoInventario)
                    .HasName("UK_TiposInventario")
                    .IsUnique();

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoInventario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
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

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubsistemaOrigen)
                    .IsRequired()
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.TransSistemasCosechas)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TraspasosPlataformas>(entity =>
            {
                entity.HasKey(e => e.IdTraspasosPlataformas)
                    .HasName("PK_IdTraspasoPlataforma");

                entity.HasIndex(e => new { e.IdPlataforma, e.Fecha })
                    .HasName("UK_TraspasosPlataformas")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImpregnacionInicial).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LitioInicialPct)
                    .HasColumnName("LitioInicial_pct")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolAguaM3)
                    .HasColumnName("VolAgua_m3")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.VolSalM3)
                    .HasColumnName("VolSal_m3")
                    .HasColumnType("decimal(19, 0)");

                entity.Property(e => e.VolSalmueraM3)
                    .HasColumnName("VolSalmuera_m3")
                    .HasColumnType("decimal(19, 0)");

                entity.HasOne(d => d.IdInfraestructuraDestinoNavigation)
                    .WithMany(p => p.TraspasosPlataformasIdInfraestructuraDestinoNavigation)
                    .HasForeignKey(d => d.IdInfraestructuraDestino)
                    .HasConstraintName("FK_TraspasosPlataformas_IdInfraestructuraDestino");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.TraspasosPlataformas)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPlataformaNavigation)
                    .WithMany(p => p.TraspasosPlataformasIdPlataformaNavigation)
                    .HasForeignKey(d => d.IdPlataforma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraspasosPlataformas_Infraestructuras_IdInfraestructuras");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PK_Usuarios_IdUsuarios");

                entity.ToTable("Usuarios", "internals");

                entity.HasIndex(e => e.Uid)
                    .HasName("UK_Usuarios_uid")
                    .IsUnique();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<UsuariosPerfilesUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuariosPerfilesUsuario)
                    .HasName("PK_UsuariosPerfilesUsuario_IdUsuariosPerfilesUsuario");

                entity.ToTable("UsuariosPerfilesUsuario", "internals");

                entity.HasIndex(e => new { e.IdPerfilUsuario, e.IdUsuarios })
                    .HasName("UK_UsuariosPerfilesUsuario")
                    .IsUnique();

                entity.HasOne(d => d.IdPerfilUsuarioNavigation)
                    .WithMany(p => p.UsuariosPerfilesUsuario)
                    .HasForeignKey(d => d.IdPerfilUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuariosPerfilesUsuario_PerfilesUsuario");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.UsuariosPerfilesUsuario)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WorkflowItem>(entity =>
            {
                entity.HasKey(e => e.IdWorkflowItem);

                entity.ToTable("WorkflowItem", "internals");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence<int>("TrackingSeq", "AuditLog");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
