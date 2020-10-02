using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class SistemasSubSistemas
    {
        public SistemasSubSistemas()
        {
            CategoriaConsumoAgua = new HashSet<CategoriaConsumoAgua>();
            ConsInvCarmen = new HashSet<ConsInvCarmen>();
            ConsLitioLiCo3mensual = new HashSet<ConsLitioLiCo3mensual>();
            ConsReactivos = new HashSet<ConsReactivos>();
            Cosechas = new HashSet<Cosechas>();
            Flujos = new HashSet<Flujos>();
            ImpregnacionCosechas = new HashSet<ImpregnacionCosechas>();
            InfraestruturasReinyeccion = new HashSet<InfraestruturasReinyeccion>();
            InventariosAtacama = new HashSet<InventariosAtacama>();
            Pcimodos = new HashSet<Pcimodos>();
            ProdyDespSdeAconsProdK = new HashSet<ProdyDespSdeAconsProdK>();
            ProdyDespSdeAconsProdK1 = new HashSet<ProdyDespSdeAconsProdK1>();
            Reinyeccion = new HashSet<Reinyeccion>();
            TransSistemasCosechas = new HashSet<TransSistemasCosechas>();
        }

        public int IdSistemasSubsistemas { get; set; }
        public int IdSistemas { get; set; }
        public int? IdSubSistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Sistemas IdSistemasNavigation { get; set; }
        public virtual SubSistemas IdSubSistemasNavigation { get; set; }
        public virtual Permeabilidad Permeabilidad { get; set; }
        public virtual ICollection<CategoriaConsumoAgua> CategoriaConsumoAgua { get; set; }
        public virtual ICollection<ConsInvCarmen> ConsInvCarmen { get; set; }
        public virtual ICollection<ConsLitioLiCo3mensual> ConsLitioLiCo3mensual { get; set; }
        public virtual ICollection<ConsReactivos> ConsReactivos { get; set; }
        public virtual ICollection<Cosechas> Cosechas { get; set; }
        public virtual ICollection<Flujos> Flujos { get; set; }
        public virtual ICollection<ImpregnacionCosechas> ImpregnacionCosechas { get; set; }
        public virtual ICollection<InfraestruturasReinyeccion> InfraestruturasReinyeccion { get; set; }
        public virtual ICollection<InventariosAtacama> InventariosAtacama { get; set; }
        public virtual ICollection<Pcimodos> Pcimodos { get; set; }
        public virtual ICollection<ProdyDespSdeAconsProdK> ProdyDespSdeAconsProdK { get; set; }
        public virtual ICollection<ProdyDespSdeAconsProdK1> ProdyDespSdeAconsProdK1 { get; set; }
        public virtual ICollection<Reinyeccion> Reinyeccion { get; set; }
        public virtual ICollection<TransSistemasCosechas> TransSistemasCosechas { get; set; }
    }
}
