using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Sistemas
    {
        public Sistemas()
        {
            CategoriaConsumoAgua = new HashSet<CategoriaConsumoAgua>();
            ConsRilesyRises = new HashSet<ConsRilesyRises>();
            EvaporacionInfiltracion = new HashSet<EvaporacionInfiltracion>();
            FaenasSistemas = new HashSet<FaenasSistemas>();
            OperaPozas = new HashSet<OperaPozas>();
            PeriodosOperacionales = new HashSet<PeriodosOperacionales>();
            SistemasSubSistemas = new HashSet<SistemasSubSistemas>();
            TasaEvaporacion = new HashSet<TasaEvaporacion>();
        }

        public int IdSistemas { get; set; }
        public string Sistema { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<CategoriaConsumoAgua> CategoriaConsumoAgua { get; set; }
        public virtual ICollection<ConsRilesyRises> ConsRilesyRises { get; set; }
        public virtual ICollection<EvaporacionInfiltracion> EvaporacionInfiltracion { get; set; }
        public virtual ICollection<FaenasSistemas> FaenasSistemas { get; set; }
        public virtual ICollection<OperaPozas> OperaPozas { get; set; }
        public virtual ICollection<PeriodosOperacionales> PeriodosOperacionales { get; set; }
        public virtual ICollection<SistemasSubSistemas> SistemasSubSistemas { get; set; }
        public virtual ICollection<TasaEvaporacion> TasaEvaporacion { get; set; }
    }
}
