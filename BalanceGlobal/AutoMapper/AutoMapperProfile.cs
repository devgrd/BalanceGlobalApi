using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;

namespace BalanceGlobal.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Bombas, BombasModel>();
            CreateMap<BombasModel, Bombas>();
            
            CreateMap<Flujos, FlujosModel>();
            CreateMap<FlujosModel, Flujos>();            
            
            CreateMap<Importaciones, ImportacionesModel>();
            CreateMap<ImportacionesModel, Importaciones>();            
            
            CreateMap<ImportacionesUserParValues, ImportacionesUserParValuesModel>();
            CreateMap<ImportacionesUserParValuesModel, ImportacionesUserParValues>();

            CreateMap<Importadores, ImportadoresModel>();
            CreateMap<ImportadoresModel, Importadores>();            
            
            CreateMap<ImportDestino, ImportDestinoModel>();
            CreateMap<ImportDestinoModel, ImportDestino>();            
            
            CreateMap<MensajesImportacion, MensajesImportacionModel>();
            CreateMap<MensajesImportacionModel, MensajesImportacion>();            
            
            CreateMap<OrigenesDatos, OrigenesDatosModel>();
            CreateMap<OrigenesDatosModel, OrigenesDatos>();            
            
            CreateMap<Reinyeccion, ReinyeccionModel>();
            CreateMap<ReinyeccionModel, Reinyeccion>();            
            
            CreateMap<SchemaColumns, SchemaColumnsModel>();
            CreateMap<SchemaColumnsModel, SchemaColumns>();            
            
            CreateMap<SchemaColumnsWarning, SchemaColumnsWarningModel>();
            CreateMap<SchemaColumnsWarningModel, SchemaColumnsWarning>();            
            
            CreateMap<SchemaDef, SchemaDefModel>();
            CreateMap<SchemaDefModel, SchemaDef>(); 
            
            CreateMap<TipoInfraestructuras, TipoInfraestructurasModel>();
            CreateMap<TipoInfraestructurasModel, TipoInfraestructuras>();

            CreateMap<ConsInvCarmen, ConsInvCarmenModel>();
            CreateMap<ConsInvCarmenModel, ConsInvCarmen>();

            CreateMap<ConsumoEnergetico, ConsumoEnergeticoModel>();
            CreateMap<ConsumoEnergeticoModel, ConsumoEnergetico>();

            CreateMap<Cosechas, CosechasModel>();
            CreateMap<CosechasModel, Cosechas>();

            CreateMap<Extraccion, ExtraccionModel>();
            CreateMap<ExtraccionModel, Extraccion>();

            CreateMap<Faenas, FaenasModel>();
            CreateMap<FaenasModel, Faenas>();

            CreateMap<FaenasSistemas, FaenasSistemasModel>();
            CreateMap<FaenasSistemasModel, FaenasSistemas>();

            CreateMap<Infraestructuras, InfraestructurasModel>();
            CreateMap<InfraestructurasModel, Infraestructuras>();

            CreateMap<OperaPozas, OperaPozasModel>();
            CreateMap<OperaPozasModel, OperaPozas>();

            CreateMap<Periodos, PeriodosModel>();
            CreateMap<PeriodosModel, Periodos>();

            CreateMap<PeriodosOperacionales, PeriodosOperacionalesModel>();
            CreateMap<PeriodosOperacionalesModel, PeriodosOperacionales>();

            CreateMap<Porteos, PorteosModel>();
            CreateMap<PorteosModel, Porteos>();

            CreateMap<Reservorios, ReservoriosModel>();
            CreateMap<ReservoriosModel, Reservorios>();

            CreateMap<Sistemas, SistemasModel>();
            CreateMap<SistemasModel, Sistemas>();

            CreateMap<SistemasSubSistemas, SistemasSubSistemasModel>();
            CreateMap<SistemasSubSistemasModel, SistemasSubSistemas>();

            CreateMap<SubSistemas, SubSistemasModel>();
            CreateMap<SubSistemasModel, SubSistemas>();

            CreateMap<TransSistemasCosechas, TransSistemasCosechasModel>();
            CreateMap<TransSistemasCosechasModel, TransSistemasCosechas>();

        }
    }
}
