using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;

namespace BalanceGlobal.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Aliases, AliasesModel>(); CreateMap<AliasesModel, Aliases>();
            CreateMap<TipoDatoColOrigen, TipoDatoColOrigenModel>(); CreateMap<TipoDatoColOrigenModel, TipoDatoColOrigen>();

            CreateMap<Bombas, BombasModel>(); CreateMap<BombasModel, Bombas>();
            CreateMap<CargaPlataformas, CargaPlataformasModel>(); CreateMap<CargaPlataformasModel, CargaPlataformas>();
            CreateMap<CategoriaConsumoAgua, CategoriaConsumoAguaModel>(); CreateMap<CategoriaConsumoAguaModel, CategoriaConsumoAgua>();
            CreateMap<CkmopIiquimaPorteo, CkmopIiquimaPorteoModel>(); CreateMap<CkmopIiquimaPorteoModel, CkmopIiquimaPorteo>();
            CreateMap<CkmopIivolaPorteo, CkmopIivolaPorteoModel>(); CreateMap<CkmopIivolaPorteoModel, CkmopIivolaPorteo>();
            CreateMap<ConsDespacho, ConsDespachoModel>(); CreateMap<ConsDespachoModel, ConsDespacho>();
            CreateMap<ConsInvCarmen, ConsInvCarmenModel>(); CreateMap<ConsInvCarmenModel, ConsInvCarmen>();
            CreateMap<ConsLi2Co3, ConsLi2Co3Model>(); CreateMap<ConsLi2Co3Model, ConsLi2Co3>();
            CreateMap<ConsLitioLiCo3mensual, ConsLitioLiCo3mensualModel>(); CreateMap<ConsLitioLiCo3mensualModel, ConsLitioLiCo3mensual>();
            CreateMap<ConsPlantaLiOh, ConsPlantaLiOhModel>(); CreateMap<ConsPlantaLiOhModel, ConsPlantaLiOh>();
            CreateMap<ConsReactivos, ConsReactivosModel>(); CreateMap<ConsReactivosModel, ConsReactivos>();
            CreateMap<ConsRilesyRises, ConsRilesyRisesModel>(); CreateMap<ConsRilesyRisesModel, ConsRilesyRises>();
            CreateMap<ConsumoAgua, ConsumoAguaModel>(); CreateMap<ConsumoAguaModel, ConsumoAgua>();
            CreateMap<ConsumoEnergetico, ConsumoEnergeticoModel>(); CreateMap<ConsumoEnergeticoModel, ConsumoEnergetico>();
            CreateMap<CorrienteGlobal, CorrienteGlobalModel>(); CreateMap<CorrienteGlobalModel, CorrienteGlobal>();
            CreateMap<CorrienteLi2Co3, CorrienteLi2Co3Model>(); CreateMap<CorrienteLi2Co3Model, CorrienteLi2Co3>();
            CreateMap<CorrientePci, CorrientePciModel>(); CreateMap<CorrientePciModel, CorrientePci>();
            CreateMap<Corrientes, CorrientesModel>(); CreateMap<CorrientesModel, Corrientes>();
            CreateMap<CorrientesRilesyRises, CorrientesRilesyRisesModel>(); CreateMap<CorrientesRilesyRisesModel, CorrientesRilesyRises>();
            CreateMap<Cosechas, CosechasModel>(); CreateMap<CosechasModel, Cosechas>();
            CreateMap<DescargaInfraestructurasDestino, DescargaInfraestructurasDestinoModel>(); CreateMap<DescargaInfraestructurasDestinoModel, DescargaInfraestructurasDestino>();
            CreateMap<DescargaPlataformas, DescargaPlataformasModel>(); CreateMap<DescargaPlataformasModel, DescargaPlataformas>();
            CreateMap<EvaporacionInfiltracion, EvaporacionInfiltracionModel>(); CreateMap<EvaporacionInfiltracionModel, EvaporacionInfiltracion>();
            CreateMap<Extraccion, ExtraccionModel>(); CreateMap<ExtraccionModel, Extraccion>();
            CreateMap<ExtraccionAgua, ExtraccionAguaModel>(); CreateMap<ExtraccionAguaModel, ExtraccionAgua>();
            CreateMap<FactoresImpregnacion, FactoresImpregnacionModel>(); CreateMap<FactoresImpregnacionModel, FactoresImpregnacion>();
            CreateMap<Faenas, FaenasModel>(); CreateMap<FaenasModel, Faenas>();
            CreateMap<FaenasSistemas, FaenasSistemasModel>(); CreateMap<FaenasSistemasModel, FaenasSistemas>();
            CreateMap<Flujos, FlujosModel>(); CreateMap<FlujosModel, Flujos>();
            CreateMap<ImpregnacionCosechas, ImpregnacionCosechasModel>(); CreateMap<ImpregnacionCosechasModel, ImpregnacionCosechas>();
            CreateMap<ImpregnacionSistemaRef, ImpregnacionSistemaRefModel>(); CreateMap<ImpregnacionSistemaRefModel, ImpregnacionSistemaRef>();
            CreateMap<Infraestructuras, InfraestructurasModel>(); CreateMap<InfraestructurasModel, Infraestructuras>();
            CreateMap<InfraestructurasReinyeccion, InfraestructurasReinyeccionModel>(); CreateMap<InfraestructurasReinyeccionModel, InfraestructurasReinyeccion>();
            CreateMap<InventariosAtacama, InventariosAtacamaModel>(); CreateMap<InventariosAtacamaModel, InventariosAtacama>();
            CreateMap<ModalidadPci, ModalidadPciModel>(); CreateMap<ModalidadPciModel, ModalidadPci>();
            CreateMap<ModalidadPlantas, ModalidadPlantasModel>(); CreateMap<ModalidadPlantasModel, ModalidadPlantas>();
            CreateMap<OperaPozas, OperaPozasModel>(); CreateMap<OperaPozasModel, OperaPozas>();
            CreateMap<OrigenesTraspasoPlataformas, OrigenesTraspasoPlataformasModel>(); CreateMap<OrigenesTraspasoPlataformasModel, OrigenesTraspasoPlataformas>();
            CreateMap<PciacopiosCli, PciacopiosCliModel>(); CreateMap<PciacopiosCliModel, PciacopiosCli>();
            CreateMap<PciacopiosOrigen, PciacopiosOrigenModel>(); CreateMap<PciacopiosOrigenModel, PciacopiosOrigen>();
            CreateMap<Pcimodos, PcimodosModel>(); CreateMap<PcimodosModel, Pcimodos>();
            CreateMap<Periodos, PeriodosModel>(); CreateMap<PeriodosModel, Periodos>();
            CreateMap<PeriodosOperacionales, PeriodosOperacionalesModel>(); CreateMap<PeriodosOperacionalesModel, PeriodosOperacionales>();
            CreateMap<Permeabilidad, PermeabilidadModel>(); CreateMap<PermeabilidadModel, Permeabilidad>();
            CreateMap<Porteos, PorteosModel>(); CreateMap<PorteosModel, Porteos>();
            CreateMap<ProdyDespSdeAconsProdK, ProdyDespSdeAconsProdKModel>(); CreateMap<ProdyDespSdeAconsProdKModel, ProdyDespSdeAconsProdK>();
            CreateMap<ProdyDespSdeAconsProdK1, ProdyDespSdeAconsProdK1Model>(); CreateMap<ProdyDespSdeAconsProdK1Model, ProdyDespSdeAconsProdK1>();
            CreateMap<ProdyDespSdeAvariablesNum, ProdyDespSdeAvariablesNumModel>(); CreateMap<ProdyDespSdeAvariablesNumModel, ProdyDespSdeAvariablesNum>();
            CreateMap<QuimicaPlataformas, QuimicaPlataformasModel>(); CreateMap<QuimicaPlataformasModel, QuimicaPlataformas>();
            CreateMap<Reactivos, ReactivosModel>(); CreateMap<ReactivosModel, Reactivos>();
            CreateMap<Reinyeccion, ReinyeccionModel>(); CreateMap<ReinyeccionModel, Reinyeccion>();
            CreateMap<Reservorios, ReservoriosModel>(); CreateMap<ReservoriosModel, Reservorios>();
            CreateMap<RiegoPlataformas, RiegoPlataformasModel>(); CreateMap<RiegoPlataformasModel, RiegoPlataformas>();
            CreateMap<Sistemas, SistemasModel>(); CreateMap<SistemasModel, Sistemas>();
            CreateMap<SistemasSubSistemas, SistemasSubSistemasModel>(); CreateMap<SistemasSubSistemasModel, SistemasSubSistemas>();
            CreateMap<SubSistemas, SubSistemasModel>(); CreateMap<SubSistemasModel, SubSistemas>();
            CreateMap<TasaEvaporacion, TasaEvaporacionModel>(); CreateMap<TasaEvaporacionModel, TasaEvaporacion>();
            CreateMap<TipoInfraestructuras, TipoInfraestructurasModel>(); CreateMap<TipoInfraestructurasModel, TipoInfraestructuras>();
            CreateMap<TipoPci, TipoPciModel>(); CreateMap<TipoPciModel, TipoPci>();
            CreateMap<TipoSal, TipoSalModel>(); CreateMap<TipoSalModel, TipoSal>();
            CreateMap<TiposInventario, TiposInventarioModel>(); CreateMap<TiposInventarioModel, TiposInventario>();
            CreateMap<TransSistemasCosechas, TransSistemasCosechasModel>(); CreateMap<TransSistemasCosechasModel, TransSistemasCosechas>();
            CreateMap<TraspasosPlataformas, TraspasosPlataformasModel>(); CreateMap<TraspasosPlataformasModel, TraspasosPlataformas>();
            CreateMap<DatosEnLista, DatosEnListaModel>(); CreateMap<DatosEnListaModel, DatosEnLista>();
            CreateMap<Importaciones, ImportacionesModel>(); CreateMap<ImportacionesModel, Importaciones>();
            CreateMap<ImportacionesUserParValues, ImportacionesUserParValuesModel>(); CreateMap<ImportacionesUserParValuesModel, ImportacionesUserParValues>();
            CreateMap<Importadores, ImportadoresModel>(); CreateMap<ImportadoresModel, Importadores>();
            CreateMap<ImportadoresUserPar, ImportadoresUserParModel>(); CreateMap<ImportadoresUserParModel, ImportadoresUserPar>();
            CreateMap<ImportDestino, ImportDestinoModel>(); CreateMap<ImportDestinoModel, ImportDestino>();
            CreateMap<MensajesImportacion, MensajesImportacionModel>(); CreateMap<MensajesImportacionModel, MensajesImportacion>();
            CreateMap<OrigenesDatos, OrigenesDatosModel>(); CreateMap<OrigenesDatosModel, OrigenesDatos>();
            CreateMap<SchemaColumns, SchemaColumnsModel>(); CreateMap<SchemaColumnsModel, SchemaColumns>();
            CreateMap<SchemaColumnsWarning, SchemaColumnsWarningModel>(); CreateMap<SchemaColumnsWarningModel, SchemaColumnsWarning>();
            CreateMap<SchemaDef, SchemaDefModel>(); CreateMap<SchemaDefModel, SchemaDef>();

            CreateMap<DetallePerfil, DetallePerfilModel>(); CreateMap<DetallePerfilModel, DetallePerfil>();
            CreateMap<Eventos, EventosModel>(); CreateMap<EventosModel, Eventos>();
            CreateMap<DetallePerfil, DetallePerfilModel>(); CreateMap<DetallePerfilModel, DetallePerfil>();
            CreateMap<Mensajes, MensajesModel>(); CreateMap<MensajesModel, Mensajes>();
            CreateMap<PerfilesUsuario, PerfilesUsuarioModel>(); CreateMap<PerfilesUsuarioModel, PerfilesUsuario>();
            CreateMap<SuscripcionEventos, SuscripcionEventosModel>(); CreateMap<SuscripcionEventosModel, SuscripcionEventos>();
            CreateMap<Usuarios, UsuariosModel>(); CreateMap<UsuariosModel, Usuarios>();
            CreateMap<UsuariosPerfilesUsuario, UsuariosPerfilesUsuarioModel>(); CreateMap<UsuariosPerfilesUsuarioModel, UsuariosPerfilesUsuario>();
            CreateMap<WorkflowItem, WorkflowItemModel>(); CreateMap<WorkflowItemModel, WorkflowItem>();

        }
    }
}
