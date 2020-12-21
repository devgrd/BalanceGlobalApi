using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataConsInvSalardelCarmen
    {
        public DateTime? Fecha { get; set; }
        public double? Hora { get; set; }
        public string Corriente { get; set; }
        public string Salar { get; set; }
        public string Sistema { get; set; }
        public string TipoDeInventario { get; set; }
        public string TipoDePoza { get; set; }
        public double? Volumen { get; set; }
        public double? Dens { get; set; }
        public double? Ton { get; set; }
        public double? TonLce { get; set; }
        public double? K { get; set; }
        public double? Na { get; set; }
        public double? Mg { get; set; }
        public double? Ca { get; set; }
        public double? So4 { get; set; }
        public double? Li { get; set; }
        public double? Cl { get; set; }
        public double? H3bo3 { get; set; }
        public double? Co3 { get; set; }
        public double? Oh { get; set; }
        public double? H2o { get; set; }
        public double? TonLceBalanceDePozas { get; set; }
    }
}
