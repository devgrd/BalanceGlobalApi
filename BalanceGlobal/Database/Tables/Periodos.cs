using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Periodos
    {
        public Periodos()
        {
            Bgajustes = new HashSet<Bgajustes>();
            CargaPlataformas = new HashSet<CargaPlataformas>();
            CkmopIiquimaPorteo = new HashSet<CkmopIiquimaPorteo>();
            CkmopIivolaPorteo = new HashSet<CkmopIivolaPorteo>();
            ConsDespacho = new HashSet<ConsDespacho>();
            ConsInvCarmen = new HashSet<ConsInvCarmen>();
            ConsLi2Co3 = new HashSet<ConsLi2Co3>();
            ConsLitioLiCo3mensual = new HashSet<ConsLitioLiCo3mensual>();
            ConsPlantaLiOh = new HashSet<ConsPlantaLiOh>();
            ConsReactivos = new HashSet<ConsReactivos>();
            ConsRilesyRises = new HashSet<ConsRilesyRises>();
            ConsumoAgua = new HashSet<ConsumoAgua>();
            ConsumoEnergetico = new HashSet<ConsumoEnergetico>();
            Cosechas = new HashSet<Cosechas>();
            DescargaPlataformas = new HashSet<DescargaPlataformas>();
            EvaporacionInfiltracion = new HashSet<EvaporacionInfiltracion>();
            Extraccion = new HashSet<Extraccion>();
            ExtraccionAgua = new HashSet<ExtraccionAgua>();
            Flujos = new HashSet<Flujos>();
            ImpregnacionCosechas = new HashSet<ImpregnacionCosechas>();
            InventariosAtacama = new HashSet<InventariosAtacama>();
            OperaPozas = new HashSet<OperaPozas>();
            PciacopiosCli = new HashSet<PciacopiosCli>();
            Pcimodos = new HashSet<Pcimodos>();
            PeriodosOperacionales = new HashSet<PeriodosOperacionales>();
            Porteos = new HashSet<Porteos>();
            ProdyDespSdeAconsProdK = new HashSet<ProdyDespSdeAconsProdK>();
            ProdyDespSdeAconsProdK1 = new HashSet<ProdyDespSdeAconsProdK1>();
            QuimicaPlataformas = new HashSet<QuimicaPlataformas>();
            Reinyeccion = new HashSet<Reinyeccion>();
            RiegoPlataformas = new HashSet<RiegoPlataformas>();
            TasaEvaporacion = new HashSet<TasaEvaporacion>();
            TraspasosPlataformas = new HashSet<TraspasosPlataformas>();
        }

        public int IdPeriodos { get; set; }
        public string Periodo { get; set; }
        public int? IdTipoPeriodo { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<Bgajustes> Bgajustes { get; set; }
        public virtual ICollection<CargaPlataformas> CargaPlataformas { get; set; }
        public virtual ICollection<CkmopIiquimaPorteo> CkmopIiquimaPorteo { get; set; }
        public virtual ICollection<CkmopIivolaPorteo> CkmopIivolaPorteo { get; set; }
        public virtual ICollection<ConsDespacho> ConsDespacho { get; set; }
        public virtual ICollection<ConsInvCarmen> ConsInvCarmen { get; set; }
        public virtual ICollection<ConsLi2Co3> ConsLi2Co3 { get; set; }
        public virtual ICollection<ConsLitioLiCo3mensual> ConsLitioLiCo3mensual { get; set; }
        public virtual ICollection<ConsPlantaLiOh> ConsPlantaLiOh { get; set; }
        public virtual ICollection<ConsReactivos> ConsReactivos { get; set; }
        public virtual ICollection<ConsRilesyRises> ConsRilesyRises { get; set; }
        public virtual ICollection<ConsumoAgua> ConsumoAgua { get; set; }
        public virtual ICollection<ConsumoEnergetico> ConsumoEnergetico { get; set; }
        public virtual ICollection<Cosechas> Cosechas { get; set; }
        public virtual ICollection<DescargaPlataformas> DescargaPlataformas { get; set; }
        public virtual ICollection<EvaporacionInfiltracion> EvaporacionInfiltracion { get; set; }
        public virtual ICollection<Extraccion> Extraccion { get; set; }
        public virtual ICollection<ExtraccionAgua> ExtraccionAgua { get; set; }
        public virtual ICollection<Flujos> Flujos { get; set; }
        public virtual ICollection<ImpregnacionCosechas> ImpregnacionCosechas { get; set; }
        public virtual ICollection<InventariosAtacama> InventariosAtacama { get; set; }
        public virtual ICollection<OperaPozas> OperaPozas { get; set; }
        public virtual ICollection<PciacopiosCli> PciacopiosCli { get; set; }
        public virtual ICollection<Pcimodos> Pcimodos { get; set; }
        public virtual ICollection<PeriodosOperacionales> PeriodosOperacionales { get; set; }
        public virtual ICollection<Porteos> Porteos { get; set; }
        public virtual ICollection<ProdyDespSdeAconsProdK> ProdyDespSdeAconsProdK { get; set; }
        public virtual ICollection<ProdyDespSdeAconsProdK1> ProdyDespSdeAconsProdK1 { get; set; }
        public virtual ICollection<QuimicaPlataformas> QuimicaPlataformas { get; set; }
        public virtual ICollection<Reinyeccion> Reinyeccion { get; set; }
        public virtual ICollection<RiegoPlataformas> RiegoPlataformas { get; set; }
        public virtual ICollection<TasaEvaporacion> TasaEvaporacion { get; set; }
        public virtual ICollection<TraspasosPlataformas> TraspasosPlataformas { get; set; }
    }
}
