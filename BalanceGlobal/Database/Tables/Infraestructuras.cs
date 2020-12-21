using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Infraestructuras
    {
        public Infraestructuras()
        {
            Bgajustes = new HashSet<Bgajustes>();
            CargaPlataformasIdInfraestructuraOrigenNavigation = new HashSet<CargaPlataformas>();
            CargaPlataformasIdPlataformaNavigation = new HashSet<CargaPlataformas>();
            CkmopIiquimaPorteo = new HashSet<CkmopIiquimaPorteo>();
            CkmopIivolaPorteo = new HashSet<CkmopIivolaPorteo>();
            ConsInvCarmen = new HashSet<ConsInvCarmen>();
            Cosechas = new HashSet<Cosechas>();
            DescargaInfraestructurasDestino = new HashSet<DescargaInfraestructurasDestino>();
            DescargaPlataformas = new HashSet<DescargaPlataformas>();
            EvaporacionInfiltracion = new HashSet<EvaporacionInfiltracion>();
            ExtraccionAguaIdInfraestructuraDestinoNavigation = new HashSet<ExtraccionAgua>();
            ExtraccionAguaIdInfraestructuraOrigenNavigation = new HashSet<ExtraccionAgua>();
            ExtraccionIdInfraestructuraDestinoNavigation = new HashSet<Extraccion>();
            ExtraccionIdInfraestructuraOrigenNavigation = new HashSet<Extraccion>();
            ImpregnacionCosechas = new HashSet<ImpregnacionCosechas>();
            InventariosAtacama = new HashSet<InventariosAtacama>();
            InverseIdInfraestructuraPadreNavigation = new HashSet<Infraestructuras>();
            OperaPozasIdInfraestructuraDestinoNavigation = new HashSet<OperaPozas>();
            OperaPozasIdInfraestructuraOrigenNavigation = new HashSet<OperaPozas>();
            OrigenesTraspasoPlataformas = new HashSet<OrigenesTraspasoPlataformas>();
            Pcimodos = new HashSet<Pcimodos>();
            ProdyDespSdeAconsProdK = new HashSet<ProdyDespSdeAconsProdK>();
            ProdyDespSdeAconsProdK1 = new HashSet<ProdyDespSdeAconsProdK1>();
            QuimicaPlataformas = new HashSet<QuimicaPlataformas>();
            TraspasosPlataformasIdInfraestructuraDestinoNavigation = new HashSet<TraspasosPlataformas>();
            TraspasosPlataformasIdPlataformaNavigation = new HashSet<TraspasosPlataformas>();
        }

        public int IdInfraestructuras { get; set; }
        public string Infraestructura { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoInfraestructuras { get; set; }
        public int? IdInfraestructuraPadre { get; set; }
        public bool? Activa { get; set; }
        public bool? ReportarAgrupada { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Infraestructuras IdInfraestructuraPadreNavigation { get; set; }
        public virtual TipoInfraestructuras IdTipoInfraestructurasNavigation { get; set; }
        public virtual InfraestructurasReinyeccion InfraestructurasReinyeccion { get; set; }
        public virtual ICollection<Bgajustes> Bgajustes { get; set; }
        public virtual ICollection<CargaPlataformas> CargaPlataformasIdInfraestructuraOrigenNavigation { get; set; }
        public virtual ICollection<CargaPlataformas> CargaPlataformasIdPlataformaNavigation { get; set; }
        public virtual ICollection<CkmopIiquimaPorteo> CkmopIiquimaPorteo { get; set; }
        public virtual ICollection<CkmopIivolaPorteo> CkmopIivolaPorteo { get; set; }
        public virtual ICollection<ConsInvCarmen> ConsInvCarmen { get; set; }
        public virtual ICollection<Cosechas> Cosechas { get; set; }
        public virtual ICollection<DescargaInfraestructurasDestino> DescargaInfraestructurasDestino { get; set; }
        public virtual ICollection<DescargaPlataformas> DescargaPlataformas { get; set; }
        public virtual ICollection<EvaporacionInfiltracion> EvaporacionInfiltracion { get; set; }
        public virtual ICollection<ExtraccionAgua> ExtraccionAguaIdInfraestructuraDestinoNavigation { get; set; }
        public virtual ICollection<ExtraccionAgua> ExtraccionAguaIdInfraestructuraOrigenNavigation { get; set; }
        public virtual ICollection<Extraccion> ExtraccionIdInfraestructuraDestinoNavigation { get; set; }
        public virtual ICollection<Extraccion> ExtraccionIdInfraestructuraOrigenNavigation { get; set; }
        public virtual ICollection<ImpregnacionCosechas> ImpregnacionCosechas { get; set; }
        public virtual ICollection<InventariosAtacama> InventariosAtacama { get; set; }
        public virtual ICollection<Infraestructuras> InverseIdInfraestructuraPadreNavigation { get; set; }
        public virtual ICollection<OperaPozas> OperaPozasIdInfraestructuraDestinoNavigation { get; set; }
        public virtual ICollection<OperaPozas> OperaPozasIdInfraestructuraOrigenNavigation { get; set; }
        public virtual ICollection<OrigenesTraspasoPlataformas> OrigenesTraspasoPlataformas { get; set; }
        public virtual ICollection<Pcimodos> Pcimodos { get; set; }
        public virtual ICollection<ProdyDespSdeAconsProdK> ProdyDespSdeAconsProdK { get; set; }
        public virtual ICollection<ProdyDespSdeAconsProdK1> ProdyDespSdeAconsProdK1 { get; set; }
        public virtual ICollection<QuimicaPlataformas> QuimicaPlataformas { get; set; }
        public virtual ICollection<TraspasosPlataformas> TraspasosPlataformasIdInfraestructuraDestinoNavigation { get; set; }
        public virtual ICollection<TraspasosPlataformas> TraspasosPlataformasIdPlataformaNavigation { get; set; }
    }
}
