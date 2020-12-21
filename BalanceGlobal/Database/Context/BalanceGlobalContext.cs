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
            Database.SetCommandTimeout(600);
        }

        public BalanceGlobalContext(DbContextOptions<BalanceGlobalContext> options)
            : base(options)
        {
            Database.SetCommandTimeout(600);
        }

        //Queries
        public virtual DbSet<WorkFlowItemQuery> WorkFlowItemQuery { get; set; }
        public virtual DbSet<UltimosPeriodosTablasDatos> UltimosPeriodosTablasDatos { get; set; }

        #region DbSet
        public virtual DbSet<PueblaTablaReporteBalanceLogEjecucion> PueblaTablaReporteBalanceLogEjecucion { get; set; }
        public virtual DbSet<Aliases> Aliases { get; set; }
        public virtual DbSet<Bgajustes> Bgajustes { get; set; }
        public virtual DbSet<Bgclasificacion> Bgclasificacion { get; set; }
        public virtual DbSet<Bgcorrientes> Bgcorrientes { get; set; }
        public virtual DbSet<Bgtipos> Bgtipos { get; set; }
        public virtual DbSet<Bombas> Bombas { get; set; }
        public virtual DbSet<CargaPlataformas> CargaPlataformas { get; set; }
        public virtual DbSet<CatalogoTablas> CatalogoTablas { get; set; }
        public virtual DbSet<CatalogoTablasFiltros> CatalogoTablasFiltros { get; set; }
        public virtual DbSet<CatalogoVistas> CatalogoVistas { get; set; }
        public virtual DbSet<CategoriaConsumoAgua> CategoriaConsumoAgua { get; set; }
        public virtual DbSet<ChangeTrackingDetail> ChangeTrackingDetail { get; set; }
        public virtual DbSet<ChangeTrackingHeader> ChangeTrackingHeader { get; set; }
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
        public virtual DbSet<Ctcatalog> Ctcatalog { get; set; }
        public virtual DbSet<DataAliases> DataAliases { get; set; }
        public virtual DbSet<DataCategoriasConsumo> DataCategoriasConsumo { get; set; }
        public virtual DbSet<DataConceptoConsumoEnergetico> DataConceptoConsumoEnergetico { get; set; }
        public virtual DbSet<DataConsInvSalardelCarmen> DataConsInvSalardelCarmen { get; set; }
        public virtual DbSet<DataConsRilesyRises> DataConsRilesyRises { get; set; }
        public virtual DbSet<DataConsumoAgua> DataConsumoAgua { get; set; }
        public virtual DbSet<DataConsumoEnergetico> DataConsumoEnergetico { get; set; }
        public virtual DbSet<DataConsumoEnergeticoNuevo> DataConsumoEnergeticoNuevo { get; set; }
        public virtual DbSet<DataCosechas06> DataCosechas06 { get; set; }
        public virtual DbSet<DataCosechasSistemaCambiado> DataCosechasSistemaCambiado { get; set; }
        public virtual DbSet<DataDfSchema> DataDfSchema { get; set; }
        public virtual DbSet<DataEvaporacionPermeabilidad> DataEvaporacionPermeabilidad { get; set; }
        public virtual DbSet<DataEvaporacionTasa> DataEvaporacionTasa { get; set; }
        public virtual DbSet<DataEvaporacionUpv> DataEvaporacionUpv { get; set; }
        public virtual DbSet<DataExtraccion> DataExtraccion { get; set; }
        public virtual DbSet<DataExtraccionAgua> DataExtraccionAgua { get; set; }
        public virtual DbSet<DataFaena> DataFaena { get; set; }
        public virtual DbSet<DataGruposConsumoEnergetico> DataGruposConsumoEnergetico { get; set; }
        public virtual DbSet<DataImpregnacionCosechas> DataImpregnacionCosechas { get; set; }
        public virtual DbSet<DataImpregnacionRef> DataImpregnacionRef { get; set; }
        public virtual DbSet<DataInfraestructurasExtraccion> DataInfraestructurasExtraccion { get; set; }
        public virtual DbSet<DataInvAnatacamaConsInv> DataInvAnatacamaConsInv { get; set; }
        public virtual DbSet<DataOperaPozas> DataOperaPozas { get; set; }
        public virtual DbSet<DataPciAcopioCli> DataPciAcopioCli { get; set; }
        public virtual DbSet<DataPciFechasdeOrigen> DataPciFechasdeOrigen { get; set; }
        public virtual DbSet<DataPciModos> DataPciModos { get; set; }
        public virtual DbSet<DataPciModosDiccionario> DataPciModosDiccionario { get; set; }
        public virtual DbSet<DataPeriodosOperacionales> DataPeriodosOperacionales { get; set; }
        public virtual DbSet<DataPlantaConsLiOh> DataPlantaConsLiOh { get; set; }
        public virtual DbSet<DataPlataformasCarga> DataPlataformasCarga { get; set; }
        public virtual DbSet<DataPlataformasDescarga> DataPlataformasDescarga { get; set; }
        public virtual DbSet<DataPlataformasInfo> DataPlataformasInfo { get; set; }
        public virtual DbSet<DataPlataformasQuimica> DataPlataformasQuimica { get; set; }
        public virtual DbSet<DataPlataformasRiego> DataPlataformasRiego { get; set; }
        public virtual DbSet<DataPodCarmenDatosIgs1> DataPodCarmenDatosIgs1 { get; set; }
        public virtual DbSet<DataPodCarmenDatosIgs2> DataPodCarmenDatosIgs2 { get; set; }
        public virtual DbSet<DataProduccionPotasioConsProdK> DataProduccionPotasioConsProdK { get; set; }
        public virtual DbSet<DataProduccionPotasioConsProdK1> DataProduccionPotasioConsProdK1 { get; set; }
        public virtual DbSet<DataProduccionPotasioDic> DataProduccionPotasioDic { get; set; }
        public virtual DbSet<DataProduccionesCarmenFlexitank> DataProduccionesCarmenFlexitank { get; set; }
        public virtual DbSet<DataReactivos> DataReactivos { get; set; }
        public virtual DbSet<DataReinyeccionDatos1> DataReinyeccionDatos1 { get; set; }
        public virtual DbSet<DataReinyeccionDatos1Old> DataReinyeccionDatos1Old { get; set; }
        public virtual DbSet<DataReinyeccionDatos2> DataReinyeccionDatos2 { get; set; }
        public virtual DbSet<DataReinyeccionDatos2Old> DataReinyeccionDatos2Old { get; set; }
        public virtual DbSet<DataReinyeccionFlujos> DataReinyeccionFlujos { get; set; }
        public virtual DbSet<DataRilesyRises> DataRilesyRises { get; set; }
        public virtual DbSet<DataSistemaFaena> DataSistemaFaena { get; set; }
        public virtual DbSet<DataSolicionLitioConsDespacho> DataSolicionLitioConsDespacho { get; set; }
        public virtual DbSet<DataSolicionLitioConsLi2Co3> DataSolicionLitioConsLi2Co3 { get; set; }
        public virtual DbSet<DataSubsistemaSistema> DataSubsistemaSistema { get; set; }
        public virtual DbSet<DataTraspasosReiyeccionCkmopiiaPorteo> DataTraspasosReiyeccionCkmopiiaPorteo { get; set; }
        public virtual DbSet<DataTraspasosReiyeccionHoja2> DataTraspasosReiyeccionHoja2 { get; set; }
        public virtual DbSet<DatosEnLista> DatosEnLista { get; set; }
        public virtual DbSet<DatosReporteBalanceSubSistema> DatosReporteBalanceSubSistema { get; set; }
        public virtual DbSet<DefImport> DefImport { get; set; }
        public virtual DbSet<DescargaInfraestructurasDestino> DescargaInfraestructurasDestino { get; set; }
        public virtual DbSet<DescargaPlataformas> DescargaPlataformas { get; set; }
        public virtual DbSet<DestinationNovt> DestinationNovt { get; set; }
        public virtual DbSet<DestinationVt> DestinationVt { get; set; }
        public virtual DbSet<DetallePerfil> DetallePerfil { get; set; }
        public virtual DbSet<EvaporacionInfiltracion> EvaporacionInfiltracion { get; set; }
        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<Extraccion> Extraccion { get; set; }
        public virtual DbSet<ExtraccionAgua> ExtraccionAgua { get; set; }
        public virtual DbSet<FactoresImpregnacion> FactoresImpregnacion { get; set; }
        public virtual DbSet<Faenas> Faenas { get; set; }
        public virtual DbSet<FaenasSistemas> FaenasSistemas { get; set; }
        public virtual DbSet<Flujos> Flujos { get; set; }
        public virtual DbSet<GvCargaPlataformas> GvCargaPlataformas { get; set; }
        public virtual DbSet<GvCkmopIiquimaPorteo> GvCkmopIiquimaPorteo { get; set; }
        public virtual DbSet<GvCkmopIivolaPorteo> GvCkmopIivolaPorteo { get; set; }
        public virtual DbSet<GvConsDespacho> GvConsDespacho { get; set; }
        public virtual DbSet<GvConsInvCarmen> GvConsInvCarmen { get; set; }
        public virtual DbSet<GvConsLi2Co3> GvConsLi2Co3 { get; set; }
        public virtual DbSet<GvConsLitioLiCo3mensual> GvConsLitioLiCo3mensual { get; set; }
        public virtual DbSet<GvConsPlantaLiOh> GvConsPlantaLiOh { get; set; }
        public virtual DbSet<GvConsReactivos> GvConsReactivos { get; set; }
        public virtual DbSet<GvConsRilesyRises> GvConsRilesyRises { get; set; }
        public virtual DbSet<GvConsumoAgua> GvConsumoAgua { get; set; }
        public virtual DbSet<GvConsumoEnergetico> GvConsumoEnergetico { get; set; }
        public virtual DbSet<GvCosechas> GvCosechas { get; set; }
        public virtual DbSet<GvDataCkmopIiquimaPorteo> GvDataCkmopIiquimaPorteo { get; set; }
        public virtual DbSet<GvDataCkmopIivolaPorteo> GvDataCkmopIivolaPorteo { get; set; }
        public virtual DbSet<GvDataCkvolyQuimicaaPorteo> GvDataCkvolyQuimicaaPorteo { get; set; }
        public virtual DbSet<GvDataConsDespacho> GvDataConsDespacho { get; set; }
        public virtual DbSet<GvDataConsInvCarmen> GvDataConsInvCarmen { get; set; }
        public virtual DbSet<GvDataConsLi2Co3> GvDataConsLi2Co3 { get; set; }
        public virtual DbSet<GvDataConsPlantaLiOh> GvDataConsPlantaLiOh { get; set; }
        public virtual DbSet<GvDataConsReactivos> GvDataConsReactivos { get; set; }
        public virtual DbSet<GvDataConsumoAgua> GvDataConsumoAgua { get; set; }
        public virtual DbSet<GvDataConsumoEnergetico> GvDataConsumoEnergetico { get; set; }
        public virtual DbSet<GvDataDescargaPlataformas> GvDataDescargaPlataformas { get; set; }
        public virtual DbSet<GvDataEvaporacionInfiltracion> GvDataEvaporacionInfiltracion { get; set; }
        public virtual DbSet<GvDataExtraccionAgua> GvDataExtraccionAgua { get; set; }
        public virtual DbSet<GvDataExtraccionSalmuera> GvDataExtraccionSalmuera { get; set; }
        public virtual DbSet<GvDataFlujos> GvDataFlujos { get; set; }
        public virtual DbSet<GvDataImpregnacionCosechas> GvDataImpregnacionCosechas { get; set; }
        public virtual DbSet<GvDataInfraestructuras> GvDataInfraestructuras { get; set; }
        public virtual DbSet<GvDataInfraestructurasReinyeccion> GvDataInfraestructurasReinyeccion { get; set; }
        public virtual DbSet<GvDataInventariosAtacama> GvDataInventariosAtacama { get; set; }
        public virtual DbSet<GvDataModosPci> GvDataModosPci { get; set; }
        public virtual DbSet<GvDataPciacopiosOrigen> GvDataPciacopiosOrigen { get; set; }
        public virtual DbSet<GvDataPeriodosOperacionales> GvDataPeriodosOperacionales { get; set; }
        public virtual DbSet<GvDataPermeabilidad> GvDataPermeabilidad { get; set; }
        public virtual DbSet<GvDataPorteo> GvDataPorteo { get; set; }
        public virtual DbSet<GvDataProdyDespSdeAconsProdK> GvDataProdyDespSdeAconsProdK { get; set; }
        public virtual DbSet<GvDataProdyDespSdeAconsProdK1> GvDataProdyDespSdeAconsProdK1 { get; set; }
        public virtual DbSet<GvDataQuimicaPlataformas> GvDataQuimicaPlataformas { get; set; }
        public virtual DbSet<GvDataReinyeccion> GvDataReinyeccion { get; set; }
        public virtual DbSet<GvDataRiegoPlataformas> GvDataRiegoPlataformas { get; set; }
        public virtual DbSet<GvDataRilesyRises> GvDataRilesyRises { get; set; }
        public virtual DbSet<GvDataTasaEvaporacion> GvDataTasaEvaporacion { get; set; }
        public virtual DbSet<GvDataTraspasoPlataformas> GvDataTraspasoPlataformas { get; set; }
        public virtual DbSet<GvDataTraspasoSubsistemas> GvDataTraspasoSubsistemas { get; set; }
        public virtual DbSet<GvDescargaPlataformas> GvDescargaPlataformas { get; set; }
        public virtual DbSet<GvEvaporacionInfiltracion> GvEvaporacionInfiltracion { get; set; }
        public virtual DbSet<GvExtraccion> GvExtraccion { get; set; }
        public virtual DbSet<GvExtraccionAgua> GvExtraccionAgua { get; set; }
        public virtual DbSet<GvFlujos> GvFlujos { get; set; }
        public virtual DbSet<GvImpregnacionCosechas> GvImpregnacionCosechas { get; set; }
        public virtual DbSet<GvInventariosAtacama> GvInventariosAtacama { get; set; }
        public virtual DbSet<GvListadoInfraestructuraComponentesPrincipales> GvListadoInfraestructuraComponentesPrincipales { get; set; }
        public virtual DbSet<GvOperaPozas> GvOperaPozas { get; set; }
        public virtual DbSet<GvPciacopiosCli> GvPciacopiosCli { get; set; }
        public virtual DbSet<GvPcimodos> GvPcimodos { get; set; }
        public virtual DbSet<GvPorteos> GvPorteos { get; set; }
        public virtual DbSet<GvProdyDespSdeAconsProdK> GvProdyDespSdeAconsProdK { get; set; }
        public virtual DbSet<GvProdyDespSdeAconsProdK1> GvProdyDespSdeAconsProdK1 { get; set; }
        public virtual DbSet<GvQuimicaPlataformas> GvQuimicaPlataformas { get; set; }
        public virtual DbSet<GvRefCategoriaConsumoAgua> GvRefCategoriaConsumoAgua { get; set; }
        public virtual DbSet<GvRefFaenasSistemas> GvRefFaenasSistemas { get; set; }
        public virtual DbSet<GvRefSistemasSubsistemas> GvRefSistemasSubsistemas { get; set; }
        public virtual DbSet<GvReinyeccion> GvReinyeccion { get; set; }
        public virtual DbSet<GvRepInventarioAtacamaDelta> GvRepInventarioAtacamaDelta { get; set; }
        public virtual DbSet<GvReportAguaDilucionPeriodoCalendario> GvReportAguaDilucionPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportAguaDilucionPeriodoOperacional> GvReportAguaDilucionPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportAguaLitioPataformaPeriodoOperacional> GvReportAguaLitioPataformaPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportCamionesCarnalitaLiPeriodoOperacional> GvReportCamionesCarnalitaLiPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportCargaPlataformaPeriodoCalendario> GvReportCargaPlataformaPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportCargaPlataformaPeriodoOperacional> GvReportCargaPlataformaPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportCosechaImpregnacionBischofitaPeriodoOperacional> GvReportCosechaImpregnacionBischofitaPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportCosechaImprgCliPciperiodoOperacional> GvReportCosechaImprgCliPciperiodoOperacional { get; set; }
        public virtual DbSet<GvReportCosechaPciperiodoOperacional> GvReportCosechaPciperiodoOperacional { get; set; }
        public virtual DbSet<GvReportCosechas> GvReportCosechas { get; set; }
        public virtual DbSet<GvReportCragaPlataformaPeriodoCalendario> GvReportCragaPlataformaPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportDeltaInventarioAtacamaPeriodoCalendario> GvReportDeltaInventarioAtacamaPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportDeltaInventarioAtacamaPeriodoOperacional> GvReportDeltaInventarioAtacamaPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportDeltaInventarioPlataformaPeriodoOperacional> GvReportDeltaInventarioPlataformaPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportDeltaInvetarioAcopioPciperiodoOperacional> GvReportDeltaInvetarioAcopioPciperiodoOperacional { get; set; }
        public virtual DbSet<GvReportDescargaPlataforma> GvReportDescargaPlataforma { get; set; }
        public virtual DbSet<GvReportDescargaPlataformasPeriodoCalendario> GvReportDescargaPlataformasPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportDescargaPlataformasPeriodoOperacional> GvReportDescargaPlataformasPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportEntradaAcopioPciperiodoOperacional> GvReportEntradaAcopioPciperiodoOperacional { get; set; }
        public virtual DbSet<GvReportEvaporacionPeriodoCalendario> GvReportEvaporacionPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportEvaporacionPeriodoOperacional> GvReportEvaporacionPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportExtraccionMopiireinyecionPeriodoOperacional> GvReportExtraccionMopiireinyecionPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportExtraccionPeriodoCalendario> GvReportExtraccionPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportExtraccionPeriodoOperacional> GvReportExtraccionPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportFlujosPorteoAjuste> GvReportFlujosPorteoAjuste { get; set; }
        public virtual DbSet<GvReportImpregnacionCosechaPciperiodoOperacional> GvReportImpregnacionCosechaPciperiodoOperacional { get; set; }
        public virtual DbSet<GvReportImpregnacionCosechaPeriodoCalendario> GvReportImpregnacionCosechaPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportImpregnacionCosechaPeriodoOperacional> GvReportImpregnacionCosechaPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportImpregnacionPeriodoOperacional> GvReportImpregnacionPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportInfiltracion> GvReportInfiltracion { get; set; }
        public virtual DbSet<GvReportInfiltracionMensual> GvReportInfiltracionMensual { get; set; }
        public virtual DbSet<GvReportInfiltracionMensual2> GvReportInfiltracionMensual2 { get; set; }
        public virtual DbSet<GvReportInfoPlataformas> GvReportInfoPlataformas { get; set; }
        public virtual DbSet<GvReportInfoPlataformasPeriodoCalendario> GvReportInfoPlataformasPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportInfoPlataformasPeriodoOperacional> GvReportInfoPlataformasPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportLitioPlataformaCosechaImpgPlataformaPeriodoOperacional> GvReportLitioPlataformaCosechaImpgPlataformaPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportReinyeccionIndirectaQuimica> GvReportReinyeccionIndirectaQuimica { get; set; }
        public virtual DbSet<GvReportReinyeccionSalmueraPeriodoCalendario> GvReportReinyeccionSalmueraPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportReinyeccionSalmueraPeriodoOperacional> GvReportReinyeccionSalmueraPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportSalidaMopIidpsperiodoOperacional> GvReportSalidaMopIidpsperiodoOperacional { get; set; }
        public virtual DbSet<GvReportSalidaMopIireinyeccionPeriodoOperacional> GvReportSalidaMopIireinyeccionPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportTraspasoEntradaMopiireinyeccionPeriodoOperacional> GvReportTraspasoEntradaMopiireinyeccionPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportTraspasoSalesPlantaMopiireinyeccionPeriodoOperacional> GvReportTraspasoSalesPlantaMopiireinyeccionPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportTraspasoSalidaMopiicarnalitaAsperiodoOperacional> GvReportTraspasoSalidaMopiicarnalitaAsperiodoOperacional { get; set; }
        public virtual DbSet<GvReportTraspasoSubSitemasEntradaPeriodoCalendario> GvReportTraspasoSubSitemasEntradaPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportTraspasoSubSitemasEntradaPeriodoOperacional> GvReportTraspasoSubSitemasEntradaPeriodoOperacional { get; set; }
        public virtual DbSet<GvReportTraspasoSubSitemasSalidaPeriodoCalendario> GvReportTraspasoSubSitemasSalidaPeriodoCalendario { get; set; }
        public virtual DbSet<GvReportTraspasoSubSitemasSalidaPeriodoOperacional> GvReportTraspasoSubSitemasSalidaPeriodoOperacional { get; set; }
        public virtual DbSet<GvRiegoPlataformas> GvRiegoPlataformas { get; set; }
        public virtual DbSet<GvSistemasPorInfraestructuraPeriodo> GvSistemasPorInfraestructuraPeriodo { get; set; }
        public virtual DbSet<GvSubsistemasPorInfraestructuraPeriodoSistema> GvSubsistemasPorInfraestructuraPeriodoSistema { get; set; }
        public virtual DbSet<GvTasaEvaporacion> GvTasaEvaporacion { get; set; }
        public virtual DbSet<GvTraspasosPlataformas> GvTraspasosPlataformas { get; set; }
        public virtual DbSet<GvdataCargaPlataforma> GvdataCargaPlataforma { get; set; }
        public virtual DbSet<GvdataConsLitioLiCo3mensual> GvdataConsLitioLiCo3mensual { get; set; }
        public virtual DbSet<GvdataCosechas> GvdataCosechas { get; set; }
        public virtual DbSet<GvdataEvaporacionPreCalculo> GvdataEvaporacionPreCalculo { get; set; }
        public virtual DbSet<GvdataPciacopioCli> GvdataPciacopioCli { get; set; }
        public virtual DbSet<GvdataPciacopioCliFechaOrigen> GvdataPciacopioCliFechaOrigen { get; set; }
        public virtual DbSet<GvrefExtraccionInfraestructurasReinyeccion> GvrefExtraccionInfraestructurasReinyeccion { get; set; }
        public virtual DbSet<GvrepCkmopIivolaPorteOperacional> GvrepCkmopIivolaPorteOperacional { get; set; }
        public virtual DbSet<GvrepCkmopIivolaPorteoCalendario> GvrepCkmopIivolaPorteoCalendario { get; set; }
        public virtual DbSet<GvrepPciacopiosCliResumen> GvrepPciacopiosCliResumen { get; set; }
        public virtual DbSet<GvreportCargaPlataformas> GvreportCargaPlataformas { get; set; }
        public virtual DbSet<GvreportConsDespachoCalendario> GvreportConsDespachoCalendario { get; set; }
        public virtual DbSet<GvreportConsDespachoOperacional> GvreportConsDespachoOperacional { get; set; }
        public virtual DbSet<GvreportConsumoAgua> GvreportConsumoAgua { get; set; }
        public virtual DbSet<GvreportConsumoAguaPvt> GvreportConsumoAguaPvt { get; set; }
        public virtual DbSet<GvreportCosechasPeriodoCalendario> GvreportCosechasPeriodoCalendario { get; set; }
        public virtual DbSet<GvreportCosechasPeriodoOperacional> GvreportCosechasPeriodoOperacional { get; set; }
        public virtual DbSet<GvreportDeltaInventarioAcopioPlataformasTraspasoPlataformasPeriodoOpercional> GvreportDeltaInventarioAcopioPlataformasTraspasoPlataformasPeriodoOpercional { get; set; }
        public virtual DbSet<GvreportFlujos> GvreportFlujos { get; set; }
        public virtual DbSet<GvreportReinyeccionBalance> GvreportReinyeccionBalance { get; set; }
        public virtual DbSet<GvreportReinyeccionDpsperiodoCalendario> GvreportReinyeccionDpsperiodoCalendario { get; set; }
        public virtual DbSet<GvreportReinyeccionDpsperiodoOperacional> GvreportReinyeccionDpsperiodoOperacional { get; set; }
        public virtual DbSet<GvreportReinyeccionPreBalance> GvreportReinyeccionPreBalance { get; set; }
        public virtual DbSet<GvreporteEvaporacionPeriodo> GvreporteEvaporacionPeriodo { get; set; }
        public virtual DbSet<GvreporteEvaporacionPeriodoCalendario> GvreporteEvaporacionPeriodoCalendario { get; set; }
        public virtual DbSet<GvreporteEvaporacionPeriodoOperacional> GvreporteEvaporacionPeriodoOperacional { get; set; }
        public virtual DbSet<GvreporteEvaporacionPeriodoOperacional2> GvreporteEvaporacionPeriodoOperacional2 { get; set; }
        public virtual DbSet<IckmopIivolaPorteo> IckmopIivolaPorteo { get; set; }
        public virtual DbSet<Icosechas> Icosechas { get; set; }
        public virtual DbSet<IdiomaFecha> IdiomaFecha { get; set; }
        public virtual DbSet<Iextraccion> Iextraccion { get; set; }
        public virtual DbSet<IimpregnacionCosechas> IimpregnacionCosechas { get; set; }
        public virtual DbSet<IinventariosAtacama> IinventariosAtacama { get; set; }
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
        public virtual DbSet<ItasaEvaporacion> ItasaEvaporacion { get; set; }
        public virtual DbSet<JobTipo> JobTipo { get; set; }
        public virtual DbSet<Localizaciones> Localizaciones { get; set; }
        public virtual DbSet<Mensajes> Mensajes { get; set; }
        public virtual DbSet<MensajesImportacion> MensajesImportacion { get; set; }
        public virtual DbSet<MensajesImportacionTemp> MensajesImportacionTemp { get; set; }
        public virtual DbSet<MeteorologíaSalarNuevaJunioKcl2020> MeteorologíaSalarNuevaJunioKcl2020 { get; set; }
        public virtual DbSet<ModalidadPci> ModalidadPci { get; set; }
        public virtual DbSet<ModalidadPlantas> ModalidadPlantas { get; set; }
        public virtual DbSet<MultiAliases> MultiAliases { get; set; }
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
        public virtual DbSet<SourceNovt> SourceNovt { get; set; }
        public virtual DbSet<SourceVt> SourceVt { get; set; }
        public virtual DbSet<SubSistemas> SubSistemas { get; set; }
        public virtual DbSet<SuscripcionEventos> SuscripcionEventos { get; set; }
        public virtual DbSet<TasaEvaporacion> TasaEvaporacion { get; set; }
        public virtual DbSet<TipoDatoColOrigen> TipoDatoColOrigen { get; set; }
        public virtual DbSet<TipoDatoControl> TipoDatoControl { get; set; }
        public virtual DbSet<TipoHeader> TipoHeader { get; set; }
        public virtual DbSet<TipoInfraestructuras> TipoInfraestructuras { get; set; }
        public virtual DbSet<TipoMensaje> TipoMensaje { get; set; }
        public virtual DbSet<TipoOrigen> TipoOrigen { get; set; }
        public virtual DbSet<TipoPci> TipoPci { get; set; }
        public virtual DbSet<TipoSal> TipoSal { get; set; }
        public virtual DbSet<TiposInventario> TiposInventario { get; set; }
        public virtual DbSet<TransSistemasCosechas> TransSistemasCosechas { get; set; }
        public virtual DbSet<TraspasosPlataformas> TraspasosPlataformas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosPerfilesUsuario> UsuariosPerfilesUsuario { get; set; }
        public virtual DbSet<WorkflowItem> WorkflowItem { get; set; }

        #endregion
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

            modelBuilder.Entity<Bgajustes>(entity =>
            {
                entity.HasKey(e => e.IdBgajustes)
                    .HasName("PK_BGAjustes_IdBGAjustes");

                entity.ToTable("BGAjustes");

                entity.HasIndex(e => new { e.IdPeriodos, e.IdBgtipos, e.IdSistemasSubSitemas, e.IdFaena, e.IdInfraestructuras, e.IdBgcorrientes })
                    .HasName("UK_BGAjustes")
                    .IsUnique();

                entity.Property(e => e.IdBgajustes).HasColumnName("IdBGAjustes");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasDefaultValueSql("((0))");

                entity.Property(e => e.H2oTon)
                    .HasColumnName("H2O_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.IdBgclasificacion).HasColumnName("IdBGClasificacion");

                entity.Property(e => e.IdBgcorrientes).HasColumnName("IdBGCorrientes");

                entity.Property(e => e.IdBgtipos).HasColumnName("IdBGTipos");

                entity.Property(e => e.IdSistemasSubSitemas).HasColumnName("IdSistemas_SubSitemas");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.HasOne(d => d.IdBgclasificacionNavigation)
                    .WithMany(p => p.Bgajustes)
                    .HasForeignKey(d => d.IdBgclasificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdBgcorrientesNavigation)
                    .WithMany(p => p.Bgajustes)
                    .HasForeignKey(d => d.IdBgcorrientes)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdBgtiposNavigation)
                    .WithMany(p => p.Bgajustes)
                    .HasForeignKey(d => d.IdBgtipos)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdFaenaNavigation)
                    .WithMany(p => p.Bgajustes)
                    .HasForeignKey(d => d.IdFaena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BGAjustes_IdFaena");

                entity.HasOne(d => d.IdInfraestructurasNavigation)
                    .WithMany(p => p.Bgajustes)
                    .HasForeignKey(d => d.IdInfraestructuras)
                    .HasConstraintName("FK_BGAjustes_IdInfraestructuras");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.Bgajustes)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BGAjustes_IdPeriodos");

                entity.HasOne(d => d.IdSistemasSubSitemasNavigation)
                    .WithMany(p => p.Bgajustes)
                    .HasForeignKey(d => d.IdSistemasSubSitemas)
                    .HasConstraintName("FK_BGAjustes_IdSistemas_SubSitemas");
            });

            modelBuilder.Entity<Bgclasificacion>(entity =>
            {
                entity.HasKey(e => e.IdBgclasificacion)
                    .HasName("PK_BGClasificacion_IdBGClasificacion");

                entity.ToTable("BGClasificacion");

                entity.HasIndex(e => e.Clasificacion)
                    .HasName("UK_BGClasificacion_Clasificacion")
                    .IsUnique();

                entity.Property(e => e.IdBgclasificacion).HasColumnName("IdBGClasificacion");

                entity.Property(e => e.Activa).HasDefaultValueSql("((1))");

                entity.Property(e => e.Clasificacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bgcorrientes>(entity =>
            {
                entity.HasKey(e => e.IdBgcorrientes)
                    .HasName("PK_BGCorrientes_IdBGCorrientes");

                entity.ToTable("BGCorrientes");

                entity.HasIndex(e => e.Bgcorriente)
                    .HasName("UK_BGCorrientes_BGCorriente")
                    .IsUnique();

                entity.Property(e => e.IdBgcorrientes).HasColumnName("IdBGCorrientes");

                entity.Property(e => e.Activa).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bgcorriente)
                    .IsRequired()
                    .HasColumnName("BGCorriente")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bgtipos>(entity =>
            {
                entity.HasKey(e => e.IdBgtipos)
                    .HasName("PK_BGTipo_IdBGTipo");

                entity.ToTable("BGTipos");

                entity.HasIndex(e => e.Tipo)
                    .HasName("UK_BGTipo_Tipo")
                    .IsUnique();

                entity.Property(e => e.IdBgtipos).HasColumnName("IdBGTipos");

                entity.Property(e => e.Activa).HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(100)
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

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

            modelBuilder.Entity<CatalogoTablas>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoTablas)
                    .HasName("PK__Catalogo__C06C05726E158D00");

                entity.Property(e => e.Alias)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Corriente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tabla)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VistaAsociada)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogoTablasFiltros>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoTablasFiltros)
                    .HasName("PK__Catalogo__252DBB09CA078341");

                entity.Property(e => e.Activa).HasDefaultValueSql("((1))");

                entity.Property(e => e.ColumnaDelete)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnaFiltro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFiltro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogoVistas>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoVistas)
                    .HasName("PK_CatalogoVistas_IdCatalogoVistas");

                entity.HasIndex(e => e.Vista)
                    .HasName("UK_CatalogoVistas_Vista")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Origen)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vista)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

                entity.HasOne(d => d.IdFaenasNavigation)
                    .WithMany(p => p.CategoriaConsumoAgua)
                    .HasForeignKey(d => d.IdFaenas)
                    .HasConstraintName("FK_CategoriaConsumoAgua_IdFaenas");

                entity.HasOne(d => d.IdSistemasSubsistemasNavigation)
                    .WithMany(p => p.CategoriaConsumoAgua)
                    .HasForeignKey(d => d.IdSistemasSubsistemas)
                    .HasConstraintName("FK_CategoriaConsumoAgua_IdSistemas_Subsistemas");
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensTonm3)
                    .HasColumnName("Dens_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaDespachadaTon)
                    .HasColumnName("MasaDespachada_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Nrocam).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SoldPct)
                    .HasColumnName("Sold_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.String)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistemasSubSistemas).HasColumnName("IdSistemas_SubSistemas");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaBalanceLceTon)
                    .HasColumnName("MasaBalanceLCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaLceTon)
                    .HasColumnName("MasaLCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Co3Pct)
                    .HasColumnName("CO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensTonm3)
                    .HasColumnName("Dens_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H2oPct)
                    .HasColumnName("H2O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IdCorrienteLi2Co3).HasColumnName("IdCorrienteLi2CO3");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.OhPct)
                    .HasColumnName("OH_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolM3)
                    .HasColumnName("Vol_m3")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCorrienteLi2Co3).HasColumnName("IdCorrienteLi2CO3");

                entity.Property(e => e.IdSistemasSubSistemas).HasColumnName("IdSistemas_SubSistemas");

                entity.Property(e => e.Li2Co3FrescaTon)
                    .HasColumnName("Li2CO3_Fresca_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Li2Co3TotalTon)
                    .HasColumnName("Li2CO3_Total_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LitioFrescoTon)
                    .HasColumnName("Litio_Fresco_ton")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

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

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

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

                entity.HasOne(d => d.IdCategoriaConsumoAguaNavigation)
                    .WithMany(p => p.ConsumoAgua)
                    .HasForeignKey(d => d.IdCategoriaConsumoAgua)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.ConsumoAgua)
                    .HasForeignKey(d => d.IdPeriodos)
                    .OnDelete(DeleteBehavior.ClientSetNull);
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Densidad).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.HumPct)
                    .HasColumnName("Hum_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IdSistemasSubSistemas).HasColumnName("IdSistemas_SubSistemas");

                entity.Property(e => e.ImprgPct)
                    .HasColumnName("Imprg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

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

            modelBuilder.Entity<DataAliases>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Aliases", "migra");

                entity.Property(e => e.Campo).IsUnicode(false);

                entity.Property(e => e.Importador).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.ValorAlias).IsUnicode(false);

                entity.Property(e => e.ValorOriginal).IsUnicode(false);
            });

            modelBuilder.Entity<DataCategoriasConsumo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_CategoriasConsumo", "migra");

                entity.Property(e => e.CategoriaConsumo).IsUnicode(false);

                entity.Property(e => e.Faena).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.Subsistema).IsUnicode(false);
            });

            modelBuilder.Entity<DataConceptoConsumoEnergetico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ConceptoConsumoEnergetico", "migra");

                entity.Property(e => e.Descripción).IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .IsUnicode(false);

                entity.Property(e => e.Um)
                    .HasColumnName("UM")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataConsInvSalardelCarmen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ConsInvSalardelCarmen", "migra");

                entity.Property(e => e.Ca).HasColumnName("Ca %");

                entity.Property(e => e.Cl).HasColumnName("Cl %");

                entity.Property(e => e.Co3).HasColumnName("%CO3");

                entity.Property(e => e.Corriente).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.H2o).HasColumnName("%H2O");

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3");

                entity.Property(e => e.K).HasColumnName("K %");

                entity.Property(e => e.Li).HasColumnName("Li %");

                entity.Property(e => e.Mg).HasColumnName("Mg %");

                entity.Property(e => e.Na).HasColumnName("Na %");

                entity.Property(e => e.Oh).HasColumnName("%OH");

                entity.Property(e => e.Salar).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("SO4 %");

                entity.Property(e => e.TipoDeInventario)
                    .HasColumnName("Tipo de inventario")
                    .IsUnicode(false);

                entity.Property(e => e.TipoDePoza)
                    .HasColumnName("Tipo de poza")
                    .IsUnicode(false);

                entity.Property(e => e.Ton).HasColumnName("ton");

                entity.Property(e => e.TonLce).HasColumnName("Ton LCE");

                entity.Property(e => e.TonLceBalanceDePozas).HasColumnName("TON LCE BALANCE DE POZAS");
            });

            modelBuilder.Entity<DataConsRilesyRises>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ConsRilesyRises", "migra");

                entity.Property(e => e.Ca).HasColumnName("Ca [%]");

                entity.Property(e => e.Cl).HasColumnName("Cl [%]");

                entity.Property(e => e.Corriente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3");

                entity.Property(e => e.K).HasColumnName("K [%]");

                entity.Property(e => e.Li).HasColumnName("Li [%]");

                entity.Property(e => e.MasaTon).HasColumnName("Masa [ton]");

                entity.Property(e => e.Mg).HasColumnName("Mg [%]");

                entity.Property(e => e.Na).HasColumnName("Na [%]");

                entity.Property(e => e.Salar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("SO4 [%]");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataConsumoAgua>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ConsumoAgua", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.GrupoReporte).IsUnicode(false);

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.Variable)
                    .HasColumnName("variable")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataConsumoEnergetico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ConsumoEnergetico", "migra");

                entity.Property(e => e.Concepto).HasColumnName("CONCEPTO");

                entity.Property(e => e.Cuenta)
                    .HasColumnName("CUENTA")
                    .IsUnicode(false);

                entity.Property(e => e.Fuente)
                    .HasColumnName("FUENTE")
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .IsUnicode(false);

                entity.Property(e => e.TimeidSap).HasColumnName("TIMEID_SAP");

                entity.Property(e => e.Up)
                    .HasColumnName("UP")
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataConsumoEnergeticoNuevo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ConsumoEnergetico_Nuevo", "migra");

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoD)
                    .HasColumnName("CONCEPTO_D")
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo)
                    .HasColumnName("TIEMPO")
                    .IsUnicode(false);

                entity.Property(e => e.Um)
                    .HasColumnName("UM")
                    .IsUnicode(false);

                entity.Property(e => e.Up)
                    .HasColumnName("UP")
                    .IsUnicode(false);

                entity.Property(e => e.UpD)
                    .HasColumnName("UP_D")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataCorreccionesAjustes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_CorreccionesAjustes", "migra");

                entity.Property(e => e.Buscador).IsUnicode(false);

                entity.Property(e => e.CaTon).HasColumnName("Ca ton");

                entity.Property(e => e.ClTon).HasColumnName("Cl ton");

                entity.Property(e => e.Clasificación).IsUnicode(false);

                entity.Property(e => e.Corrientes).IsUnicode(false);

                entity.Property(e => e.Faena).IsUnicode(false);

                entity.Property(e => e.H2oTon).HasColumnName("H2O ton");

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3 ton");

                entity.Property(e => e.KTon).HasColumnName("K ton");

                entity.Property(e => e.LceTon).HasColumnName("LCE ton");

                entity.Property(e => e.MasaTon).HasColumnName("Masa ton");

                entity.Property(e => e.MgTon).HasColumnName("Mg ton");

                entity.Property(e => e.NaTon).HasColumnName("Na ton");

                entity.Property(e => e.Periodo).HasColumnType("datetime");

                entity.Property(e => e.Poza).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4 ton");

                entity.Property(e => e.Subsistema).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);
            });

            modelBuilder.Entity<DataCosechas06>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Cosechas06", "migra");

                entity.Property(e => e.AlturaDePozasM).HasColumnName("Altura de Pozas (m)");

                entity.Property(e => e.Ca).HasColumnName("% Ca");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.CosechaM3).HasColumnName("Cosecha (m3)");

                entity.Property(e => e.CosechaT).HasColumnName("Cosecha (t)");

                entity.Property(e => e.DensidadTM3).HasColumnName("Densidad (t/m3)");

                entity.Property(e => e.Descripción).IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3");

                entity.Property(e => e.Hum).HasColumnName("HUM");

                entity.Property(e => e.Impreg).HasColumnName("Impreg.");

                entity.Property(e => e.K).HasColumnName("% K");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Na).HasColumnName("% Na");

                entity.Property(e => e.Pozas).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");
            });

            modelBuilder.Entity<DataCosechasSistemaCambiado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_CosechasSistemaCambiado", "migra");

                entity.Property(e => e.AlturaDePozasM)
                    .HasColumnName("Altura de Pozas (m)")
                    .IsUnicode(false);

                entity.Property(e => e.Ca).HasColumnName("% Ca");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.CosechaM3).HasColumnName("Cosecha m3");

                entity.Property(e => e.CosechaTon).HasColumnName("Cosecha Ton");

                entity.Property(e => e.Descripción).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.H3bo3).HasColumnName("% H3BO3");

                entity.Property(e => e.K).HasColumnName("% K");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Na).HasColumnName("% Na");

                entity.Property(e => e.Pozas).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");
            });

            modelBuilder.Entity<DataDfSchema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_DfSchema", "migra");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .IsUnicode(false);

                entity.Property(e => e.IdSchemaDef).IsUnicode(false);

                entity.Property(e => e.IdTipoDatoColOrigen).IsUnicode(false);

                entity.Property(e => e.Importador).IsUnicode(false);

                entity.Property(e => e.NombreCol).IsUnicode(false);

                entity.Property(e => e.Tab).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);
            });

            modelBuilder.Entity<DataEvaporacionPermeabilidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Evaporacion_Permeabilidad", "migra");

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.Subsistema).IsUnicode(false);
            });

            modelBuilder.Entity<DataEvaporacionTasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Evaporacion_Tasa", "migra");

                entity.Property(e => e.Dia)
                    .HasColumnName("dia")
                    .HasColumnType("datetime");

                entity.Property(e => e.EvapMm).HasColumnName("Evap mm");

                entity.Property(e => e.Origen).IsUnicode(false);
            });

            modelBuilder.Entity<DataEvaporacionUpv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Evaporacion_upv", "migra");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Infraestructura).IsUnicode(false);

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.Variable).IsUnicode(false);
            });

            modelBuilder.Entity<DataExtraccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Extraccion", "migra");

                entity.Property(e => e.Ca).HasColumnName("%Ca");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3");

                entity.Property(e => e.K).HasColumnName("%k");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");

                entity.Property(e => e.VolTraspaso).HasColumnName("Vol. Traspaso");
            });

            modelBuilder.Entity<DataExtraccionAgua>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_extraccionAgua", "migra");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.M3H).HasColumnName("m3/h");

                entity.Property(e => e.Origen).IsUnicode(false);
            });

            modelBuilder.Entity<DataFaena>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Faena", "migra");

                entity.Property(e => e.Faena).IsUnicode(false);
            });

            modelBuilder.Entity<DataGruposConsumoEnergetico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_GruposConsumoEnergetico", "migra");

                entity.Property(e => e.Descripción).IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataImpregnacionCosechas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ImpregnacionCosechas", "migra");

                entity.Property(e => e.Ca).HasColumnName("%Ca");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.CosechaM3).HasColumnName("Cosecha m3");

                entity.Property(e => e.CosechaTon).HasColumnName("Cosecha ton");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.H3bo3).HasColumnName("% H3BO3");

                entity.Property(e => e.Hum).HasColumnName("%hum");

                entity.Property(e => e.K).HasColumnName("%K");

                entity.Property(e => e.Li).HasColumnName("%Li");

                entity.Property(e => e.Mg).HasColumnName("%Mg ");

                entity.Property(e => e.NProd)
                    .HasColumnName("N_Prod")
                    .IsUnicode(false);

                entity.Property(e => e.Na).HasColumnName("% Na");

                entity.Property(e => e.Poza).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");
            });

            modelBuilder.Entity<DataImpregnacionRef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ImpregnacionRef", "migra");

                entity.Property(e => e.TipoPoza).IsUnicode(false);
            });

            modelBuilder.Entity<DataInfraestructurasExtraccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Infraestructuras_Extraccion", "migra");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfraestructuraPadre)
                    .HasColumnName("Infraestructura Padre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInfraestructura)
                    .HasColumnName("Tipo Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataInvAnatacamaConsInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_InvAnatacama_ConsInv", "migra");

                entity.Property(e => e.AlturaSalm)
                    .HasColumnName("Altura salm")
                    .IsUnicode(false);

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Ca).IsUnicode(false);

                entity.Property(e => e.Cl)
                    .HasColumnName("% Cl")
                    .IsUnicode(false);

                entity.Property(e => e.Dens).IsUnicode(false);

                entity.Property(e => e.Factor).IsUnicode(false);

                entity.Property(e => e.H3bo3)
                    .HasColumnName("% H3BO3")
                    .IsUnicode(false);

                entity.Property(e => e.K).IsUnicode(false);

                entity.Property(e => e.K2so4Eqv).HasColumnName("K2SO4 eqv");

                entity.Property(e => e.KclEqv).HasColumnName("KCl eqv");

                entity.Property(e => e.Li).IsUnicode(false);

                entity.Property(e => e.Li2Co3Eqv)
                    .HasColumnName("Li2CO3 eqv")
                    .IsUnicode(false);

                entity.Property(e => e.MesInvent)
                    .HasColumnName("Mes Invent")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mg)
                    .HasColumnName("Mg ")
                    .IsUnicode(false);

                entity.Property(e => e.MgCl26h2o).HasColumnName("MgCl2.6H2O");

                entity.Property(e => e.NProducc)
                    .HasColumnName("N_ Producc")
                    .IsUnicode(false);

                entity.Property(e => e.Na)
                    .HasColumnName("% Na")
                    .IsUnicode(false);

                entity.Property(e => e.Pozas).IsUnicode(false);

                entity.Property(e => e.SatK).HasColumnName("Sat. K");

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4)
                    .HasColumnName("SO4")
                    .IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);

                entity.Property(e => e.Ton)
                    .HasColumnName("ton")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataOperaPozas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_OperaPozas", "migra");

                entity.Property(e => e.B)
                    .HasColumnName("%B")
                    .IsUnicode(false);

                entity.Property(e => e.Ca)
                    .HasColumnName("%CA")
                    .IsUnicode(false);

                entity.Property(e => e.Caudal)
                    .HasColumnName("CAUDAL")
                    .IsUnicode(false);

                entity.Property(e => e.Cl)
                    .HasColumnName("%CL")
                    .IsUnicode(false);

                entity.Property(e => e.Densidad)
                    .HasColumnName("DENSIDAD")
                    .IsUnicode(false);

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .IsUnicode(false);

                entity.Property(e => e.Final)
                    .HasColumnName("FINAL")
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3)
                    .HasColumnName("%H3BO3")
                    .IsUnicode(false);

                entity.Property(e => e.Horometro)
                    .HasColumnName("HOROMETRO")
                    .IsUnicode(false);

                entity.Property(e => e.Inicial)
                    .HasColumnName("INICIAL")
                    .IsUnicode(false);

                entity.Property(e => e.K)
                    .HasColumnName("%K")
                    .IsUnicode(false);

                entity.Property(e => e.Li)
                    .HasColumnName("%LI")
                    .IsUnicode(false);

                entity.Property(e => e.Mg)
                    .HasColumnName("%MG")
                    .IsUnicode(false);

                entity.Property(e => e.Na)
                    .HasColumnName("%NA")
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasColumnName("ORIGEN")
                    .IsUnicode(false);

                entity.Property(e => e.SatK).HasColumnName("SAT.K");

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4)
                    .HasColumnName("%SO4")
                    .IsUnicode(false);

                entity.Property(e => e.VolTraspaso)
                    .HasColumnName("VOL.TRASPASO")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataPciAcopioCli>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_PCI_AcopioCli", "migra");

                entity.Property(e => e.AcopioCli)
                    .HasColumnName("Acopio Cli")
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaOrigen)
                    .HasColumnName("Fecha Origen")
                    .HasColumnType("datetime");

                entity.Property(e => e.Li).HasColumnName("%Li");

                entity.Property(e => e.VolumenM3).HasColumnName("Volumen (m3)");
            });

            modelBuilder.Entity<DataPciFechasdeOrigen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_PCI_FechasdeOrigen", "migra");

                entity.Property(e => e.Acopio).IsUnicode(false);

                entity.Property(e => e.FechaDeOrigen)
                    .HasColumnName("Fecha de Origen")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalRes)
                    .HasColumnName("Sal RES")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataPciModos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_PCI_Modos", "migra");

                entity.Property(e => e.Corriente).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Modo).IsUnicode(false);

                entity.Property(e => e.Planta).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);

                entity.Property(e => e.Variable).IsUnicode(false);
            });

            modelBuilder.Entity<DataPciModosDiccionario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_PCI_ModosDiccionario", "migra");

                entity.Property(e => e.ArchivoOrigen).IsUnicode(false);

                entity.Property(e => e.ColumnaDestino).IsUnicode(false);

                entity.Property(e => e.ColumnaOrigen).IsUnicode(false);

                entity.Property(e => e.Corriente).IsUnicode(false);

                entity.Property(e => e.DataType).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DescripcionTabla).IsUnicode(false);

                entity.Property(e => e.Migrar).IsUnicode(false);

                entity.Property(e => e.Modalidad).IsUnicode(false);

                entity.Property(e => e.Nullable)
                    .HasColumnName("Nullable?")
                    .IsUnicode(false);

                entity.Property(e => e.Observación).IsUnicode(false);

                entity.Property(e => e.TabOrigen).IsUnicode(false);

                entity.Property(e => e.TablaDestino).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);

                entity.Property(e => e.TipoTabla).IsUnicode(false);

                entity.Property(e => e.Variable).IsUnicode(false);
            });

            modelBuilder.Entity<DataPeriodosOperacionales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_PeriodosOperacionales", "migra");

                entity.Property(e => e.Fin).HasColumnType("datetime");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Mes).HasColumnType("datetime");

                entity.Property(e => e.Sistema).IsUnicode(false);
            });

            modelBuilder.Entity<DataPlantaConsLiOh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_PlantaConsLiOH", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Li2Co3T).HasColumnName("Li2CO3 t");
            });

            modelBuilder.Entity<DataPlataformasCarga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Plataformas_Carga", "migra");

                entity.Property(e => e.Ca).HasColumnName("Ca (%)");

                entity.Property(e => e.Cl).HasColumnName("Cl (%)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA ")
                    .HasColumnType("datetime");

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3 (%)");

                entity.Property(e => e.Impregnación).HasColumnName("%Impregnación");

                entity.Property(e => e.K).HasColumnName("K (%)");

                entity.Property(e => e.Li).HasColumnName("Li (%)");

                entity.Property(e => e.MasaTon).HasColumnName("MASA (ton)");

                entity.Property(e => e.MasaTon1).HasColumnName("MASA (ton).1");

                entity.Property(e => e.MesRes)
                    .HasColumnName("MES RES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mg).HasColumnName("Mg (%)");

                entity.Property(e => e.Na).HasColumnName("Na (%)");

                entity.Property(e => e.Poza)
                    .HasColumnName("POZA")
                    .IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("SO4 (%)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3).HasColumnName("VOLUMEN (m3)");
            });

            modelBuilder.Entity<DataPlataformasDescarga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Plataformas_Descarga", "migra");

                entity.Property(e => e.Ca).HasColumnName("Ca (%)");

                entity.Property(e => e.Cl).HasColumnName("Cl (%)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA ")
                    .HasColumnType("datetime");

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3 (%)");

                entity.Property(e => e.Impregnación).HasColumnName("%impregnación");

                entity.Property(e => e.K).HasColumnName("K (%)");

                entity.Property(e => e.Li).HasColumnName("Li (%)");

                entity.Property(e => e.MasaTon).HasColumnName("Masa (ton)");

                entity.Property(e => e.MesRes)
                    .HasColumnName("MES RES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mg).HasColumnName("Mg (%)");

                entity.Property(e => e.Na).HasColumnName("Na (%)");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasColumnName("PLATAFORMA")
                    .IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("SO4 (%)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .IsUnicode(false);

                entity.Property(e => e.VolumenEnPlataformaM3)
                    .HasColumnName("Volumen en plataforma (m3)")
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3).HasColumnName("VOLUMEN (m3)");

                entity.Property(e => e.VolumenSalidaM3).HasColumnName("Volumen Salida (m3)");
            });

            modelBuilder.Entity<DataPlataformasInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Plataformas_Info", "migra");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.PDeImpregnación).HasColumnName("P.de Impregnación");

                entity.Property(e => e.PDeLiInicial).HasColumnName("P. de Li Inicial");

                entity.Property(e => e.Plataforma).IsUnicode(false);

                entity.Property(e => e.VolAgua).HasColumnName("Vol.Agua");

                entity.Property(e => e.VolSal).HasColumnName("Vol. Sal");
            });

            modelBuilder.Entity<DataPlataformasQuimica>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Plataformas_Quimica", "migra");

                entity.Property(e => e.Ca).HasColumnName("% Ca");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.H3bo3).HasColumnName("% H3Bo3");

                entity.Property(e => e.K).HasColumnName("% K");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Na).HasColumnName("% Na");

                entity.Property(e => e.Plataforma).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("% SO4");
            });

            modelBuilder.Entity<DataPlataformasRiego>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Plataformas_Riego", "migra");

                entity.Property(e => e.ConsumoAguaM3).HasColumnName("Consumo agua (m3)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<DataPodCarmenDatosIgs1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_PodCarmenDatosIGS_1", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Reactivo).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.SubSistema).IsUnicode(false);

                entity.Property(e => e.Unidad).IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataPodCarmenDatosIgs2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_PodCarmenDatosIGS_2", "migra");

                entity.Property(e => e.Corriente).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Medicion).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataProduccionPotasioConsProdK>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ProduccionPotasio_ConsProdK", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<DataProduccionPotasioConsProdK1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ProduccionPotasio_ConsProdK1", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<DataProduccionPotasioDic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ProduccionPotasio_Dic", "migra");

                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.ArchivoOrigen).IsUnicode(false);

                entity.Property(e => e.ColumnaDestino).IsUnicode(false);

                entity.Property(e => e.ColumnaOrigen).IsUnicode(false);

                entity.Property(e => e.Corriente).IsUnicode(false);

                entity.Property(e => e.DataType).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Infraestructura).IsUnicode(false);

                entity.Property(e => e.Migrar).IsUnicode(false);

                entity.Property(e => e.Modalidad).IsUnicode(false);

                entity.Property(e => e.Nullable)
                    .HasColumnName("Nullable?")
                    .IsUnicode(false);

                entity.Property(e => e.Observación).IsUnicode(false);

                entity.Property(e => e.Planta).IsUnicode(false);

                entity.Property(e => e.TabOrigen).IsUnicode(false);

                entity.Property(e => e.TablaDestino).IsUnicode(false);

                entity.Property(e => e.TipoTabla).IsUnicode(false);

                entity.Property(e => e.Variable).IsUnicode(false);
            });

            modelBuilder.Entity<DataProduccionesCarmenFlexitank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_ProduccionesCarmenFlexitank", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FlexitankLceTon).HasColumnName("Flexitank_LCE_ton");
            });

            modelBuilder.Entity<DataReactivos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Reactivos", "migra");

                entity.Property(e => e.Corriente).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.MasaTon).HasColumnName("Masa ton");
            });

            modelBuilder.Entity<DataReinyeccionDatos1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Reinyeccion_Datos1", "migra");

                entity.Property(e => e.EvapAreaExpuestaM3dia).HasColumnName("EvapAreaExpuesta_m3dia");

                entity.Property(e => e.EvapAreaImpM3dia).HasColumnName("EvapAreaImp_m3dia");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.SalmueraInfiltradaM3dia).HasColumnName("SalmueraInfiltrada_m3dia");

                entity.Property(e => e.Sistema).IsUnicode(false);
            });

            modelBuilder.Entity<DataReinyeccionDatos1Old>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Reinyeccion_Datos1_old", "migra");

                entity.Property(e => e.EvapAreaExpuestaM3dia).HasColumnName("EvapAreaExpuesta_m3dia");

                entity.Property(e => e.EvapAreaImpM3dia).HasColumnName("EvapAreaImp_m3dia");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.SalmueraInfiltradaM3dia).HasColumnName("SalmueraInfiltrada_m3dia");

                entity.Property(e => e.Sistema).IsUnicode(false);
            });

            modelBuilder.Entity<DataReinyeccionDatos2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Reinyeccion_Datos2", "migra");

                entity.Property(e => e.CaSalmPct).HasColumnName("Ca_Salm_pct");

                entity.Property(e => e.CaSolPct).HasColumnName("Ca_Sol_Pct");

                entity.Property(e => e.ClSalmPct).HasColumnName("Cl_Salm_pct");

                entity.Property(e => e.ClSolPct).HasColumnName("Cl_Sol_pct");

                entity.Property(e => e.DensSalmGml).HasColumnName("Dens_Salm_gml");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaHora)
                    .HasColumnName("Fecha-Hora")
                    .HasColumnType("datetime");

                entity.Property(e => e.H2o170gcSolPct).HasColumnName("H2O170gc_Sol_pct");

                entity.Property(e => e.H3bo3Pct).HasColumnName("H3BO3_pct");

                entity.Property(e => e.H3bo3SolPct).HasColumnName("H3BO3_Sol_pct");

                entity.Property(e => e.KSalmPct).HasColumnName("K_Salm_pct");

                entity.Property(e => e.KSolPct).HasColumnName("K_Sol_pct");

                entity.Property(e => e.LiSalmPct).HasColumnName("Li_Salm_pct");

                entity.Property(e => e.LiSolPct).HasColumnName("Li_Sol_pct");

                entity.Property(e => e.MgSalmPct).HasColumnName("Mg_Salm_pct");

                entity.Property(e => e.MgSolPct).HasColumnName("Mg_Sol_pct");

                entity.Property(e => e.NaSalmPct).HasColumnName("Na_Salm_pct");

                entity.Property(e => e.NaSolPct).HasColumnName("Na_Sol_pct");

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4SalmPct).HasColumnName("SO4_Salm_pct");

                entity.Property(e => e.So4SolPct).HasColumnName("SO4_Sol_pct");

                entity.Property(e => e.TkLims).HasColumnName("TK_LIMS");

                entity.Property(e => e.TkSipro).HasColumnName("TK_SIPRO");
            });

            modelBuilder.Entity<DataReinyeccionDatos2Old>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Reinyeccion_Datos2_old", "migra");

                entity.Property(e => e.CaSalmPct).HasColumnName("Ca_Salm_pct");

                entity.Property(e => e.CaSolPct).HasColumnName("Ca_Sol_Pct");

                entity.Property(e => e.ClSalmPct).HasColumnName("Cl_Salm_pct");

                entity.Property(e => e.ClSolPct).HasColumnName("Cl_Sol_pct");

                entity.Property(e => e.DensSalmGml).HasColumnName("Dens_Salm_gml");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.H2o170gcSolPct).HasColumnName("H2O170gc_Sol_pct");

                entity.Property(e => e.H3bo3Pct).HasColumnName("H3BO3_pct");

                entity.Property(e => e.H3bo3SolPct).HasColumnName("H3BO3_Sol_pct");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .IsUnicode(false);

                entity.Property(e => e.KSolPct).HasColumnName("K_Sol_pct");

                entity.Property(e => e.LiSalmPct).HasColumnName("Li_Salm_pct");

                entity.Property(e => e.LiSolPct).HasColumnName("Li_Sol_pct");

                entity.Property(e => e.MgSalmPct).HasColumnName("Mg_Salm_pct");

                entity.Property(e => e.MgSolPct).HasColumnName("Mg_Sol_pct");

                entity.Property(e => e.NaSalmPct).HasColumnName("Na_Salm_pct");

                entity.Property(e => e.NaSolPct).HasColumnName("Na_Sol_pct");

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4SalmPct).HasColumnName("SO4_Salm_pct");

                entity.Property(e => e.So4SolPct).HasColumnName("SO4_Sol_pct");

                entity.Property(e => e.TkLims).HasColumnName("TK_LIMS");

                entity.Property(e => e.TkSipro).HasColumnName("TK_SIPRO");
            });

            modelBuilder.Entity<DataReinyeccionFlujos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_Reinyeccion_Flujos", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.Variable)
                    .HasColumnName("variable")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataRilesyRises>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_RilesyRises", "migra");

                entity.Property(e => e.CaPct).HasColumnName("Ca_pct");

                entity.Property(e => e.ClPct).HasColumnName("Cl_pct");

                entity.Property(e => e.Corriente).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.H3bo3Pct).HasColumnName("H3BO3_pct");

                entity.Property(e => e.KPct).HasColumnName("K_pct");

                entity.Property(e => e.LiPct).HasColumnName("Li_pct");

                entity.Property(e => e.MasaTon).HasColumnName("Masa_ton");

                entity.Property(e => e.MgPct).HasColumnName("Mg_pct");

                entity.Property(e => e.NaPct).HasColumnName("Na_pct");

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4Pct).HasColumnName("SO4_pct");
            });

            modelBuilder.Entity<DataSistemaFaena>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_SistemaFaena", "migra");

                entity.Property(e => e.Faena).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);
            });

            modelBuilder.Entity<DataSolicionLitioConsDespacho>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_SolicionLitio_ConsDespacho", "migra");

                entity.Property(e => e.BPct).HasColumnName("B_pct");

                entity.Property(e => e.CaPct).HasColumnName("Ca_pct");

                entity.Property(e => e.DensTonm3).HasColumnName("Dens_tonm3");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.KPct).HasColumnName("K_pct");

                entity.Property(e => e.LiPct).HasColumnName("Li_pct");

                entity.Property(e => e.MasaDespachadaTon).HasColumnName("MasaDespachada_ton");

                entity.Property(e => e.MgPct).HasColumnName("Mg_pct");

                entity.Property(e => e.NaPct).HasColumnName("Na_pct");

                entity.Property(e => e.So4Pct).HasColumnName("SO4_pct");

                entity.Property(e => e.SoldPct).HasColumnName("Sold_pct");

                entity.Property(e => e.String).IsUnicode(false);
            });

            modelBuilder.Entity<DataSolicionLitioConsLi2Co3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_SolicionLitio_ConsLi2CO3", "migra");

                entity.Property(e => e.BPct).HasColumnName("B_pct");

                entity.Property(e => e.CaPct).HasColumnName("Ca_pct");

                entity.Property(e => e.ClPct).HasColumnName("Cl_pct");

                entity.Property(e => e.CorrienteGlobal).IsUnicode(false);

                entity.Property(e => e.CorrienteLi2Co3)
                    .HasColumnName("CorrienteLi2CO3")
                    .IsUnicode(false);

                entity.Property(e => e.DensTonm3).HasColumnName("Dens_tonm3");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.KPct).HasColumnName("K_pct");

                entity.Property(e => e.LiPct).HasColumnName("Li_pct");

                entity.Property(e => e.MasaTon).HasColumnName("Masa_ton");

                entity.Property(e => e.MgPct).HasColumnName("Mg_pct");

                entity.Property(e => e.NaPct).HasColumnName("Na_pct");

                entity.Property(e => e.So4Pct).HasColumnName("SO4_pct");

                entity.Property(e => e.VolM3).HasColumnName("Vol_m3");
            });

            modelBuilder.Entity<DataSubsistemaSistema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_SubsistemaSistema", "migra");

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.Subsistema).IsUnicode(false);

                entity.Property(e => e.Unnamed2)
                    .HasColumnName("Unnamed: 2")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataTraspasosReiyeccionCkmopiiaPorteo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_TraspasosReiyeccion_CKMOPIIaPorteo", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Pozo).IsUnicode(false);

                entity.Property(e => e.Variable).IsUnicode(false);

                entity.Property(e => e.VolAgua).HasColumnName("Vol.Agua");
            });

            modelBuilder.Entity<DataTraspasosReiyeccionHoja2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Data_TraspasosReiyeccion_Hoja2", "migra");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Pozo).IsUnicode(false);

                entity.Property(e => e.Variable).IsUnicode(false);
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

            modelBuilder.Entity<DatosReporteBalanceSubSistema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DatosReporteBalanceSubSistema", "balance");

                entity.Property(e => e.AguaTon)
                    .HasColumnName("Agua_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(19, 7)");

                entity.Property(e => e.SubSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vista)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DefImport", "migra");

                entity.Property(e => e.IdSchemaDef).IsUnicode(false);

                entity.Property(e => e.IdTipoDatoColOrigen).IsUnicode(false);

                entity.Property(e => e.Importador).IsUnicode(false);

                entity.Property(e => e.NombreCol).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolSalidaM3)
                    .HasColumnName("VolSalida_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolenPlataformaM3)
                    .HasColumnName("VolenPlataforma_m3")
                    .HasColumnType("decimal(19, 4)");

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

            modelBuilder.Entity<DestinationNovt>(entity =>
            {
                entity.HasKey(e => e._0IdSincronizacionCorfo)
                    .HasName("PK__Destinat__24C9130695CA711C");

                entity.ToTable("Destination_NOVT", "migra");

                entity.Property(e => e._0IdSincronizacionCorfo)
                    .HasColumnName("0_IdSincronizacionCORFO")
                    .ValueGeneratedNever();

                entity.Property(e => e._0IdMensaje).HasColumnName("0_IdMensaje");

                entity.Property(e => e._0NombreTabla)
                    .IsRequired()
                    .HasColumnName("0_NombreTabla")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._0Observacion)
                    .HasColumnName("0_Observacion")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e._0TipoTransaccion)
                    .HasColumnName("0_TipoTransaccion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._10Comentario)
                    .HasColumnName("10_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._10Eliminado).HasColumnName("10_Eliminado");

                entity.Property(e => e._10Empresa)
                    .HasColumnName("10_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Fecha)
                    .HasColumnName("10_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._10IdAforo).HasColumnName("10_IdAforo");

                entity.Property(e => e._10Infraestructura)
                    .HasColumnName("10_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Log).HasColumnName("10_Log");

                entity.Property(e => e._10MetodoFisico)
                    .HasColumnName("10_MetodoFisico")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Modificado).HasColumnName("10_Modificado");

                entity.Property(e => e._10Publicado).HasColumnName("10_Publicado");

                entity.Property(e => e._10TipoEnsayo)
                    .HasColumnName("10_TipoEnsayo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Unidad)
                    .HasColumnName("10_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Validado).HasColumnName("10_Validado");

                entity.Property(e => e._10Valor)
                    .HasColumnName("10_Valor")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._11Analito)
                    .HasColumnName("11_Analito")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Comentario)
                    .HasColumnName("11_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._11Descriptor)
                    .HasColumnName("11_Descriptor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Eliminado).HasColumnName("11_Eliminado");

                entity.Property(e => e._11Fecha)
                    .HasColumnName("11_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._11IdAnalisisQuimico).HasColumnName("11_IdAnalisisQuimico");

                entity.Property(e => e._11Infraestructura)
                    .HasColumnName("11_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Laboratorio)
                    .HasColumnName("11_Laboratorio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Log).HasColumnName("11_Log");

                entity.Property(e => e._11Modificado).HasColumnName("11_Modificado");

                entity.Property(e => e._11Publicado).HasColumnName("11_Publicado");

                entity.Property(e => e._11Unidad)
                    .HasColumnName("11_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Validado).HasColumnName("11_Validado");

                entity.Property(e => e._11Valor)
                    .HasColumnName("11_Valor")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._12CotaPuntoReferenciaMsnm)
                    .HasColumnName("12_CotaPuntoReferencia_msnm")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._12Eliminado).HasColumnName("12_Eliminado");

                entity.Property(e => e._12IdCoordenada).HasColumnName("12_IdCoordenada");

                entity.Property(e => e._12Infraestructura)
                    .HasColumnName("12_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._12InicioVigencia)
                    .HasColumnName("12_InicioVigencia")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._12Log).HasColumnName("12_Log");

                entity.Property(e => e._12TerminoVigencia)
                    .HasColumnName("12_TerminoVigencia")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._12UtmEste)
                    .HasColumnName("12_UTM_Este")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._12UtmNorte)
                    .HasColumnName("12_UTM_Norte")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._13Comentario)
                    .HasColumnName("13_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._13Eliminado).HasColumnName("13_Eliminado");

                entity.Property(e => e._13Empresa)
                    .HasColumnName("13_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._13Fecha)
                    .HasColumnName("13_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._13IdCuna).HasColumnName("13_IdCuna");

                entity.Property(e => e._13Infraestructura)
                    .HasColumnName("13_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._13Log).HasColumnName("13_Log");

                entity.Property(e => e._13Modificado).HasColumnName("13_Modificado");

                entity.Property(e => e._13Profundidad)
                    .HasColumnName("13_Profundidad")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._13Publicado).HasColumnName("13_Publicado");

                entity.Property(e => e._13TipoEnsayo)
                    .HasColumnName("13_TipoEnsayo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._13Unidad)
                    .HasColumnName("13_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._13Validado).HasColumnName("13_Validado");

                entity.Property(e => e._13Valor)
                    .HasColumnName("13_Valor")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._18Comentario)
                    .HasColumnName("18_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._18Eliminado).HasColumnName("18_Eliminado");

                entity.Property(e => e._18Estacion)
                    .HasColumnName("18_Estacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._18Fecha)
                    .HasColumnName("18_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._18Frecuencia)
                    .HasColumnName("18_Frecuencia")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._18IdMedicionEstacion).HasColumnName("18_IdMedicionEstacion");

                entity.Property(e => e._18Log).HasColumnName("18_Log");

                entity.Property(e => e._18Modificado).HasColumnName("18_Modificado");

                entity.Property(e => e._18Parametro)
                    .HasColumnName("18_Parametro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._18Publicado).HasColumnName("18_Publicado");

                entity.Property(e => e._18TipoDato)
                    .HasColumnName("18_TipoDato")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._18Unidad)
                    .HasColumnName("18_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._18Validado).HasColumnName("18_Validado");

                entity.Property(e => e._18Valor)
                    .HasColumnName("18_Valor")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._19Comentario)
                    .HasColumnName("19_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._19CotaNivelMsnm)
                    .HasColumnName("19_CotaNivel_msnm")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._19CotaPuntoReferenciaMsnm)
                    .HasColumnName("19_CotaPuntoReferencia_msnm")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._19Eliminado).HasColumnName("19_Eliminado");

                entity.Property(e => e._19Empresa)
                    .HasColumnName("19_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._19Fecha)
                    .HasColumnName("19_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._19IdNivel).HasColumnName("19_IdNivel");

                entity.Property(e => e._19Infraestructura)
                    .HasColumnName("19_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._19Log).HasColumnName("19_Log");

                entity.Property(e => e._19MedicionBajoPuntoReferenciaM)
                    .HasColumnName("19_MedicionBajoPuntoReferencia_m")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._19ModalidadNivel)
                    .HasColumnName("19_ModalidadNivel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._19Modificado).HasColumnName("19_Modificado");

                entity.Property(e => e._19Nbprinicial)
                    .HasColumnName("19_NBPRInicial")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._19NivelRelativo)
                    .HasColumnName("19_NivelRelativo")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._19PlanContingencia).HasColumnName("19_PlanContingencia");

                entity.Property(e => e._19Publicado).HasColumnName("19_Publicado");

                entity.Property(e => e._19TipoNivel)
                    .HasColumnName("19_TipoNivel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._19Validado).HasColumnName("19_Validado");

                entity.Property(e => e._1Descripcion)
                    .HasColumnName("1_DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._1Fecha)
                    .HasColumnName("1_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e._1IdVariable)
                    .HasColumnName("1_ID_VARIABLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e._1ResultNumber)
                    .HasColumnName("1_RESULT_NUMBER")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e._1SValor)
                    .HasColumnName("1_sValor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e._1Valor)
                    .HasColumnName("1_VALOR")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e._20Comentario)
                    .HasColumnName("20_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._20CotaNivelMsnm)
                    .HasColumnName("20_CotaNivel_msnm")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._20CotaPuntoReferenciaMsnm)
                    .HasColumnName("20_CotaPuntoReferencia_msnm")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._20Eliminado).HasColumnName("20_Eliminado");

                entity.Property(e => e._20Empresa)
                    .HasColumnName("20_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._20Fecha)
                    .HasColumnName("20_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._20IdNivel).HasColumnName("20_IdNivel");

                entity.Property(e => e._20Infraestructura)
                    .HasColumnName("20_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._20Log).HasColumnName("20_Log");

                entity.Property(e => e._20MedicionBajoPuntoReferenciaM)
                    .HasColumnName("20_MedicionBajoPuntoReferencia_m")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._20ModalidadNivel)
                    .HasColumnName("20_ModalidadNivel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._20Modificado).HasColumnName("20_Modificado");

                entity.Property(e => e._20Nbprinicial)
                    .HasColumnName("20_NBPRInicial")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._20NivelRelativo)
                    .HasColumnName("20_NivelRelativo")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._20PlanContingencia).HasColumnName("20_PlanContingencia");

                entity.Property(e => e._20Publicado).HasColumnName("20_Publicado");

                entity.Property(e => e._20TipoNivel)
                    .HasColumnName("20_TipoNivel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._20Validado).HasColumnName("20_Validado");

                entity.Property(e => e._21CotaFaseI)
                    .HasColumnName("21_CotaFase_I")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e._21CotaFaseIi)
                    .HasColumnName("21_CotaFase_II")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e._21DescensoFaseI)
                    .HasColumnName("21_DescensoFase_I")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e._21DescensoFaseIi)
                    .HasColumnName("21_DescensoFase_II")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e._21Eliminado).HasColumnName("21_Eliminado");

                entity.Property(e => e._21FechaVigencia)
                    .HasColumnName("21_FechaVigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e._21GrafInferior)
                    .HasColumnName("21_grafInferior")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e._21GrafSuperior)
                    .HasColumnName("21_grafSuperior")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e._21IdTauxiliar).HasColumnName("21_IdTAuxiliar");

                entity.Property(e => e._21Infraestructura)
                    .HasColumnName("21_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._21Log).HasColumnName("21_Log");

                entity.Property(e => e._21Sistema)
                    .HasColumnName("21_Sistema")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._21Subsistema)
                    .HasColumnName("21_Subsistema")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Comentario)
                    .HasColumnName("22_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._22Eliminado).HasColumnName("22_Eliminado");

                entity.Property(e => e._22Empresa)
                    .HasColumnName("22_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Fecha)
                    .HasColumnName("22_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._22IdSuperficieLacustre).HasColumnName("22_IdSuperficieLacustre");

                entity.Property(e => e._22Infraestructura)
                    .HasColumnName("22_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Log).HasColumnName("22_Log");

                entity.Property(e => e._22Modificado).HasColumnName("22_Modificado");

                entity.Property(e => e._22Publicado).HasColumnName("22_Publicado");

                entity.Property(e => e._22TipoEnsayo)
                    .HasColumnName("22_TipoEnsayo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22TipoMetodo)
                    .HasColumnName("22_TipoMetodo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Unidad)
                    .HasColumnName("22_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Validado).HasColumnName("22_Validado");

                entity.Property(e => e._22Valor)
                    .HasColumnName("22_Valor")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e._2Area)
                    .HasColumnName("2_AREA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e._2DescVariable)
                    .HasColumnName("2_DESC_VARIABLE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._2Descripcion)
                    .HasColumnName("2_DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._2IdVariable)
                    .HasColumnName("2_ID_VARIABLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e._3AmbientalControlPointId).HasColumnName("3_ambiental_control_point_id");

                entity.Property(e => e._3CreatedAt)
                    .HasColumnName("3_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._3Id).HasColumnName("3_id");

                entity.Property(e => e._3PlantOrPoolExtraction)
                    .HasColumnName("3_plant_or_pool_extraction")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._3SectorId).HasColumnName("3_sector_id");

                entity.Property(e => e._3TimeStamp)
                    .HasColumnName("3_time_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e._3UpdatedAt)
                    .HasColumnName("3_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._4ClasificationId).HasColumnName("4_clasification_id");

                entity.Property(e => e._4CreatedAt)
                    .HasColumnName("4_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._4DescriptionId).HasColumnName("4_description_id");

                entity.Property(e => e._4DestinationId).HasColumnName("4_destination_id");

                entity.Property(e => e._4ExtractionRights).HasColumnName("4_extraction_rights");

                entity.Property(e => e._4Id).HasColumnName("4_id");

                entity.Property(e => e._4IsEnabled).HasColumnName("4_is_enabled");

                entity.Property(e => e._4Label)
                    .HasColumnName("4_label")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._4Lat)
                    .HasColumnName("4_lat")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._4Lng)
                    .HasColumnName("4_lng")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._4LocationId).HasColumnName("4_location_id");

                entity.Property(e => e._4Name)
                    .HasColumnName("4_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._4PumpId).HasColumnName("4_pump_id");

                entity.Property(e => e._4SectorId).HasColumnName("4_sector_id");

                entity.Property(e => e._4TypeId).HasColumnName("4_type_id");

                entity.Property(e => e._4UpdatedAt)
                    .HasColumnName("4_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._4WorkingFrom)
                    .HasColumnName("4_working_from")
                    .HasColumnType("datetime");

                entity.Property(e => e._4WorkingUntil)
                    .HasColumnName("4_working_until")
                    .HasColumnType("datetime");

                entity.Property(e => e._5BrineDensity)
                    .HasColumnName("5_brine_density")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5CreatedAt)
                    .HasColumnName("5_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._5F1)
                    .HasColumnName("5_f1")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5F2)
                    .HasColumnName("5_f2")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5IbaMop)
                    .HasColumnName("5_iba_mop")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5IbaSop)
                    .HasColumnName("5_iba_sop")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5Id).HasColumnName("5_id");

                entity.Property(e => e._5IsEnabled).HasColumnName("5_is_enabled");

                entity.Property(e => e._5LitersPerSecond)
                    .HasColumnName("5_liters_per_second")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5SaltDensity)
                    .HasColumnName("5_salt_density")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5UpdatedAt)
                    .HasColumnName("5_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._6BrineDps)
                    .HasColumnName("6_brine_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6ConstantId).HasColumnName("6_constant_id");

                entity.Property(e => e._6CreatedAt)
                    .HasColumnName("6_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._6DirectReinjection)
                    .HasColumnName("6_direct_reinjection")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationAreaImpregnatedDps)
                    .HasColumnName("6_evaporation_area_impregnated_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationBrineImpregnatedDps)
                    .HasColumnName("6_evaporation_brine_impregnated_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationExposedAreaDps)
                    .HasColumnName("6_evaporation_exposed_area_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationExposedBrineDps)
                    .HasColumnName("6_evaporation_exposed_brine_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationStationKci)
                    .HasColumnName("6_evaporation_station_kci")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6Id).HasColumnName("6_id");

                entity.Property(e => e._6ImpregnatedBrineAreaDps)
                    .HasColumnName("6_impregnated_brine_area_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6IndirectReinjection)
                    .HasColumnName("6_indirect_reinjection")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6IsOficial).HasColumnName("6_is_oficial");

                entity.Property(e => e._6IsOficialDatum).HasColumnName("6_is_oficial_datum");

                entity.Property(e => e._6IsProcessing).HasColumnName("6_is_processing");

                entity.Property(e => e._6LagoonArea)
                    .HasColumnName("6_lagoon_area")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6NetExtractionLS)
                    .HasColumnName("6_net_extraction_l_s")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6NetExtractionMD)
                    .HasColumnName("6_net_extraction_m_d")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6PlantExtraction)
                    .HasColumnName("6_plant_extraction")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6PoolExtraction)
                    .HasColumnName("6_pool_extraction")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6PorcentSolidPulpDps)
                    .HasColumnName("6_porcent_solid_pulp_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6PulpFlowDps)
                    .HasColumnName("6_pulp_flow_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6RecycleBrineDps)
                    .HasColumnName("6_recycle_brine_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6SectorId).HasColumnName("6_sector_id");

                entity.Property(e => e._6TimeStamp)
                    .HasColumnName("6_time_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e._6TotalExtraction)
                    .HasColumnName("6_total_extraction")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6UpdatedAt)
                    .HasColumnName("6_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._7CreatedAt)
                    .HasColumnName("7_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._7Id).HasColumnName("7_id");

                entity.Property(e => e._7Name)
                    .HasColumnName("7_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._7UpdatedAt)
                    .HasColumnName("7_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._8Comment)
                    .HasColumnName("8_comment")
                    .IsUnicode(false);

                entity.Property(e => e._8CreatedAt)
                    .HasColumnName("8_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._8Event)
                    .HasColumnName("8_event")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e._8Id).HasColumnName("8_id");

                entity.Property(e => e._8ItemId).HasColumnName("8_item_id");

                entity.Property(e => e._8ItemType)
                    .HasColumnName("8_item_type")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e._8Object)
                    .HasColumnName("8_object")
                    .IsUnicode(false);

                entity.Property(e => e._8Whodunnit)
                    .HasColumnName("8_whodunnit")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e._9AmbientalControlPointId).HasColumnName("9_ambiental_control_point_id");

                entity.Property(e => e._9AverageFlowDay).HasColumnName("9_average_flow_day");

                entity.Property(e => e._9CreatedAt)
                    .HasColumnName("9_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._9FlowDay).HasColumnName("9_flow_day");

                entity.Property(e => e._9Id).HasColumnName("9_id");

                entity.Property(e => e._9IsProcessing).HasColumnName("9_is_processing");

                entity.Property(e => e._9TimeStamp)
                    .HasColumnName("9_time_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e._9UpdatedAt)
                    .HasColumnName("9_updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DestinationVt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Destination_VT", "migra");

                entity.Property(e => e._0IdMensaje)
                    .HasColumnName("0_IdMensaje")
                    .IsUnicode(false);

                entity.Property(e => e._0IdSincronizacionCorfo).HasColumnName("0_IdSincronizacionCORFO");

                entity.Property(e => e._0NombreTabla)
                    .HasColumnName("0_NombreTabla")
                    .IsUnicode(false);

                entity.Property(e => e._0TipoTransaccion)
                    .HasColumnName("0_TipoTransaccion")
                    .IsUnicode(false);

                entity.Property(e => e._1Descripcion)
                    .HasColumnName("1_DESCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e._1Fecha)
                    .HasColumnName("1_FECHA")
                    .IsUnicode(false);

                entity.Property(e => e._1IdVariable)
                    .HasColumnName("1_ID_VARIABLE")
                    .IsUnicode(false);

                entity.Property(e => e._1ResultNumber).HasColumnName("1_RESULT_NUMBER");

                entity.Property(e => e._1SValor)
                    .HasColumnName("1_sValor")
                    .IsUnicode(false);

                entity.Property(e => e._1Valor).HasColumnName("1_VALOR");
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.HorasOperacionH)
                    .HasColumnName("HorasOperacion_h")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolTraspasoM3)
                    .HasColumnName("VolTraspaso_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolFinalM3)
                    .HasColumnName("VolFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolInicialM3)
                    .HasColumnName("VolInicial_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolTotalDia)
                    .HasColumnName("VolTotal_dia")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

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

            modelBuilder.Entity<GvAjustes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GV_Ajustes");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Clasificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Corriente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Faena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H2oTon)
                    .HasColumnName("H2O_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.IdBgajustes).HasColumnName("IdBGAjustes");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvCargaPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_CargaPlataformas", "IOV");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraOrigen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TipoSal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvCkmopIiquimaPorteo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_CKMopIIQuimaPorteo", "IOV");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdCkmopIiquimaPorteo).HasColumnName("IdCKMopIIQuimaPorteo");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvCkmopIivolaPorteo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_CKMopIIVolaPorteo", "IOV");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdCkmopIivolaPorteo).HasColumnName("IdCKMopIIVolaPorteo");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3dia)
                    .HasColumnName("Volumen_m3dia")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvConsDespacho>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsDespacho", "IOV");

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensTonm3)
                    .HasColumnName("Dens_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaDespachadaTon)
                    .HasColumnName("MasaDespachada_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvConsInvCarmen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsInvCarmen", "IOV");

                entity.Property(e => e.DensidadTomm3)
                    .HasColumnName("Densidad_tomm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaBalanceLceTon)
                    .HasColumnName("MasaBalanceLCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaLceTon)
                    .HasColumnName("MasaLCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvConsLi2Co3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsLi2CO3", "IOV");

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Co3Pct)
                    .HasColumnName("CO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CorrienteGlobal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrienteLi2Co3)
                    .IsRequired()
                    .HasColumnName("CorrienteLi2CO3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DensTonm3)
                    .HasColumnName("Dens_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H2oPct)
                    .HasColumnName("H2O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IdConsLi2Co3).HasColumnName("IdConsLi2CO3");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.OhPct)
                    .HasColumnName("OH_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolM3)
                    .HasColumnName("Vol_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvConsLitioLiCo3mensual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsLitioLiCO3Mensual", "IOV");

                entity.Property(e => e.CarbonatoTon)
                    .HasColumnName("Carbonato_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CorrienteLi2Co3)
                    .IsRequired()
                    .HasColumnName("CorrienteLi2CO3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdConsLitioLiCo3mensual).HasColumnName("IdConsLitioLiCO3Mensual");

                entity.Property(e => e.Li2Co3FrescaTon)
                    .HasColumnName("Li2CO3_Fresca_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Li2Co3TotalTon)
                    .HasColumnName("Li2CO3_Total_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LitioFrescoTon)
                    .HasColumnName("Litio_Fresco_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvConsPlantaLiOh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsPlantaLiOH", "IOV");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdConsPlantaLiOh).HasColumnName("IdConsPlantaLiOH");

                entity.Property(e => e.Li2Co3Pct)
                    .HasColumnName("Li2CO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvConsReactivos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsReactivos", "IOV");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reactivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvConsRilesyRises>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsRilesyRises", "IOV");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CorrientesRilesyRises)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvConsumoAgua>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsumoAgua", "IOV");

                entity.Property(e => e.CategoriasConsumoAgua)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolAguaM3)
                    .HasColumnName("VolAgua_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvConsumoEnergetico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ConsumoEnergetico", "IOV");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoD)
                    .HasColumnName("Concepto_D")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
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

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 7)");
            });

            modelBuilder.Entity<GvCosechas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_Cosechas", "IOV");

                entity.Property(e => e.AlturaPozaM)
                    .HasColumnName("AlturaPoza_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Densidad).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.HumPct)
                    .HasColumnName("Hum_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImprgPct)
                    .HasColumnName("Imprg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataCkmopIiquimaPorteo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_CKMopIIQuimaPorteo");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCkmopIiquimaPorteo).HasColumnName("IdCKMopIIQuimaPorteo");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataCkmopIivolaPorteo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_CKMopIIVolaPorteo");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCkmopIivolaPorteo).HasColumnName("IdCKMopIIVolaPorteo");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3dia)
                    .HasColumnName("Volumen_m3dia")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataCkvolyQuimicaaPorteo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_CKVolyQuimicaaPorteo");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCkmopIivolaPorteo).HasColumnName("IdCKMopIIVolaPorteo");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3dia)
                    .HasColumnName("Volumen_m3dia")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataConsDespacho>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ConsDespacho");

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensTonm3)
                    .HasColumnName("Dens_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaDespachadaTon)
                    .HasColumnName("MasaDespachada_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataConsInvCarmen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ConsInvCarmen");

                entity.Property(e => e.DensidadTomm3)
                    .HasColumnName("Densidad_tomm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaBalanceLceTon)
                    .HasColumnName("MasaBalanceLCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaLceTon)
                    .HasColumnName("MasaLCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataConsLi2Co3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ConsLi2CO3");

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CorrienteGlobal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrienteLi2Co3)
                    .HasColumnName("CorrienteLi2CO3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DensTonm3)
                    .HasColumnName("Dens_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdConsLi2Co3).HasColumnName("IdConsLi2CO3");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolM3)
                    .HasColumnName("Vol_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataConsPlantaLiOh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ConsPlantaLiOH");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdConsPlantaLiOh).HasColumnName("IdConsPlantaLiOH");

                entity.Property(e => e.Li2Co3Pct)
                    .HasColumnName("Li2CO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataConsReactivos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ConsReactivos");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reactivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataConsumoAgua>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ConsumoAgua");

                entity.Property(e => e.CategoriasConsumoAgua)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Faena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.GrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuperGrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolAguaM3)
                    .HasColumnName("VolAgua_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataConsumoEnergetico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ConsumoEnergetico");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoD)
                    .HasColumnName("Concepto_D")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
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

            modelBuilder.Entity<GvDataDescargaPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_DescargaPlataformas");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Destinos)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolSalidaM3)
                    .HasColumnName("VolSalida_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolenPlataformaM3)
                    .HasColumnName("VolenPlataforma_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataEvaporacionInfiltracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_EvaporacionInfiltracion");

                entity.Property(e => e.AlturaSalmueraM)
                    .HasColumnName("AlturaSalmuera_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataExtraccionAgua>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ExtraccionAgua");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FlujoM3h)
                    .HasColumnName("Flujo_m3h")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfraestructuraOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolFinalM3)
                    .HasColumnName("VolFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolInicialM3)
                    .HasColumnName("VolInicial_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolTotalDia)
                    .HasColumnName("VolTotal_dia")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataExtraccionSalmuera>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ExtraccionSalmuera");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.HorasOperacionH)
                    .HasColumnName("HorasOperacion_h")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraDestino)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfraestructuraOrigen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiTon)
                    .HasColumnName("Li_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolTraspasoM3)
                    .HasColumnName("VolTraspaso_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataFlujos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_Flujos");

                entity.Property(e => e.Bomba)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime2(3)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalizadorM3)
                    .HasColumnName("Totalizador_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataImpregnacionCosechas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ImpregnacionCosechas");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.HumedadPct)
                    .HasColumnName("Humedad_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(38, 15)");

                entity.Property(e => e.ImprgTon)
                    .HasColumnName("Imprg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiTon)
                    .HasColumnName("Li_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataInfraestructuras>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_Infraestructuras");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfraestructuraPadre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInfraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataInfraestructurasReinyeccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_InfraestructurasReinyeccion");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataInventariosAtacama>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_InventariosAtacama");

                entity.Property(e => e.AlturaSalmueraM)
                    .HasColumnName("AlturaSalmuera_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.ComparacionVol)
                    .HasColumnName("Comparacion_vol")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensGcm3)
                    .HasColumnName("Dens_gcm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Factor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.K2so4Eqv)
                    .HasColumnName("K2SO4_eqv")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KclPct)
                    .HasColumnName("KCL_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Li2Co3Eqv)
                    .HasColumnName("Li2CO3_eqv")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgCl26h2o)
                    .HasColumnName("MgCl2_6H2O")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SatK).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInventario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ton)
                    .HasColumnName("ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Volumen).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenCalculado)
                    .HasColumnName("Volumen_Calculado")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataModosPci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ModosPCI");

                entity.Property(e => e.CorrientePci)
                    .HasColumnName("CorrientePCI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPcimodos).HasColumnName("IdPCIModos");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaLceTon)
                    .HasColumnName("Masa_LCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ModalidadPci)
                    .HasColumnName("ModalidadPCI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPci)
                    .HasColumnName("TipoPCI")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataPciacopiosOrigen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_PCIAcopiosOrigen");

                entity.Property(e => e.Acopio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaOrigen).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdPciacopiosOrigen).HasColumnName("IdPCIAcopiosOrigen");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataPeriodosOperacionales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_PeriodosOperacionales");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataPermeabilidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_Permeabilidad");

                entity.Property(e => e.PermeabilidadM3m2dia)
                    .HasColumnName("Permeabilidad_m3m2dia")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataPorteo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_Porteo");

                entity.Property(e => e.CaSalmPct)
                    .HasColumnName("Ca_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaSolPct)
                    .HasColumnName("Ca_Sol_Pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSalmPct)
                    .HasColumnName("Cl_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSolPct)
                    .HasColumnName("Cl_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensSalmGml)
                    .HasColumnName("Dens_Salm_gml")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaHora).HasColumnType("datetime2(3)");

                entity.Property(e => e.FlujoRepulpeo).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H2o170gcSolPct)
                    .HasColumnName("H2O170gc_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3SolPct)
                    .HasColumnName("H3BO3_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSolPct)
                    .HasColumnName("K_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSalmPct)
                    .HasColumnName("Li_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSolPct)
                    .HasColumnName("Li_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSalmPct)
                    .HasColumnName("Mg_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSolPct)
                    .HasColumnName("Mg_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSalmPct)
                    .HasColumnName("Na_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSolPct)
                    .HasColumnName("Na_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4SalmPct)
                    .HasColumnName("SO4_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4SolPct)
                    .HasColumnName("SO4_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TkLimsSolPct)
                    .HasColumnName("TK_LIMS_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TkSiproSolPct)
                    .HasColumnName("TK_SIPRO_Sol_pct")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataProdyDespSdeAconsProdK>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ProdyDespSdeAConsProdK");

                entity.Property(e => e.Corriente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdProdyDespSdeAconsProdK).HasColumnName("IdProdyDespSdeAConsProdK");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModalidadPlanta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Variable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataProdyDespSdeAconsProdK1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_ProdyDespSdeAConsProdK1");

                entity.Property(e => e.Corriente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdProdyDespSdeAconsProdK1).HasColumnName("IdProdyDespSdeAConsProdK1");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModalidadPlanta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Variable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataQuimicaPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_QuimicaPlataformas");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataReinyeccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_Reinyeccion");

                entity.Property(e => e.EvapAreaExpuestaM3dia)
                    .HasColumnName("EvapAreaExpuesta_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.EvapAreaImpM3dia)
                    .HasColumnName("EvapAreaImp_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalmueraInfiltradaM3dia)
                    .HasColumnName("SalmueraInfiltrada_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvDataRiegoPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_RiegoPlataformas");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolConsumoH2oM3)
                    .HasColumnName("VolConsumoH2O_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataRilesyRises>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_RilesyRises");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CorrientesRilesyRises)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataTasaEvaporacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_TasaEvaporacion");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TasaEvaporacionMmdia)
                    .HasColumnName("TasaEvaporacion_mmdia")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataTraspasoPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_TraspasoPlataformas");

                entity.Property(e => e.Destino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.ImpregnacionInicial).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LitioInicialPct)
                    .HasColumnName("LitioInicial_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Origen)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolAguaM3)
                    .HasColumnName("VolAgua_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolSalM3)
                    .HasColumnName("VolSal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolSalmueraM3)
                    .HasColumnName("VolSalmuera_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDataTraspasoSubsistemas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvData_TraspasoSubsistemas");

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BTon)
                    .HasColumnName("B_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.CaudalInstantaneoM3s)
                    .HasColumnName("CaudalInstantaneo_m3s")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Destino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Horometro).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiTon)
                    .HasColumnName("Li_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Origen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SatK).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SistemaDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubSistemaDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubSistemaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenTraspasoM3)
                    .HasColumnName("VolumenTraspaso_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvDescargaPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_DescargaPlataformas", "IOV");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolSalidaM3)
                    .HasColumnName("VolSalida_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolenPlataformaM3)
                    .HasColumnName("VolenPlataforma_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvEvaporacionInfiltracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_EvaporacionInfiltracion", "IOV");

                entity.Property(e => e.AlturaSalmueraM)
                    .HasColumnName("AlturaSalmuera_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvExtraccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_Extraccion", "IOV");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.HorasOperacionH)
                    .HasColumnName("HorasOperacion_h")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraDestino)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfraestructuraOrigen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolTraspasoM3)
                    .HasColumnName("VolTraspaso_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvExtraccionAgua>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ExtraccionAgua", "IOV");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.FlujoM3h)
                    .HasColumnName("Flujo_m3h")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfraestructuraOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolFinalM3)
                    .HasColumnName("VolFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolInicialM3)
                    .HasColumnName("VolInicial_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolTotalDia)
                    .HasColumnName("VolTotal_dia")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvFlujos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_Flujos", "IOV");

                entity.Property(e => e.Bomba)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime2(3)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalizadorM3)
                    .HasColumnName("Totalizador_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvImpregnacionCosechas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ImpregnacionCosechas", "IOV");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.HumedadPct)
                    .HasColumnName("Humedad_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvInventariosAtacama>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_InventariosAtacama", "IOV");

                entity.Property(e => e.AlturaSalmueraM)
                    .HasColumnName("AlturaSalmuera_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ComparacionVol)
                    .HasColumnName("Comparacion_vol")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensGcm3)
                    .HasColumnName("Dens_gcm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Factor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.K2so4Eqv)
                    .HasColumnName("K2SO4_eqv")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KclPct)
                    .HasColumnName("KCL_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Li2Co3Eqv)
                    .HasColumnName("Li2CO3_eqv")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgCl26h2o)
                    .HasColumnName("MgCl2_6H2O")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SatK).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInventario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ton)
                    .HasColumnName("ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Volumen).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenCalculado)
                    .HasColumnName("Volumen_Calculado")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvListadoInfraestructuraComponentesPrincipales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GV_ListadoInfraestructuraComponentesPrincipales");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfraestructuraPrincipal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvOperaPozas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_OperaPozas", "IOV");

                entity.Property(e => e.BPct)
                    .HasColumnName("B_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaudalInstantaneoM3s)
                    .HasColumnName("CaudalInstantaneo_m3s")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Horometro).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfraestructuraOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SatK).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenTraspasoM3)
                    .HasColumnName("VolumenTraspaso_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvPciacopiosCli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_PCIAcopiosCLi", "IOV");

                entity.Property(e => e.Acopio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdPciacopiosCli).HasColumnName("IdPCIAcopiosCLi");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvPcimodos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_PCIModos", "IOV");

                entity.Property(e => e.CorrientePci)
                    .HasColumnName("CorrientePCI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdPcimodos).HasColumnName("IdPCIModos");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaLceTon)
                    .HasColumnName("Masa_LCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ModalidadPci)
                    .HasColumnName("ModalidadPCI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPci)
                    .HasColumnName("TipoPCI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvPorteos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_Porteos", "IOV");

                entity.Property(e => e.CaSalmPct)
                    .HasColumnName("Ca_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaSolPct)
                    .HasColumnName("Ca_Sol_Pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSalmPct)
                    .HasColumnName("Cl_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSolPct)
                    .HasColumnName("Cl_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensSalmGml)
                    .HasColumnName("Dens_Salm_gml")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.FechaHora).HasColumnType("datetime2(3)");

                entity.Property(e => e.FlujoRepulpeo).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H2o170gcSolPct)
                    .HasColumnName("H2O170gc_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3SolPct)
                    .HasColumnName("H3BO3_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSolPct)
                    .HasColumnName("K_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSalmPct)
                    .HasColumnName("Li_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSolPct)
                    .HasColumnName("Li_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSalmPct)
                    .HasColumnName("Mg_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSolPct)
                    .HasColumnName("Mg_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSalmPct)
                    .HasColumnName("Na_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSolPct)
                    .HasColumnName("Na_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4SalmPct)
                    .HasColumnName("SO4_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4SolPct)
                    .HasColumnName("SO4_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TkLimsSolPct)
                    .HasColumnName("TK_LIMS_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TkSiproSolPct)
                    .HasColumnName("TK_SIPRO_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvProdyDespSdeAconsProdK>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ProdyDespSdeAConsProdK", "IOV");

                entity.Property(e => e.Corriente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdProdyDespSdeAconsProdK).HasColumnName("IdProdyDespSdeAConsProdK");

                entity.Property(e => e.InfraestructuraPlanta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModalidadPlanta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdyDespSdeAvariablesNum)
                    .IsRequired()
                    .HasColumnName("ProdyDespSdeAVariablesNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvProdyDespSdeAconsProdK1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_ProdyDespSdeAConsProdK1", "IOV");

                entity.Property(e => e.Corriente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.IdProdyDespSdeAconsProdK1).HasColumnName("IdProdyDespSdeAConsProdK1");

                entity.Property(e => e.InfraestructuraPlanta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModalidadPlanta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdyDespSdeAvariablesNum)
                    .IsRequired()
                    .HasColumnName("ProdyDespSdeAVariablesNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvQuimicaPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_QuimicaPlataformas", "IOV");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvRefCategoriaConsumoAgua>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvRef_CategoriaConsumoAgua");

                entity.Property(e => e.CategoriasConsumoAgua)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Faena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuperGrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvRefFaenasSistemas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvRef_Faenas_Sistemas");

                entity.Property(e => e.Faena)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdFaenasSistemas).HasColumnName("IdFaenas_Sistemas");

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvRefSistemasSubsistemas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvRef_Sistemas_Subsistemas");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReinyeccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_Reinyeccion", "IOV");

                entity.Property(e => e.EvapAreaExpuestaM3dia)
                    .HasColumnName("EvapAreaExpuesta_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.EvapAreaImpM3dia)
                    .HasColumnName("EvapAreaImp_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalmueraInfiltradaM3dia)
                    .HasColumnName("SalmueraInfiltrada_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvRepInventarioAtacamaDelta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvRep_InventarioAtacamaDelta");

                entity.Property(e => e.CaTonDelta)
                    .HasColumnName("Ca_ton_Delta")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.ClTonDelta)
                    .HasColumnName("Cl_ton_Delta")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.H3bo3TonDelta)
                    .HasColumnName("H3BO3_ton_Delta")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTonDelta)
                    .HasColumnName("K_ton_Delta")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTonDelta)
                    .HasColumnName("LCE_ton_Delta")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgTonDelta)
                    .HasColumnName("Mg_ton_Delta")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTonDelta)
                    .HasColumnName("Na_ton_Delta")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4TonDelta)
                    .HasColumnName("SO4_ton_Delta")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInventario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ton)
                    .HasColumnName("ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TonDelta)
                    .HasColumnName("Ton_Delta")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TonPrev)
                    .HasColumnName("Ton_Prev")
                    .HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<GvReportAguaDilucionPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_AguaDilucionPeriodoCalendario", "balance");

                entity.Property(e => e.AguaTon)
                    .HasColumnName("Agua_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon).HasColumnName("K_ton");

                entity.Property(e => e.LceTon).HasColumnName("LCE_ton");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportAguaDilucionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_AguaDilucionPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon)
                    .HasColumnName("Agua_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon).HasColumnName("K_ton");

                entity.Property(e => e.LceTon).HasColumnName("LCE_ton");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportAguaLitioPataformaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_AguaLitioPataformaPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon)
                    .HasColumnName("Agua_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon).HasColumnName("K_ton");

                entity.Property(e => e.LceTon).HasColumnName("LCE_ton");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.SubSistema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportCamionesCarnalitaLiPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_CamionesCarnalitaLiPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.SubSistema)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportCargaPlataformaPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_CargaPlataformaPeriodoCalendario");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportCargaPlataformaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_CargaPlataformaPeriodoOperacional");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportCosechaImpregnacionBischofitaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_CosechaImpregnacionBischofitaPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubSitema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportCosechaImprgCliPciperiodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_CosechaImprgCliPCIPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportCosechaPciperiodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_CosechaPCIPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportCosechas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_Cosechas");

                entity.Property(e => e.AlturaPozaM)
                    .HasColumnName("AlturaPoza_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.HumPct)
                    .HasColumnName("Hum_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImprgPct)
                    .HasColumnName("Imprg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.PeriodOperacional).HasColumnType("datetime");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportCragaPlataformaPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_CragaPlataformaPeriodoCalendario");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportDeltaInventarioAtacamaPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_DeltaInventarioAtacamaPeriodoCalendario", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3b03Ton)
                    .HasColumnName("H3B03_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportDeltaInventarioAtacamaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_DeltaInventarioAtacamaPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3b03Ton)
                    .HasColumnName("H3B03_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportDeltaInventarioPlataformaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_DeltaInventarioPlataformaPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SubSistema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportDeltaInvetarioAcopioPciperiodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_DeltaInvetarioAcopioPCIPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon).HasColumnName("K_ton");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportDescargaPlataforma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_DescargaPlataforma");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Destinos)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3b3oTon)
                    .HasColumnName("H3B3O_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolSalidaM3)
                    .HasColumnName("VolSalida_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolenPlataformaM3)
                    .HasColumnName("VolenPlataforma_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(38, 7)");
            });

            modelBuilder.Entity<GvReportDescargaPlataformasPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_DescargaPlataformasPeriodoCalendario");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.H3b3oTon)
                    .HasColumnName("H3B3O_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportDescargaPlataformasPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_DescargaPlataformasPeriodoOperacional");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.H3b3oTon)
                    .HasColumnName("H3B3O_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportEntradaAcopioPciperiodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_EntradaAcopioPCIPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon).HasColumnName("K_ton");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportEvaporacionPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_EvaporacionPeriodoCalendario", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon).HasColumnName("K_ton");

                entity.Property(e => e.LceTon).HasColumnName("LCE_ton");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.SubSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportEvaporacionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_EvaporacionPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon).HasColumnName("K_ton");

                entity.Property(e => e.LceTon).HasColumnName("LCE_ton");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportExtraccionMopiireinyecionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ExtraccionMOPIIReinyecionPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportExtraccionPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ExtraccionPeriodoCalendario", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportExtraccionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ExtraccionPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportFlujosPorteoAjuste>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_FlujosPorteoAjuste");

                entity.Property(e => e.CaSalmPct)
                    .HasColumnName("Ca_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaSolPct)
                    .HasColumnName("Ca_Sol_Pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSalmPct)
                    .HasColumnName("Cl_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSolPct)
                    .HasColumnName("Cl_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensSalmGml)
                    .HasColumnName("Dens_Salm_gml")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("datetime2(3)");

                entity.Property(e => e.Flujo).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.FlujoDifM3)
                    .HasColumnName("Flujo_dif_m3")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.FlujoRepulpeo).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H2o170gcSolPct)
                    .HasColumnName("H2O170gc_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3SolPct)
                    .HasColumnName("H3BO3_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSolPct)
                    .HasColumnName("K_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSalmPct)
                    .HasColumnName("Li_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSolPct)
                    .HasColumnName("Li_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSalmPct)
                    .HasColumnName("Mg_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSolPct)
                    .HasColumnName("Mg_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSalmPct)
                    .HasColumnName("Na_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSolPct)
                    .HasColumnName("Na_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4SalmPct)
                    .HasColumnName("SO4_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4SolPct)
                    .HasColumnName("SO4_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TkLimsSolPct)
                    .HasColumnName("TK_LIMS_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TkSiproSolPct)
                    .HasColumnName("TK_SIPRO_Sol_pct")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvReportImpregnacionCosechaPciperiodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ImpregnacionCosechaPCIPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportImpregnacionCosechaPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ImpregnacionCosechaPeriodoCalendario", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportImpregnacionCosechaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ImpregnacionCosechaPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportImpregnacionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ImpregnacionPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportInfiltracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_Infiltracion");

                entity.Property(e => e.AlturaSalmueraM)
                    .HasColumnName("AlturaSalmuera_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Factor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermeabilidadM3m2dia)
                    .HasColumnName("Permeabilidad_m3m2dia")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaAtacama)
                    .HasColumnName("Sistema_Atacama")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SubSistemaAtacama)
                    .HasColumnName("SubSistema_Atacama")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportInfiltracionMensual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_Infiltracion_Mensual");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vol3)
                    .HasColumnName("Vol_3")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<GvReportInfiltracionMensual2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_Infiltracion_Mensual2");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vol3)
                    .HasColumnName("Vol_3")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<GvReportInfoPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_InfoPlataformas");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlataformaPadre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<GvReportInfoPlataformasPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_InfoPlataformasPeriodoCalendario");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<GvReportInfoPlataformasPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_InfoPlataformasPeriodoOperacional");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<GvReportLitioPlataformaCosechaImpgPlataformaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_LitioPlataformaCosechaImpgPlataformaPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3b3oTon)
                    .HasColumnName("H3B3O_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportReinyeccionIndirectaQuimica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ReinyeccionIndirectaQuimica");

                entity.Property(e => e.CaSalmPct)
                    .HasColumnName("Ca_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaSalmTon)
                    .HasColumnName("Ca_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSolPct)
                    .HasColumnName("Ca_Sol_Pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaSolTon)
                    .HasColumnName("Ca_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSalmPct)
                    .HasColumnName("Cl_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSalmTon)
                    .HasColumnName("Cl_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSolPct)
                    .HasColumnName("Cl_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSolTon)
                    .HasColumnName("Cl_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensSalmGml)
                    .HasColumnName("Dens_Salm_gml")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadPulpa)
                    .HasColumnName("Densidad_pulpa")
                    .HasColumnType("numeric(38, 19)");

                entity.Property(e => e.Fecha).HasColumnType("datetime2(3)");

                entity.Property(e => e.FechaGrupo).HasColumnType("date");

                entity.Property(e => e.FlujoPulpaM3)
                    .HasColumnName("Flujo_Pulpa_m3")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.FlujoRepulpeo).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H2o170gcSolPct)
                    .HasColumnName("H2O170gc_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H2o170gcSolTon)
                    .HasColumnName("H2O170gc_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3SolPct)
                    .HasColumnName("H3BO3_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3SolTon)
                    .HasColumnName("H3BO3_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSalmueraTon)
                    .HasColumnName("K_Salmuera_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSolPct)
                    .HasColumnName("K_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSolTon)
                    .HasColumnName("K_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSalmPct)
                    .HasColumnName("Li_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSalmTon)
                    .HasColumnName("Li_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSolPct)
                    .HasColumnName("Li_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSolTon)
                    .HasColumnName("Li_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPulpaTon)
                    .HasColumnName("Masa_Pulpa_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaSalPulpaTon)
                    .HasColumnName("Masa_sal_pulpa_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSalmPct)
                    .HasColumnName("Mg_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSalmTon)
                    .HasColumnName("Mg_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSolPct)
                    .HasColumnName("Mg_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSolTon)
                    .HasColumnName("Mg_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSalmPct)
                    .HasColumnName("Na_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSalmTon)
                    .HasColumnName("Na_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSolPct)
                    .HasColumnName("Na_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSolTon)
                    .HasColumnName("Na_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalmueraPulpaTon)
                    .HasColumnName("Salmuera_pulpa_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4SalmPct)
                    .HasColumnName("SO4_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4SalmTon)
                    .HasColumnName("SO4_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SolPct)
                    .HasColumnName("SO4_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4SolTon)
                    .HasColumnName("SO4_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TkLimsSolPct)
                    .HasColumnName("TK_LIMS_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TkSiproSolPct)
                    .HasColumnName("TK_SIPRO_Sol_pct")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvReportReinyeccionSalmueraPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ReinyeccionSalmueraPeriodoCalendario");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensidadSalmInfiltradaTonm3)
                    .HasColumnName("DensidadSalmInfiltrada_tonm3")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaFinalReinyeccionTondia)
                    .HasColumnName("MasaFinalReinyeccion_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SalmueraInfiltradaM3dia)
                    .HasColumnName("SalmueraInfiltrada_m3dia")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportReinyeccionSalmueraPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_ReinyeccionSalmueraPeriodoOperacional");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensidadSalmInfiltradaTonm3)
                    .HasColumnName("DensidadSalmInfiltrada_tonm3")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaFinalReinyeccionTondia)
                    .HasColumnName("MasaFinalReinyeccion_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasColumnName("PeriodoOPeracional")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalmueraInfiltradaM3dia)
                    .HasColumnName("SalmueraInfiltrada_m3dia")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportSalidaMopIidpsperiodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_SalidaMopIIDPSPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportSalidaMopIireinyeccionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_SalidaMopIIReinyeccionPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportTraspasoEntradaMopiireinyeccionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_TraspasoEntradaMOPIIReinyeccionPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.SubSistema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportTraspasoSalesPlantaMopiireinyeccionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_TraspasoSalesPlantaMOPIIReinyeccionPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportTraspasoSalidaMopiicarnalitaAsperiodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_TraspasoSalidaMOPIICarnalitaASPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");

                entity.Property(e => e.SubSistema)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportTraspasoSubSitemasEntradaPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_TraspasoSubSitemasEntradaPeriodoCalendario", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubSistemaDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportTraspasoSubSitemasEntradaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_TraspasoSubSitemasEntradaPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubSistemaDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportTraspasoSubSitemasSalidaPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_TraspasoSubSitemasSalidaPeriodoCalendario", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubSistemaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvReportTraspasoSubSitemasSalidaPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GvReport_TraspasoSubSitemasSalidaPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubSistemaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvRiegoPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_RiegoPlataformas", "IOV");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolConsumoH2oM3)
                    .HasColumnName("VolConsumoH2O_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvSistemasPorInfraestructuraPeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GV_SistemasPorInfraestructuraPeriodo");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvSubsistemasPorInfraestructuraPeriodoSistema>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GV_SubsistemasPorInfraestructuraPeriodoSistema");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvTasaEvaporacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_TasaEvaporacion", "IOV");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TasaEvaporacionMmdia)
                    .HasColumnName("TasaEvaporacion_mmdia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvTraspasosPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Gv_TraspasosPlataformas", "IOV");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime2(3)");

                entity.Property(e => e.ImpregnacionInicial).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LitioInicialPct)
                    .HasColumnName("LitioInicial_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolAguaM3)
                    .HasColumnName("VolAgua_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolSalM3)
                    .HasColumnName("VolSal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolSalmueraM3)
                    .HasColumnName("VolSalmuera_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvdataCargaPlataforma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVData_CargaPlataforma");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvdataConsLitioLiCo3mensual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVData_ConsLitioLiCO3Mensual");

                entity.Property(e => e.CarbonatoTon)
                    .HasColumnName("Carbonato_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CorrienteLi2Co3)
                    .HasColumnName("CorrienteLi2CO3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdConsLitioLiCo3mensual).HasColumnName("IdConsLitioLiCO3Mensual");

                entity.Property(e => e.Li2Co3FrescaTon)
                    .HasColumnName("Li2CO3_Fresca_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Li2Co3TotalTon)
                    .HasColumnName("Li2CO3_Total_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LitioFrescoTon)
                    .HasColumnName("Litio_Fresco_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvdataCosechas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVData_Cosechas");

                entity.Property(e => e.AlturaPozaM)
                    .HasColumnName("AlturaPoza_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Densidad).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.HumPct)
                    .HasColumnName("Hum_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ImprgPct)
                    .HasColumnName("Imprg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Infraestructura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvdataEvaporacionPreCalculo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVData_EvaporacionPreCalculo");

                entity.Property(e => e.Actividad).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.AlturaSalmueraM)
                    .HasColumnName("AlturaSalmuera_m")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fe)
                    .HasColumnName("FE")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgL).HasColumnType("numeric(36, 14)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvdataPciacopioCli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVData_PCIAcopioCli");

                entity.Property(e => e.Acopio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IdPciacopiosCli).HasColumnName("IdPCIAcopiosCLi");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvdataPciacopioCliFechaOrigen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVData_PCIAcopioCLiFechaOrigen");

                entity.Property(e => e.Acopio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecharigen).HasColumnType("datetime2(3)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<GvrefExtraccionInfraestructurasReinyeccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVRef_ExtraccionInfraestructurasReinyeccion");

                entity.Property(e => e.Infraestructura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvrepCkmopIivolaPorteOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVRep_CKMopIIVolaPorteOperacional");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");
            });

            modelBuilder.Entity<GvrepCkmopIivolaPorteoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVRep_CKMopIIVolaPorteoCalendario");

                entity.Property(e => e.CaTon).HasColumnName("Ca_ton");

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.H3bo3Ton).HasColumnName("H3BO3_ton");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon).HasColumnName("Mg_ton");

                entity.Property(e => e.NaTon).HasColumnName("Na_ton");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton).HasColumnName("SO4_ton");
            });

            modelBuilder.Entity<GvrepPciacopiosCliResumen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVRep_PCIAcopiosCliResumen");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreportCargaPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_CargaPlataformas");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.H3b3oPct)
                    .HasColumnName("H3B3O_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ImpregnacionPct)
                    .HasColumnName("Impregnacion_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InfraestructuraOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TipoSal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreportConsDespachoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_ConsDespachoCalendario");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");
            });

            modelBuilder.Entity<GvreportConsDespachoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_ConsDespachoOperacional");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.ClTon).HasColumnName("Cl_ton");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");
            });

            modelBuilder.Entity<GvreportConsumoAgua>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_ConsumoAgua");

                entity.Property(e => e.GrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuperGrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolAguaM3)
                    .HasColumnName("VolAgua_m3")
                    .HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<GvreportConsumoAguaPvt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_ConsumoAguaPvt");

                entity.Property(e => e.MopH2)
                    .HasColumnName("MOP H-2")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MophI)
                    .HasColumnName("MOPH-I")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Otros)
                    .HasColumnName("OTROS")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Pci)
                    .HasColumnName("PCI")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PorteoMop)
                    .HasColumnName("Porteo MOP")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.PorteoSop)
                    .HasColumnName("Porteo SOP")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.PozasHalitas)
                    .HasColumnName("Pozas Halitas")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.PozasHalitasSilvinitas)
                    .HasColumnName("Pozas Halitas-Silvinitas")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.PozasLitioCarnalitas)
                    .HasColumnName("Pozas Litio-Carnalitas")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.PozasSop)
                    .HasColumnName("Pozas SOP")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Sop)
                    .HasColumnName("SOP")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Soph)
                    .HasColumnName("SOPH")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.SuperGrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TkAguaPP)
                    .HasColumnName("Tk agua (p&p)")
                    .HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<GvreportCosechasPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_CosechasPeriodoCalendario", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreportCosechasPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_CosechasPeriodoOperacional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreportDeltaInventarioAcopioPlataformasTraspasoPlataformasPeriodoOpercional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_DeltaInventarioAcopioPlataformasTraspasoPlataformasPeriodoOpercional", "balance");

                entity.Property(e => e.AguaTon).HasColumnName("Agua_ton");

                entity.Property(e => e.CaTon)
                    .HasColumnName("Ca_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClTon)
                    .HasColumnName("Cl_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.KTon)
                    .HasColumnName("K_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.LceTon)
                    .HasColumnName("LCE_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(38, 7)");

                entity.Property(e => e.MgTon)
                    .HasColumnName("Mg_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.NaTon)
                    .HasColumnName("Na_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Ton)
                    .HasColumnName("SO4_ton")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.SubSistemaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreportFlujos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_Flujos");

                entity.Property(e => e.Fecha).HasColumnType("datetime2(3)");

                entity.Property(e => e.Flujo).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.FlujoDifM3)
                    .HasColumnName("Flujo_dif_m3")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreportReinyeccionBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_ReinyeccionBalance");

                entity.Property(e => e.CaDesbPct)
                    .HasColumnName("Ca_Desb_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaDesbTon)
                    .HasColumnName("Ca_Desb_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaDpsBmPct)
                    .HasColumnName("Ca_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaDpsBmTon)
                    .HasColumnName("Ca_DPS_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSalmBmPct)
                    .HasColumnName("Ca_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSalmBmTon)
                    .HasColumnName("Ca_Salm_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSalmPct)
                    .HasColumnName("Ca_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSalmTon)
                    .HasColumnName("Ca_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSolPct)
                    .HasColumnName("Ca_Sol_Pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSolTon)
                    .HasColumnName("Ca_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClDesbPct)
                    .HasColumnName("Cl_Desb_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClDesbTon)
                    .HasColumnName("Cl_Desb_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClDpsBmPct)
                    .HasColumnName("Cl_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClDpsBmTon)
                    .HasColumnName("Cl_DPS_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSalmBmPct)
                    .HasColumnName("Cl_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSalmBmTon)
                    .HasColumnName("Cl_Salm_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSalmPct)
                    .HasColumnName("Cl_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSalmTon)
                    .HasColumnName("Cl_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSolPct)
                    .HasColumnName("Cl_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSolTon)
                    .HasColumnName("Cl_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensidadPulpaTonm3)
                    .HasColumnName("Densidad_pulpa_tonm3")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensidadSalPulpTonm3)
                    .HasColumnName("Densidad_sal_pulp_tonm3")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.DensidadSalmInfiltradaTonm3)
                    .HasColumnName("DensidadSalmInfiltrada_tonm3")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensidadSalmPulTonm3)
                    .HasColumnName("Densidad_salm_pul_tonm3")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.EvapAreaExpuestaM3dia)
                    .HasColumnName("EvapAreaExpuesta_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.EvapAreaImpM3dia)
                    .HasColumnName("EvapAreaImp_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaGrupo).HasColumnType("date");

                entity.Property(e => e.H3bo3DesbPct)
                    .HasColumnName("H3BO3_Desb_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3DesbTon)
                    .HasColumnName("H3BO3_Desb_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3DpsBmPct)
                    .HasColumnName("H3BO3_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3DpsBmTon)
                    .HasColumnName("H3BO3_DPS_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3SalmBmPct)
                    .HasColumnName("H3BO3_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3SalmBmTon)
                    .HasColumnName("H3BO3_Salm_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3SolPct)
                    .HasColumnName("H3BO3_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3SolTon)
                    .HasColumnName("H3BO3_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KDesbPct)
                    .HasColumnName("K_Desb_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KDesbTon)
                    .HasColumnName("K_Desb_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KDpsBmPct)
                    .HasColumnName("K_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KDpsBmTon)
                    .HasColumnName("K_DPS_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSalmBmPct)
                    .HasColumnName("K_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSalmBmTon)
                    .HasColumnName("K_Salm_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSalmTon)
                    .HasColumnName("K_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSolPct)
                    .HasColumnName("K_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSolTon)
                    .HasColumnName("K_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiDesbPct)
                    .HasColumnName("Li_Desb_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiDesbTon)
                    .HasColumnName("Li_Desb_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiDpsBmPct)
                    .HasColumnName("Li_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiDpsBmTon)
                    .HasColumnName("Li_DPS_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSalmBmPct)
                    .HasColumnName("Li_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSalmBmTon)
                    .HasColumnName("Li_Salm_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSalmPct)
                    .HasColumnName("Li_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSalmTon)
                    .HasColumnName("Li_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSolPct)
                    .HasColumnName("Li_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSolTon)
                    .HasColumnName("Li_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaEvaporadaTotalM3dia)
                    .HasColumnName("MasaEvaporadaTotal_m3dia")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.MasaFinalDpsTondia)
                    .HasColumnName("MasaFinalDPS_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaFinalReinyeccionTondia)
                    .HasColumnName("MasaFinalReinyeccion_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPrecipitadaClTondia)
                    .HasColumnName("MasaPrecipitadaCl_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPrecipitadaNaTondia)
                    .HasColumnName("MasaPrecipitadaNa_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPrecipitadaTondia)
                    .HasColumnName("MasaPrecipitada_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPulpaTondia)
                    .HasColumnName("Masa_Pulpa_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaSalmPulpTondia)
                    .HasColumnName("Masa_Salm_pulp_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgDesbPct)
                    .HasColumnName("Mg_Desb_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgDesbTon)
                    .HasColumnName("Mg_Desb_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgDpsBmPct)
                    .HasColumnName("Mg_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgDpsBmTon)
                    .HasColumnName("Mg_DPS_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSalmBmPct)
                    .HasColumnName("Mg_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSalmBmTon)
                    .HasColumnName("Mg_Salm_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSalmPct)
                    .HasColumnName("Mg_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSalmTon)
                    .HasColumnName("Mg_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSolPct)
                    .HasColumnName("Mg_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSolTon)
                    .HasColumnName("Mg_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaDesbPct)
                    .HasColumnName("Na_Desb_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaDesbTon)
                    .HasColumnName("Na_Desb_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaDpsBmPct)
                    .HasColumnName("Na_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaDpsBmTon)
                    .HasColumnName("Na_DPS_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSalmBmPct)
                    .HasColumnName("Na_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSalmBmTon)
                    .HasColumnName("Na_Salm_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSalmPct)
                    .HasColumnName("Na_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSalmTon)
                    .HasColumnName("Na_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSolPct)
                    .HasColumnName("Na_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSolTon)
                    .HasColumnName("Na_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoOperacional)
                    .HasColumnName("PeriodoOPeracional")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalPulpTondia)
                    .HasColumnName("Sal_pulp_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SalmueraInfiltradaM3dia)
                    .HasColumnName("SalmueraInfiltrada_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4DesbPct)
                    .HasColumnName("SO4_Desb_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4DesbTon)
                    .HasColumnName("SO4_Desb_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4DpsBmPct)
                    .HasColumnName("SO4_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4DpsBmTon)
                    .HasColumnName("SO4_DPS_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SalmBmPct)
                    .HasColumnName("SO4_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SalmBmTon)
                    .HasColumnName("SO4_Salm_BM_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SalmPct)
                    .HasColumnName("SO4_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SalmTon)
                    .HasColumnName("SO4_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SolPct)
                    .HasColumnName("SO4_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SolTon)
                    .HasColumnName("SO4_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SolidoSalmPct)
                    .HasColumnName("Solido_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolSalPulpM3dia)
                    .HasColumnName("Vol_Sal_Pulp_m3dia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.VolSalmPulpM3dia)
                    .HasColumnName("Vol_Salm_pulp_m3dia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.VolumenPulpaM3dia)
                    .HasColumnName("Volumen_pulpa_m3dia")
                    .HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<GvreportReinyeccionDpsperiodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_ReinyeccionDPSPeriodoCalendario");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaFinalDpsTondia)
                    .HasColumnName("MasaFinalDPS_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreportReinyeccionDpsperiodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_ReinyeccionDPSPeriodoOperacional");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaFinalDpsTondia)
                    .HasColumnName("MasaFinalDPS_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasColumnName("PeriodoOPeracional")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreportReinyeccionPreBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReport_ReinyeccionPreBalance");

                entity.Property(e => e.CaDpsBmPct)
                    .HasColumnName("Ca_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSalmBmPct)
                    .HasColumnName("Ca_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSalmPct)
                    .HasColumnName("Ca_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSalmTon)
                    .HasColumnName("Ca_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSolPct)
                    .HasColumnName("Ca_Sol_Pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaSolTon)
                    .HasColumnName("Ca_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClDpsBmPct)
                    .HasColumnName("Cl_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSalmBmPct)
                    .HasColumnName("Cl_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSalmPct)
                    .HasColumnName("Cl_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSalmTon)
                    .HasColumnName("Cl_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSolPct)
                    .HasColumnName("Cl_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ClSolTon)
                    .HasColumnName("Cl_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensidadPulpaTonm3)
                    .HasColumnName("Densidad_pulpa_tonm3")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensidadSalPulpTonm3)
                    .HasColumnName("Densidad_sal_pulp_tonm3")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.DensidadSalmInfiltradaTonm3)
                    .HasColumnName("DensidadSalmInfiltrada_tonm3")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DensidadSalmPulTonm3)
                    .HasColumnName("Densidad_salm_pul_tonm3")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.EvapAreaExpuestaM3dia)
                    .HasColumnName("EvapAreaExpuesta_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.EvapAreaImpM3dia)
                    .HasColumnName("EvapAreaImp_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaGrupo).HasColumnType("date");

                entity.Property(e => e.H3bo3DpsBmPct)
                    .HasColumnName("H3BO3_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3SalmBmPct)
                    .HasColumnName("H3BO3_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3SolPct)
                    .HasColumnName("H3BO3_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3SolTon)
                    .HasColumnName("H3BO3_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.H3bo3Ton)
                    .HasColumnName("H3BO3_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KDpsBmPct)
                    .HasColumnName("K_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSalmBmPct)
                    .HasColumnName("K_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSalmTon)
                    .HasColumnName("K_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSolPct)
                    .HasColumnName("K_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.KSolTon)
                    .HasColumnName("K_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiDpsBmPct)
                    .HasColumnName("Li_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSalmBmPct)
                    .HasColumnName("Li_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSalmPct)
                    .HasColumnName("Li_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSalmTon)
                    .HasColumnName("Li_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSolPct)
                    .HasColumnName("Li_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.LiSolTon)
                    .HasColumnName("Li_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaEvaporadaTotalM3dia)
                    .HasColumnName("MasaEvaporadaTotal_m3dia")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.MasaFinalDpsTondia)
                    .HasColumnName("MasaFinalDPS_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaFinalReinyeccionTondia)
                    .HasColumnName("MasaFinalReinyeccion_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPrecipitadaClTondia)
                    .HasColumnName("MasaPrecipitadaCl_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPrecipitadaNaTondia)
                    .HasColumnName("MasaPrecipitadaNa_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPrecipitadaTondia)
                    .HasColumnName("MasaPrecipitada_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaPulpaTondia)
                    .HasColumnName("Masa_Pulpa_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MasaSalmPulpTondia)
                    .HasColumnName("Masa_Salm_pulp_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgDpsBmPct)
                    .HasColumnName("Mg_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSalmBmPct)
                    .HasColumnName("Mg_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSalmPct)
                    .HasColumnName("Mg_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSalmTon)
                    .HasColumnName("Mg_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSolPct)
                    .HasColumnName("Mg_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.MgSolTon)
                    .HasColumnName("Mg_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaDpsBmPct)
                    .HasColumnName("Na_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSalmBmPct)
                    .HasColumnName("Na_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSalmPct)
                    .HasColumnName("Na_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSalmTon)
                    .HasColumnName("Na_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSolPct)
                    .HasColumnName("Na_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.NaSolTon)
                    .HasColumnName("Na_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SalPulpTondia)
                    .HasColumnName("Sal_pulp_tondia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SalmueraInfiltradaM3dia)
                    .HasColumnName("SalmueraInfiltrada_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.So4DpsBmPct)
                    .HasColumnName("SO4_DPS_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SalmBmPct)
                    .HasColumnName("SO4_Salm_BM_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SalmPct)
                    .HasColumnName("SO4_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SalmTon)
                    .HasColumnName("SO4_Salm_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SolPct)
                    .HasColumnName("SO4_Sol_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.So4SolTon)
                    .HasColumnName("SO4_Sol_ton")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SolidoSalmPct)
                    .HasColumnName("Solido_Salm_pct")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Subsistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolSalPulpM3dia)
                    .HasColumnName("Vol_Sal_Pulp_m3dia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.VolSalmPulpM3dia)
                    .HasColumnName("Vol_Salm_pulp_m3dia")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.VolumenPulpaM3dia)
                    .HasColumnName("Volumen_pulpa_m3dia")
                    .HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<GvreporteEvaporacionPeriodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReporte_EvaporacionPeriodo");

                entity.Property(e => e.Evaporacion).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreporteEvaporacionPeriodoCalendario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReporte_EvaporacionPeriodoCalendario");

                entity.Property(e => e.Evaporacion).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreporteEvaporacionPeriodoOperacional>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReporte_EvaporacionPeriodoOperacional");

                entity.Property(e => e.Evaporacion).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GvreporteEvaporacionPeriodoOperacional2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GVReporte_EvaporacionPeriodoOperacional2");

                entity.Property(e => e.Evaporacion).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.PeriodoOperacional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IcargaPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ICargaPlataformas", "buffers");

                entity.Property(e => e.Ca).HasColumnName("Ca (%)");

                entity.Property(e => e.Cl).HasColumnName("Cl (%)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3 (%)");

                entity.Property(e => e.IdIcargaPlataformas).HasColumnName("IdICargaPlataformas");

                entity.Property(e => e.Impregnación).HasColumnName("%Impregnación");

                entity.Property(e => e.K).HasColumnName("K (%)");

                entity.Property(e => e.Li).HasColumnName("Li (%)");

                entity.Property(e => e.MasaTon).HasColumnName("MASA (ton)");

                entity.Property(e => e.MasaTon1).HasColumnName("MASA (ton).1");

                entity.Property(e => e.MesRes)
                    .HasColumnName("MES RES")
                    .IsUnicode(false);

                entity.Property(e => e.Mg).HasColumnName("Mg (%)");

                entity.Property(e => e.Na).HasColumnName("Na (%)");

                entity.Property(e => e.Poza)
                    .HasColumnName("POZA")
                    .IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("SO4 (%)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3).HasColumnName("VOLUMEN (m3)");
            });

            modelBuilder.Entity<IckmopIivolaPorteo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ICKMopIIVolaPorteo", "buffers");

                entity.Property(e => e.Cs15).HasColumnName("CS-15");

                entity.Property(e => e.Cs25).HasColumnName("CS-25");

                entity.Property(e => e.Cs34).HasColumnName("CS-34");

                entity.Property(e => e.Dps).HasColumnName("DPS");

                entity.Property(e => e.E88).HasColumnName("E-88");

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.IdIckmopIivolaPorteo).HasColumnName("IdICKMopIIVolaPorteo");

                entity.Property(e => e.Ws1).HasColumnName("WS-1");

                entity.Property(e => e.Ws11).HasColumnName("WS-11");

                entity.Property(e => e.Ws142).HasColumnName("WS-142");

                entity.Property(e => e.Ws4).HasColumnName("WS-4");

                entity.Property(e => e.Ws41).HasColumnName("WS-41");
            });

            modelBuilder.Entity<IconsDespacho>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IConsDespacho", "buffers");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.FcCm).HasColumnName("Fc Cm");

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.IdIconsDespacho).HasColumnName("IdIConsDespacho");

                entity.Property(e => e.Lce).HasColumnName("LCE");

                entity.Property(e => e.Li).HasColumnName("%Li");

                entity.Property(e => e.LiMg).HasColumnName("Li/Mg");

                entity.Property(e => e.NCam).HasColumnName("N° Cam");

                entity.Property(e => e.So4).HasColumnName("SO4");

                entity.Property(e => e.String).IsUnicode(false);

                entity.Property(e => e.Sól).HasColumnName("% Sól");

                entity.Property(e => e.TnSlc).HasColumnName("Tn Slc");
            });

            modelBuilder.Entity<Icosechas>(entity =>
            {
                entity.HasKey(e => e.IdIcosechas)
                    .HasName("PK__ICosecha__6A576758C2AC7902");

                entity.ToTable("ICosechas", "buffers");

                entity.Property(e => e.IdIcosechas)
                    .HasColumnName("IdICosechas")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlturaDePozasM).HasColumnName("Altura de Pozas (m)");

                entity.Property(e => e.Ca).HasColumnName("% Ca");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.CosechaM3).HasColumnName("Cosecha (m3)");

                entity.Property(e => e.CosechaT).HasColumnName("Cosecha (t)");

                entity.Property(e => e.DensidadTM3).HasColumnName("Densidad (t/m3)");

                entity.Property(e => e.Descripción).IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3");

                entity.Property(e => e.Hum).HasColumnName("HUM");

                entity.Property(e => e.Impreg).HasColumnName("Impreg.");

                entity.Property(e => e.K).HasColumnName("% K");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Na).HasColumnName("% Na");

                entity.Property(e => e.Pozas).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");
            });

            modelBuilder.Entity<IdescargaPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IDescargaPlataformas", "buffers");

                entity.Property(e => e.Ca).HasColumnName("Ca (%)");

                entity.Property(e => e.Cl).HasColumnName("Cl (%)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3 (%)");

                entity.Property(e => e.IdIdescargaPlataformas).HasColumnName("IdIDescargaPlataformas");

                entity.Property(e => e.Impregnación).HasColumnName("%impregnación");

                entity.Property(e => e.K).HasColumnName("K (%)");

                entity.Property(e => e.Li).HasColumnName("Li (%)");

                entity.Property(e => e.MasaTon).HasColumnName("Masa (ton)");

                entity.Property(e => e.MesRes)
                    .HasColumnName("MES RES")
                    .IsUnicode(false);

                entity.Property(e => e.Mg).HasColumnName("Mg (%)");

                entity.Property(e => e.Na).HasColumnName("Na (%)");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.Plataforma)
                    .HasColumnName("PLATAFORMA")
                    .IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("SO4 (%)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .IsUnicode(false);

                entity.Property(e => e.VolumenEnPlataformaM3).HasColumnName("Volumen en plataforma (m3)");

                entity.Property(e => e.VolumenM3).HasColumnName("VOLUMEN (m3)");

                entity.Property(e => e.VolumenSalidaM3).HasColumnName("Volumen Salida (m3)");
            });

            modelBuilder.Entity<IdiomaFecha>(entity =>
            {
                entity.HasKey(e => e.IdIdiomaFecha)
                    .HasName("PK_IdiomaFecha_IdIdiomaFecha");

                entity.ToTable("IdiomaFecha", "imports");

                entity.HasIndex(e => e.IdiomaFecha1)
                    .HasName("UK_IdiomaFecha_IdiomaFecha")
                    .IsUnique();

                entity.Property(e => e.IdiomaFecha1)
                    .IsRequired()
                    .HasColumnName("IdiomaFecha")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Iextraccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IExtraccion", "buffers");

                entity.Property(e => e.Ca).HasColumnName("%Ca");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3");

                entity.Property(e => e.IdIextraccion).HasColumnName("IdIExtraccion");

                entity.Property(e => e.K).HasColumnName("%k");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");

                entity.Property(e => e.VolTraspaso).HasColumnName("Vol. Traspaso");
            });

            modelBuilder.Entity<IimpregnacionCosechas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IImpregnacionCosechas", "buffers");

                entity.Property(e => e.Ca).HasColumnName("%Ca");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("% H3BO3");

                entity.Property(e => e.IdIimpregnacionCosechas).HasColumnName("IdIImpregnacionCosechas");

                entity.Property(e => e.K).HasColumnName("%K");

                entity.Property(e => e.Li).HasColumnName("%Li");

                entity.Property(e => e.Mg).HasColumnName("%Mg");

                entity.Property(e => e.NProd)
                    .HasColumnName("N_Prod")
                    .IsUnicode(false);

                entity.Property(e => e.Na).HasColumnName("% Na");

                entity.Property(e => e.Poza).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");
            });

            modelBuilder.Entity<IinventariosAtacama>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IInventariosAtacama", "buffers");

                entity.Property(e => e.AlturaSalm).HasColumnName("Altura salm");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.CodInv)
                    .HasColumnName("Cod Inv")
                    .IsUnicode(false);

                entity.Property(e => e.Factor).HasColumnName("factor");

                entity.Property(e => e.H3bo3).HasColumnName("% H3BO3");

                entity.Property(e => e.IdIinventariosAtacama).HasColumnName("IdIInventariosAtacama");

                entity.Property(e => e.K2so4Eqv).HasColumnName("K2SO4 eqv");

                entity.Property(e => e.KclEqv).HasColumnName("KCl eqv");

                entity.Property(e => e.Li2Co3Eqv).HasColumnName("Li2CO3 eqv");

                entity.Property(e => e.MesInvent)
                    .HasColumnName("Mes Invent")
                    .IsUnicode(false);

                entity.Property(e => e.MgCl26h2o).HasColumnName("MgCl2.6H2O");

                entity.Property(e => e.NProducc)
                    .HasColumnName("N_Producc")
                    .IsUnicode(false);

                entity.Property(e => e.Na).HasColumnName("% Na");

                entity.Property(e => e.Pozas).IsUnicode(false);

                entity.Property(e => e.Sistema).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("SO4");

                entity.Property(e => e.Ton).HasColumnName("ton");
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

                entity.HasOne(d => d.IdJobTipoNavigation)
                    .WithMany(p => p.ImportDestino)
                    .HasForeignKey(d => d.IdJobTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSchemaDefNavigation)
                    .WithMany(p => p.ImportDestino)
                    .HasForeignKey(d => d.IdSchemaDef)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Importaciones>(entity =>
            {
                entity.HasKey(e => e.IdImportaciones);

                entity.ToTable("Importaciones", "imports");

                entity.HasIndex(e => e.Uid)
                    .HasName("UX_Importaciones_uid")
                    .IsUnique();

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

                entity.HasOne(d => d.IdImportacionesNavigation)
                    .WithMany(p => p.ImportacionesUserParValues)
                    .HasForeignKey(d => d.IdImportaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdImportadoresUserParNavigation)
                    .WithMany(p => p.ImportacionesUserParValues)
                    .HasForeignKey(d => d.IdImportadoresUserPar)
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

                entity.HasOne(d => d.IdImportadoresNavigation)
                    .WithMany(p => p.ImportadoresUserPar)
                    .HasForeignKey(d => d.IdImportadores)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdTipoDatoControlNavigation)
                    .WithMany(p => p.ImportadoresUserPar)
                    .HasForeignKey(d => d.IdTipoDatoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull);
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaM3)
                    .HasColumnName("Cosecha_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CosechaTon)
                    .HasColumnName("Cosecha_Ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.HumedadPct)
                    .HasColumnName("Humedad_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((1))");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

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

                entity.Property(e => e.ImpregnacionTotal).HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AreaM2)
                    .HasColumnName("Area_m2")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ComparacionVol)
                    .HasColumnName("Comparacion_vol")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensGcm3)
                    .HasColumnName("Dens_gcm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Factor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.K2so4Eqv)
                    .HasColumnName("K2SO4_eqv")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KclPct)
                    .HasColumnName("KCL_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Li2Co3Eqv)
                    .HasColumnName("Li2CO3_eqv")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgCl26h2o)
                    .HasColumnName("MgCl2_6H2O")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((1))");

                entity.Property(e => e.SatK).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Ton)
                    .HasColumnName("ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Volumen).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenCalculado)
                    .HasColumnName("Volumen_Calculado")
                    .HasColumnType("decimal(19, 4)");

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

            modelBuilder.Entity<IoperaPozasLitio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IOperaPozasLitio", "buffers");

                entity.Property(e => e.Ca).HasColumnName("%Ca");

                entity.Property(e => e.Caudal).HasColumnName("CAUDAL");

                entity.Property(e => e.Cl).HasColumnName("%Cl");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.Final).HasColumnName("FINAL");

                entity.Property(e => e.H3bo3).HasColumnName("%H3BO3");

                entity.Property(e => e.IdIoperaPozasLitio).HasColumnName("IdIOperaPozasLitio");

                entity.Property(e => e.Inicial).HasColumnName("INICIAL");

                entity.Property(e => e.K).HasColumnName("%K");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Na).HasColumnName("%Na");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");

                entity.Property(e => e.VolTraspaso).HasColumnName("Vol. Traspaso");
            });

            modelBuilder.Entity<IoperaPozasMopi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IOperaPozasMOPI", "buffers");

                entity.Property(e => e.Ca).HasColumnName("%Ca");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("H3BO3");

                entity.Property(e => e.IdIoperaPozasMopi).HasColumnName("IdIOperaPozasMOPI");

                entity.Property(e => e.K).HasColumnName("%K.");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.QInst).HasColumnName("Q Inst.");

                entity.Property(e => e.SatK).HasColumnName("Sat.K");

                entity.Property(e => e.So4).HasColumnName("%SO4");

                entity.Property(e => e.VolTraspaso).HasColumnName("Vol. Traspaso");
            });

            modelBuilder.Entity<IoperaPozasMopii>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IOperaPozasMOPII", "buffers");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.H3bo3).HasColumnName("%H3BO3");

                entity.Property(e => e.HorasOperación).HasColumnName("Horas Operación");

                entity.Property(e => e.IdIoperaPozasMopii).HasColumnName("IdIOperaPozasMOPII");

                entity.Property(e => e.K).HasColumnName("% K");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Na).HasColumnName("% Na");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.QInst).HasColumnName("Q inst");

                entity.Property(e => e.So4).HasColumnName("%SO4");

                entity.Property(e => e.VolTraspaso).HasColumnName("Vol, Traspaso");
            });

            modelBuilder.Entity<IoperaPozasMopiii>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IOperaPozasMOPIII", "buffers");

                entity.Property(e => e.B).HasColumnName(" B");

                entity.Property(e => e.Ca).HasColumnName("% Ca");

                entity.Property(e => e.Cl).HasColumnName("% Cl");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.Horas).HasColumnName("HORAS");

                entity.Property(e => e.IdIoperaPozasMopiii).HasColumnName("IdIOperaPozasMOPIII");

                entity.Property(e => e.K).HasColumnName("% K");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");

                entity.Property(e => e.VolTraspaso).HasColumnName("Vol. Traspaso");
            });

            modelBuilder.Entity<IoperaPozasSopii>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IOperaPozasSOPII", "buffers");

                entity.Property(e => e.B).HasColumnName(" B");

                entity.Property(e => e.Ca).HasColumnName("% Ca");

                entity.Property(e => e.Densidad).HasColumnName("DENSIDAD");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.IdIoperaPozasSopii).HasColumnName("IdIOperaPozasSOPII");

                entity.Property(e => e.K).HasColumnName("% K");

                entity.Property(e => e.Li).HasColumnName("% Li");

                entity.Property(e => e.Mg).HasColumnName("% Mg");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.So4).HasColumnName("%SO4");

                entity.Property(e => e.VolTraspaso).HasColumnName("Vol. Traspaso");
            });

            modelBuilder.Entity<ItasaEvaporacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ITasaEvaporacion", "buffers");

                entity.Property(e => e.Dia)
                    .HasColumnName("dia")
                    .IsUnicode(false);

                entity.Property(e => e.Dif12).HasColumnName("Dif. (1).(2)");

                entity.Property(e => e.EvapMáx1).HasColumnName("Evap. Máx (1)");

                entity.Property(e => e.EvapMáx2).HasColumnName("Evap. Máx (2)");

                entity.Property(e => e.HumMax).HasColumnName("hum. Max");

                entity.Property(e => e.HumMin).HasColumnName("hum. Min");

                entity.Property(e => e.HumProm).HasColumnName("hum. Prom.");

                entity.Property(e => e.IdItasaEvaporacion).HasColumnName("IdITasaEvaporacion");

                entity.Property(e => e.PrecipTot).HasColumnName("precip. Tot.");

                entity.Property(e => e.PresiónAtm).HasColumnName("Presión atm.");

                entity.Property(e => e.PromEvp).HasColumnName("Prom. Evp.");

                entity.Property(e => e.RadSolar).HasColumnName("rad. Solar");

                entity.Property(e => e.TMin).HasColumnName("T.min");

                entity.Property(e => e.TPromedio).HasColumnName("T promedio");

                entity.Property(e => e.Tmáx).HasColumnName("Tmáx.");

                entity.Property(e => e.VelViento).HasColumnName("vel. Viento");
            });

            modelBuilder.Entity<ItraspasosPlataformas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ITraspasosPlataformas", "buffers");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.Fecha).IsUnicode(false);

                entity.Property(e => e.IdItraspasosPlataformas).HasColumnName("IdITraspasosPlataformas");

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.PDeImpregnación).HasColumnName("P.de Impregnación");

                entity.Property(e => e.PDeLiInicial).HasColumnName("P. de Li Inicial");

                entity.Property(e => e.Plataforma).IsUnicode(false);

                entity.Property(e => e.VolAgua).HasColumnName("Vol.Agua");

                entity.Property(e => e.VolSal).HasColumnName("Vol. Sal");
            });

            modelBuilder.Entity<JobTipo>(entity =>
            {
                entity.HasKey(e => e.IdJobTipo)
                    .HasName("PK_JobTipo_IdJobTipo");

                entity.ToTable("JobTipo", "imports");

                entity.HasIndex(e => e.JobTipo1)
                    .HasName("UK_JobTipo_JobTipo")
                    .IsUnique();

                entity.Property(e => e.JobTipo1)
                    .IsRequired()
                    .HasColumnName("JobTipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Localizaciones>(entity =>
            {
                entity.HasKey(e => e.IdLocalizacion);

                entity.ToTable("Localizaciones", "internals");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Localizacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

                entity.HasOne(d => d.IdTipoMensajeNavigation)
                    .WithMany(p => p.MensajesImportacion)
                    .HasForeignKey(d => d.IdTipoMensaje)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MensajesImportacionTemp>(entity =>
            {
                entity.HasKey(e => e.IdMensajesImportacion)
                    .HasName("PK_MensajesImportacionTemp_IdMensajesImportacion");

                entity.ToTable("MensajesImportacionTemp", "imports");

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
                    .WithMany(p => p.MensajesImportacionTemp)
                    .HasForeignKey(d => d.IdImportaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdTipoMensajeNavigation)
                    .WithMany(p => p.MensajesImportacionTemp)
                    .HasForeignKey(d => d.IdTipoMensaje)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MensajesImportacionTemp_IdTipoMensaje");
            });

            modelBuilder.Entity<MeteorologíaSalarNuevaJunioKcl2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Meteorología Salar Nueva Junio KCL 2020");

                entity.Property(e => e.Dia)
                    .HasColumnName("dia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dif12)
                    .HasColumnName("Dif  (1) (2)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EvapMáx1)
                    .HasColumnName("Evap  Máx (1)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EvapMáx2)
                    .HasColumnName("Evap  Máx (2)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HumMax)
                    .HasColumnName("hum  Max")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HumMin)
                    .HasColumnName("hum  Min")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HumProm)
                    .HasColumnName("hum  Prom ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrecipTot)
                    .HasColumnName("precip  Tot ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PresiónAtm)
                    .HasColumnName("Presión atm ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromEvp)
                    .HasColumnName("Prom  Evp ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RadSolar)
                    .HasColumnName("rad  Solar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TMin)
                    .HasColumnName("T min")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TPromedio)
                    .HasColumnName("T promedio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tmáx)
                    .HasColumnName("Tmáx ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VelViento)
                    .HasColumnName("vel  Viento")
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

            modelBuilder.Entity<MultiAliases>(entity =>
            {
                entity.HasKey(e => e.IdMultiAliases)
                    .HasName("PK_MultiAliases_IdAliases");

                entity.ToTable("MultiAliases", "imports");

                entity.HasIndex(e => new { e.Importador, e.Campo1, e.ValorOriginal1 })
                    .HasName("UK_Aliases")
                    .IsUnique();

                entity.Property(e => e.Alias1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Alias2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Importador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorOriginal1)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ValorOriginal2)
                    .HasMaxLength(4000)
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaPct)
                    .HasColumnName("Ca_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaudalInstantaneoM3s)
                    .HasColumnName("CaudalInstantaneo_m3s")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Horometro).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SatK).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenFinalM3)
                    .HasColumnName("VolumenFinal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenInicialM3)
                    .HasColumnName("VolumenInicial_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolumenTraspasoM3)
                    .HasColumnName("VolumenTraspaso_m3")
                    .HasColumnType("decimal(19, 4)");

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

                entity.HasIndex(e => new { e.IdImportadores, e.OrigenDatos, e.Tab })
                    .HasName("UK_OrigenesDatos")
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

                entity.HasOne(d => d.IdTipoHeaderNavigation)
                    .WithMany(p => p.OrigenesDatos)
                    .HasForeignKey(d => d.IdTipoHeader)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdTipoOrigenNavigation)
                    .WithMany(p => p.OrigenesDatos)
                    .HasForeignKey(d => d.IdTipoOrigen)
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdPciacopiosOrigen).HasColumnName("IdPCIAcopiosOrigen");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumenM3)
                    .HasColumnName("Volumen_m3")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaLceTon)
                    .HasColumnName("Masa_LCE_ton")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MasaTon)
                    .HasColumnName("Masa_ton")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CaSolPct)
                    .HasColumnName("Ca_Sol_Pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSalmPct)
                    .HasColumnName("Cl_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClSolPct)
                    .HasColumnName("Cl_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensSalmGml)
                    .HasColumnName("Dens_Salm_gml")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaHora).HasColumnType("datetime2(3)");

                entity.Property(e => e.FlujoRepulpeo).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H2o170gcSolPct)
                    .HasColumnName("H2O170gc_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.H3bo3SolPct)
                    .HasColumnName("H3BO3_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IdSistemasSubsistemas).HasColumnName("IdSistemas_Subsistemas");

                entity.Property(e => e.KSalmPct)
                    .HasColumnName("K_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KSolPct)
                    .HasColumnName("K_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSalmPct)
                    .HasColumnName("Li_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiSolPct)
                    .HasColumnName("Li_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSalmPct)
                    .HasColumnName("Mg_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgSolPct)
                    .HasColumnName("Mg_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSalmPct)
                    .HasColumnName("Na_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaSolPct)
                    .HasColumnName("Na_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4SalmPct)
                    .HasColumnName("SO4_Salm_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4SolPct)
                    .HasColumnName("SO4_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TkLimsSolPct)
                    .HasColumnName("TK_LIMS_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TkSiproSolPct)
                    .HasColumnName("TK_SIPRO_Sol_pct")
                    .HasColumnType("decimal(19, 4)");

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

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");

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

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");

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

            modelBuilder.Entity<PueblaTablaReporteBalanceLogEjecucion>(entity =>
            {
                entity.HasKey(e => e.IdEjecucion);

                entity.ToTable("PueblaTablaReporteBalanceLogEjecucion", "balance");

                entity.Property(e => e.ErrorMensaje)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEjecucion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uidkey).HasColumnName("uidkey");

                entity.Property(e => e.UsuarioEjecucion)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("([dbo].[GetUsuarioSesion]())");
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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ClPct)
                    .HasColumnName("Cl_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.DensidadTonm3)
                    .HasColumnName("Densidad_tonm3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H3bo3Pct)
                    .HasColumnName("H3BO3_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.KPct)
                    .HasColumnName("K_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LiPct)
                    .HasColumnName("Li_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MgPct)
                    .HasColumnName("Mg_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NaPct)
                    .HasColumnName("Na_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.So4Pct)
                    .HasColumnName("SO4_pct")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.EvapAreaImpM3dia)
                    .HasColumnName("EvapAreaImp_m3dia")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime2(3)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSistemasSubsitemas).HasColumnName("IdSistemas_Subsitemas");

                entity.Property(e => e.SalmueraInfiltradaM3dia)
                    .HasColumnName("SalmueraInfiltrada_m3dia")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.IdPeriodosNavigation)
                    .WithMany(p => p.RiegoPlataformas)
                    .HasForeignKey(d => d.IdPeriodos)
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

                entity.HasIndex(e => new { e.IdSchemaDef, e.NombreCol, e.PosicionCol })
                    .HasName("UK_SchemaColumns_Pos")
                    .IsUnique();

                entity.Property(e => e.Ffill)
                    .HasColumnName("ffill")
                    .HasDefaultValueSql("((0))");

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

                entity.Property(e => e.Pivoted).HasDefaultValueSql("((0))");

                entity.Property(e => e.RangoFechaFin).HasColumnType("datetime2(3)");

                entity.Property(e => e.RangoFechaInicio).HasColumnType("datetime2(3)");

                entity.Property(e => e.RangoNumFin).HasColumnType("decimal(19, 7)");

                entity.Property(e => e.RangoNumInicio).HasColumnType("decimal(19, 7)");

                entity.Property(e => e.Requerido).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unico).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdDatosEnListaNavigation)
                    .WithMany(p => p.SchemaColumns)
                    .HasForeignKey(d => d.IdDatosEnLista);

                entity.HasOne(d => d.IdFilteredByControlNavigation)
                    .WithMany(p => p.SchemaColumns)
                    .HasForeignKey(d => d.IdFilteredByControl)
                    .HasConstraintName("FK_SchemaColumns_ImportadoresUserPar_IdImportadoresUserPar");

                entity.HasOne(d => d.IdIdiomaFechaNavigation)
                    .WithMany(p => p.SchemaColumns)
                    .HasForeignKey(d => d.IdIdiomaFecha);

                entity.HasOne(d => d.IdSchemaDefNavigation)
                    .WithMany(p => p.SchemaColumns)
                    .HasForeignKey(d => d.IdSchemaDef)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdTipoDatoColOrigenNavigation)
                    .WithMany(p => p.SchemaColumns)
                    .HasForeignKey(d => d.IdTipoDatoColOrigen)
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

                entity.HasOne(d => d.IdIdiomaFechaNavigation)
                    .WithMany(p => p.SchemaColumnsWarning)
                    .HasForeignKey(d => d.IdIdiomaFecha);

                entity.HasOne(d => d.IdSchemaDefNavigation)
                    .WithMany(p => p.SchemaColumnsWarning)
                    .HasForeignKey(d => d.IdSchemaDef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchemaColumnsWarning_IdSchemaDef");

                entity.HasOne(d => d.IdTipoDatoColOrigenNavigation)
                    .WithMany(p => p.SchemaColumnsWarning)
                    .HasForeignKey(d => d.IdTipoDatoColOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchemaColumnsWarning_IdTipoDatoColOrigen");
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

                entity.Property(e => e.GrupoReporte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

            modelBuilder.Entity<SourceNovt>(entity =>
            {
                entity.HasKey(e => e._0IdSincronizacionCorfo)
                    .HasName("PK__Source_N__24C913064D71F0B5");

                entity.ToTable("Source_NOVT", "migra");

                entity.Property(e => e._0IdSincronizacionCorfo)
                    .HasColumnName("0_IdSincronizacionCORFO")
                    .ValueGeneratedNever();

                entity.Property(e => e._0IdMensaje).HasColumnName("0_IdMensaje");

                entity.Property(e => e._0NombreTabla)
                    .IsRequired()
                    .HasColumnName("0_NombreTabla")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._0Observacion)
                    .HasColumnName("0_Observacion")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e._0TipoTransaccion)
                    .HasColumnName("0_TipoTransaccion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._10Comentario)
                    .HasColumnName("10_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._10Eliminado).HasColumnName("10_Eliminado");

                entity.Property(e => e._10Empresa)
                    .HasColumnName("10_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Fecha)
                    .HasColumnName("10_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._10IdAforo).HasColumnName("10_IdAforo");

                entity.Property(e => e._10Infraestructura)
                    .HasColumnName("10_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Log).HasColumnName("10_Log");

                entity.Property(e => e._10MetodoFisico)
                    .HasColumnName("10_MetodoFisico")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Modificado).HasColumnName("10_Modificado");

                entity.Property(e => e._10Publicado).HasColumnName("10_Publicado");

                entity.Property(e => e._10TipoEnsayo)
                    .HasColumnName("10_TipoEnsayo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Unidad)
                    .HasColumnName("10_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._10Validado).HasColumnName("10_Validado");

                entity.Property(e => e._10Valor)
                    .HasColumnName("10_Valor")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._11Analito)
                    .HasColumnName("11_Analito")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Comentario)
                    .HasColumnName("11_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._11Descriptor)
                    .HasColumnName("11_Descriptor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Eliminado).HasColumnName("11_Eliminado");

                entity.Property(e => e._11Fecha)
                    .HasColumnName("11_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._11IdAnalisisQuimico).HasColumnName("11_IdAnalisisQuimico");

                entity.Property(e => e._11Infraestructura)
                    .HasColumnName("11_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Laboratorio)
                    .HasColumnName("11_Laboratorio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Log).HasColumnName("11_Log");

                entity.Property(e => e._11Modificado).HasColumnName("11_Modificado");

                entity.Property(e => e._11Publicado).HasColumnName("11_Publicado");

                entity.Property(e => e._11Unidad)
                    .HasColumnName("11_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11Validado).HasColumnName("11_Validado");

                entity.Property(e => e._11Valor)
                    .HasColumnName("11_Valor")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._12CotaPuntoReferenciaMsnm)
                    .HasColumnName("12_CotaPuntoReferencia_msnm")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._12Eliminado).HasColumnName("12_Eliminado");

                entity.Property(e => e._12IdCoordenada).HasColumnName("12_IdCoordenada");

                entity.Property(e => e._12Infraestructura)
                    .HasColumnName("12_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._12InicioVigencia)
                    .HasColumnName("12_InicioVigencia")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._12Log).HasColumnName("12_Log");

                entity.Property(e => e._12TerminoVigencia)
                    .HasColumnName("12_TerminoVigencia")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._12UtmEste)
                    .HasColumnName("12_UTM_Este")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._12UtmNorte)
                    .HasColumnName("12_UTM_Norte")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._13Comentario)
                    .HasColumnName("13_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._13Eliminado).HasColumnName("13_Eliminado");

                entity.Property(e => e._13Empresa)
                    .HasColumnName("13_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._13Fecha)
                    .HasColumnName("13_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._13IdCuna).HasColumnName("13_IdCuna");

                entity.Property(e => e._13Infraestructura)
                    .HasColumnName("13_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._13Log).HasColumnName("13_Log");

                entity.Property(e => e._13Modificado).HasColumnName("13_Modificado");

                entity.Property(e => e._13Profundidad)
                    .HasColumnName("13_Profundidad")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._13Publicado).HasColumnName("13_Publicado");

                entity.Property(e => e._13TipoEnsayo)
                    .HasColumnName("13_TipoEnsayo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._13Unidad)
                    .HasColumnName("13_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._13Validado).HasColumnName("13_Validado");

                entity.Property(e => e._13Valor)
                    .HasColumnName("13_Valor")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._18Comentario)
                    .HasColumnName("18_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._18Eliminado).HasColumnName("18_Eliminado");

                entity.Property(e => e._18Estacion)
                    .HasColumnName("18_Estacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._18Fecha)
                    .HasColumnName("18_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._18Frecuencia)
                    .HasColumnName("18_Frecuencia")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._18IdMedicionEstacion).HasColumnName("18_IdMedicionEstacion");

                entity.Property(e => e._18Log).HasColumnName("18_Log");

                entity.Property(e => e._18Modificado).HasColumnName("18_Modificado");

                entity.Property(e => e._18Parametro)
                    .HasColumnName("18_Parametro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._18Publicado).HasColumnName("18_Publicado");

                entity.Property(e => e._18TipoDato)
                    .HasColumnName("18_TipoDato")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._18Unidad)
                    .HasColumnName("18_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._18Validado).HasColumnName("18_Validado");

                entity.Property(e => e._18Valor)
                    .HasColumnName("18_Valor")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._19Comentario)
                    .HasColumnName("19_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._19CotaNivelMsnm)
                    .HasColumnName("19_CotaNivel_msnm")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._19CotaPuntoReferenciaMsnm)
                    .HasColumnName("19_CotaPuntoReferencia_msnm")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._19Eliminado).HasColumnName("19_Eliminado");

                entity.Property(e => e._19Empresa)
                    .HasColumnName("19_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._19Fecha)
                    .HasColumnName("19_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._19IdNivel).HasColumnName("19_IdNivel");

                entity.Property(e => e._19Infraestructura)
                    .HasColumnName("19_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._19Log).HasColumnName("19_Log");

                entity.Property(e => e._19MedicionBajoPuntoReferenciaM)
                    .HasColumnName("19_MedicionBajoPuntoReferencia_m")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._19ModalidadNivel)
                    .HasColumnName("19_ModalidadNivel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._19Modificado).HasColumnName("19_Modificado");

                entity.Property(e => e._19Nbprinicial)
                    .HasColumnName("19_NBPRInicial")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._19NivelRelativo)
                    .HasColumnName("19_NivelRelativo")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._19PlanContingencia).HasColumnName("19_PlanContingencia");

                entity.Property(e => e._19Publicado).HasColumnName("19_Publicado");

                entity.Property(e => e._19TipoNivel)
                    .HasColumnName("19_TipoNivel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._19Validado).HasColumnName("19_Validado");

                entity.Property(e => e._1Descripcion)
                    .HasColumnName("1_DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._1Fecha)
                    .HasColumnName("1_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e._1IdVariable)
                    .HasColumnName("1_ID_VARIABLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e._1ResultNumber)
                    .HasColumnName("1_RESULT_NUMBER")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e._1SValor)
                    .HasColumnName("1_sValor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e._1Valor)
                    .HasColumnName("1_VALOR")
                    .HasColumnType("decimal(18, 10)");

                entity.Property(e => e._20Comentario)
                    .HasColumnName("20_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._20CotaNivelMsnm)
                    .HasColumnName("20_CotaNivel_msnm")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._20CotaPuntoReferenciaMsnm)
                    .HasColumnName("20_CotaPuntoReferencia_msnm")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._20Eliminado).HasColumnName("20_Eliminado");

                entity.Property(e => e._20Empresa)
                    .HasColumnName("20_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._20Fecha)
                    .HasColumnName("20_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._20IdNivel).HasColumnName("20_IdNivel");

                entity.Property(e => e._20Infraestructura)
                    .HasColumnName("20_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._20Log).HasColumnName("20_Log");

                entity.Property(e => e._20MedicionBajoPuntoReferenciaM)
                    .HasColumnName("20_MedicionBajoPuntoReferencia_m")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._20ModalidadNivel)
                    .HasColumnName("20_ModalidadNivel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._20Modificado).HasColumnName("20_Modificado");

                entity.Property(e => e._20Nbprinicial)
                    .HasColumnName("20_NBPRInicial")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e._20NivelRelativo)
                    .HasColumnName("20_NivelRelativo")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e._20PlanContingencia).HasColumnName("20_PlanContingencia");

                entity.Property(e => e._20Publicado).HasColumnName("20_Publicado");

                entity.Property(e => e._20TipoNivel)
                    .HasColumnName("20_TipoNivel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e._20Validado).HasColumnName("20_Validado");

                entity.Property(e => e._21CotaFaseI)
                    .HasColumnName("21_CotaFase_I")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e._21CotaFaseIi)
                    .HasColumnName("21_CotaFase_II")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e._21DescensoFaseI)
                    .HasColumnName("21_DescensoFase_I")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e._21DescensoFaseIi)
                    .HasColumnName("21_DescensoFase_II")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e._21Eliminado).HasColumnName("21_Eliminado");

                entity.Property(e => e._21FechaVigencia)
                    .HasColumnName("21_FechaVigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e._21GrafInferior)
                    .HasColumnName("21_grafInferior")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e._21GrafSuperior)
                    .HasColumnName("21_grafSuperior")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e._21IdTauxiliar).HasColumnName("21_IdTAuxiliar");

                entity.Property(e => e._21Infraestructura)
                    .HasColumnName("21_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._21Log).HasColumnName("21_Log");

                entity.Property(e => e._21Sistema)
                    .HasColumnName("21_Sistema")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._21Subsistema)
                    .HasColumnName("21_Subsistema")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Comentario)
                    .HasColumnName("22_Comentario")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e._22Eliminado).HasColumnName("22_Eliminado");

                entity.Property(e => e._22Empresa)
                    .HasColumnName("22_Empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Fecha)
                    .HasColumnName("22_Fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._22IdSuperficieLacustre).HasColumnName("22_IdSuperficieLacustre");

                entity.Property(e => e._22Infraestructura)
                    .HasColumnName("22_Infraestructura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Log).HasColumnName("22_Log");

                entity.Property(e => e._22Modificado).HasColumnName("22_Modificado");

                entity.Property(e => e._22Publicado).HasColumnName("22_Publicado");

                entity.Property(e => e._22TipoEnsayo)
                    .HasColumnName("22_TipoEnsayo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22TipoMetodo)
                    .HasColumnName("22_TipoMetodo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Unidad)
                    .HasColumnName("22_Unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._22Validado).HasColumnName("22_Validado");

                entity.Property(e => e._22Valor)
                    .HasColumnName("22_Valor")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e._2Area)
                    .HasColumnName("2_AREA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e._2DescVariable)
                    .HasColumnName("2_DESC_VARIABLE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._2Descripcion)
                    .HasColumnName("2_DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._2IdVariable)
                    .HasColumnName("2_ID_VARIABLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e._3AmbientalControlPointId).HasColumnName("3_ambiental_control_point_id");

                entity.Property(e => e._3CreatedAt)
                    .HasColumnName("3_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._3Id).HasColumnName("3_id");

                entity.Property(e => e._3PlantOrPoolExtraction)
                    .HasColumnName("3_plant_or_pool_extraction")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._3SectorId).HasColumnName("3_sector_id");

                entity.Property(e => e._3TimeStamp)
                    .HasColumnName("3_time_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e._3UpdatedAt)
                    .HasColumnName("3_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._4ClasificationId).HasColumnName("4_clasification_id");

                entity.Property(e => e._4CreatedAt)
                    .HasColumnName("4_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._4DescriptionId).HasColumnName("4_description_id");

                entity.Property(e => e._4DestinationId).HasColumnName("4_destination_id");

                entity.Property(e => e._4ExtractionRights).HasColumnName("4_extraction_rights");

                entity.Property(e => e._4Id).HasColumnName("4_id");

                entity.Property(e => e._4IsEnabled).HasColumnName("4_is_enabled");

                entity.Property(e => e._4Label)
                    .HasColumnName("4_label")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._4Lat)
                    .HasColumnName("4_lat")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._4Lng)
                    .HasColumnName("4_lng")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._4LocationId).HasColumnName("4_location_id");

                entity.Property(e => e._4Name)
                    .HasColumnName("4_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._4PumpId).HasColumnName("4_pump_id");

                entity.Property(e => e._4SectorId).HasColumnName("4_sector_id");

                entity.Property(e => e._4TypeId).HasColumnName("4_type_id");

                entity.Property(e => e._4UpdatedAt)
                    .HasColumnName("4_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._4WorkingFrom)
                    .HasColumnName("4_working_from")
                    .HasColumnType("datetime");

                entity.Property(e => e._4WorkingUntil)
                    .HasColumnName("4_working_until")
                    .HasColumnType("datetime");

                entity.Property(e => e._5BrineDensity)
                    .HasColumnName("5_brine_density")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5CreatedAt)
                    .HasColumnName("5_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._5F1)
                    .HasColumnName("5_f1")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5F2)
                    .HasColumnName("5_f2")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5IbaMop)
                    .HasColumnName("5_iba_mop")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5IbaSop)
                    .HasColumnName("5_iba_sop")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5Id).HasColumnName("5_id");

                entity.Property(e => e._5IsEnabled).HasColumnName("5_is_enabled");

                entity.Property(e => e._5LitersPerSecond)
                    .HasColumnName("5_liters_per_second")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5SaltDensity)
                    .HasColumnName("5_salt_density")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._5UpdatedAt)
                    .HasColumnName("5_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._6BrineDps)
                    .HasColumnName("6_brine_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6ConstantId).HasColumnName("6_constant_id");

                entity.Property(e => e._6CreatedAt)
                    .HasColumnName("6_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._6DirectReinjection)
                    .HasColumnName("6_direct_reinjection")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationAreaImpregnatedDps)
                    .HasColumnName("6_evaporation_area_impregnated_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationBrineImpregnatedDps)
                    .HasColumnName("6_evaporation_brine_impregnated_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationExposedAreaDps)
                    .HasColumnName("6_evaporation_exposed_area_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationExposedBrineDps)
                    .HasColumnName("6_evaporation_exposed_brine_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6EvaporationStationKci)
                    .HasColumnName("6_evaporation_station_kci")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6Id).HasColumnName("6_id");

                entity.Property(e => e._6ImpregnatedBrineAreaDps)
                    .HasColumnName("6_impregnated_brine_area_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6IndirectReinjection)
                    .HasColumnName("6_indirect_reinjection")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6IsOficial).HasColumnName("6_is_oficial");

                entity.Property(e => e._6IsOficialDatum).HasColumnName("6_is_oficial_datum");

                entity.Property(e => e._6IsProcessing).HasColumnName("6_is_processing");

                entity.Property(e => e._6LagoonArea)
                    .HasColumnName("6_lagoon_area")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6NetExtractionLS)
                    .HasColumnName("6_net_extraction_l_s")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6NetExtractionMD)
                    .HasColumnName("6_net_extraction_m_d")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6PlantExtraction)
                    .HasColumnName("6_plant_extraction")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6PoolExtraction)
                    .HasColumnName("6_pool_extraction")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6PorcentSolidPulpDps)
                    .HasColumnName("6_porcent_solid_pulp_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6PulpFlowDps)
                    .HasColumnName("6_pulp_flow_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6RecycleBrineDps)
                    .HasColumnName("6_recycle_brine_dps")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6SectorId).HasColumnName("6_sector_id");

                entity.Property(e => e._6TimeStamp)
                    .HasColumnName("6_time_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e._6TotalExtraction)
                    .HasColumnName("6_total_extraction")
                    .HasColumnType("numeric(19, 7)");

                entity.Property(e => e._6UpdatedAt)
                    .HasColumnName("6_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._7CreatedAt)
                    .HasColumnName("7_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._7Id).HasColumnName("7_id");

                entity.Property(e => e._7Name)
                    .HasColumnName("7_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e._7UpdatedAt)
                    .HasColumnName("7_updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._8Comment)
                    .HasColumnName("8_comment")
                    .IsUnicode(false);

                entity.Property(e => e._8CreatedAt)
                    .HasColumnName("8_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._8Event)
                    .HasColumnName("8_event")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e._8Id).HasColumnName("8_id");

                entity.Property(e => e._8ItemId).HasColumnName("8_item_id");

                entity.Property(e => e._8ItemType)
                    .HasColumnName("8_item_type")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e._8Object)
                    .HasColumnName("8_object")
                    .IsUnicode(false);

                entity.Property(e => e._8Whodunnit)
                    .HasColumnName("8_whodunnit")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e._9AmbientalControlPointId).HasColumnName("9_ambiental_control_point_id");

                entity.Property(e => e._9AverageFlowDay).HasColumnName("9_average_flow_day");

                entity.Property(e => e._9CreatedAt)
                    .HasColumnName("9_created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e._9FlowDay).HasColumnName("9_flow_day");

                entity.Property(e => e._9Id).HasColumnName("9_id");

                entity.Property(e => e._9IsProcessing).HasColumnName("9_is_processing");

                entity.Property(e => e._9TimeStamp)
                    .HasColumnName("9_time_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e._9UpdatedAt)
                    .HasColumnName("9_updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SourceVt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Source_VT", "migra");

                entity.Property(e => e._0IdMensaje)
                    .HasColumnName("0_IdMensaje")
                    .IsUnicode(false);

                entity.Property(e => e._0IdSincronizacionCorfo).HasColumnName("0_IdSincronizacionCORFO");

                entity.Property(e => e._0NombreTabla)
                    .HasColumnName("0_NombreTabla")
                    .IsUnicode(false);

                entity.Property(e => e._0TipoTransaccion)
                    .HasColumnName("0_TipoTransaccion")
                    .IsUnicode(false);

                entity.Property(e => e._1Descripcion)
                    .HasColumnName("1_DESCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e._1Fecha)
                    .HasColumnName("1_FECHA")
                    .IsUnicode(false);

                entity.Property(e => e._1IdVariable)
                    .HasColumnName("1_ID_VARIABLE")
                    .IsUnicode(false);

                entity.Property(e => e._1ResultNumber).HasColumnName("1_RESULT_NUMBER");

                entity.Property(e => e._1SValor)
                    .HasColumnName("1_sValor")
                    .IsUnicode(false);

                entity.Property(e => e._1Valor).HasColumnName("1_VALOR");
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
                    .HasColumnType("decimal(19, 4)");

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

            modelBuilder.Entity<TipoDatoControl>(entity =>
            {
                entity.HasKey(e => e.IdTipoDatoControl)
                    .HasName("PK_TipoDatoControl_IdTipoDatoControl");

                entity.ToTable("TipoDatoControl", "imports");

                entity.HasIndex(e => e.TipoDatoControl1)
                    .HasName("UK_TipoDatoControl_TipoDatoControl")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDatoControl1)
                    .IsRequired()
                    .HasColumnName("TipoDatoControl")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoHeader>(entity =>
            {
                entity.HasKey(e => e.IdTipoHeader)
                    .HasName("PK_TipoHeader_IdTipoHeader");

                entity.ToTable("TipoHeader", "imports");

                entity.HasIndex(e => e.TipoHeader1)
                    .HasName("UK_TipoHeader_TipoHeader")
                    .IsUnique();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.TipoHeader1)
                    .IsRequired()
                    .HasColumnName("TipoHeader")
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

            modelBuilder.Entity<TipoMensaje>(entity =>
            {
                entity.HasKey(e => e.IdTipoMensaje)
                    .HasName("PK_TipoMensaje_IdTipoMensaje");

                entity.ToTable("TipoMensaje", "imports");

                entity.HasIndex(e => e.TipoMensaje1)
                    .HasName("UK_TipoMensaje_TipoMensaje")
                    .IsUnique();

                entity.Property(e => e.TipoMensaje1)
                    .IsRequired()
                    .HasColumnName("TipoMensaje")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoOrigen>(entity =>
            {
                entity.HasKey(e => e.IdTipoOrigen)
                    .HasName("PK_TipoOrigen_IdTipoOrigen");

                entity.ToTable("TipoOrigen", "imports");

                entity.HasIndex(e => e.TipoOrigen1)
                    .HasName("UK_TipoOrigen_TipoOrigen")
                    .IsUnique();

                entity.Property(e => e.TipoOrigen1)
                    .IsRequired()
                    .HasColumnName("TipoOrigen")
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

                entity.Property(e => e.ImpregnacionInicial).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LitioInicialPct)
                    .HasColumnName("LitioInicial_pct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolAguaM3)
                    .HasColumnName("VolAgua_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolSalM3)
                    .HasColumnName("VolSal_m3")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VolSalmueraM3)
                    .HasColumnName("VolSalmuera_m3")
                    .HasColumnType("decimal(19, 4)");

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
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UltimosPeriodosTablasDatos>().HasNoKey();

            modelBuilder.HasSequence<int>("TrackingSeq", "AuditLog");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
