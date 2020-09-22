using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;

namespace BalanceGlobal.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ConsInvCarmen, ConsInvCarmenEntity>();
            CreateMap<ConsInvCarmenEntity, ConsInvCarmen>();

            CreateMap<ConsumoEnergetico, ConsumoEnergeticoEntity>();
            CreateMap<ConsumoEnergeticoEntity, ConsumoEnergetico>();

            CreateMap<Cosechas, CosechasEntity>();
            CreateMap<CosechasEntity, Cosechas>();

            CreateMap<Extraccion, ExtraccionEntity>();
            CreateMap<ExtraccionEntity, Extraccion>();

            CreateMap<Faenas, FaenasEntity>();
            CreateMap<FaenasEntity, Faenas>();

            CreateMap<FaenasSistemas, FaenasSistemasEntity>();
            CreateMap<FaenasSistemasEntity, FaenasSistemas>();

            CreateMap<Infraestructuras, InfraestructurasEntity>();
            CreateMap<InfraestructurasEntity, Infraestructuras>();

            CreateMap<OperaPozas, OperaPozasEntity>();
            CreateMap<OperaPozasEntity, OperaPozas>();

            CreateMap<InfraestructurasEntity, Infraestructuras>();
            CreateMap<InfraestructurasEntity, Infraestructuras>();

            CreateMap<Periodos, PeriodosEntity>();
            CreateMap<PeriodosEntity, Periodos>();

            CreateMap<PeriodosOperacionales, PeriodosOperacionalesEntity>();
            CreateMap<PeriodosOperacionalesEntity, PeriodosOperacionales>();

            CreateMap<Porteos, PorteosEntity>();
            CreateMap<PorteosEntity, Porteos>();

            CreateMap<Reservorios, ReservoriosEntity>();
            CreateMap<ReservoriosEntity, Reservorios>();

            CreateMap<Sistemas, SistemasEntity>();
            CreateMap<SistemasEntity, Sistemas>();

            CreateMap<SistemasSubSistemas, SistemasSubSistemasEntity>();
            CreateMap<SistemasSubSistemasEntity, SistemasSubSistemas>();

            CreateMap<Subsistemas, SubsistemasEntity>();
            CreateMap<SubsistemasEntity, Subsistemas>();

            CreateMap<TransSistemasCosechas, TransSistemasCosechasEntity>();
            CreateMap<TransSistemasCosechasEntity, TransSistemasCosechas>();

        }
    }
}
