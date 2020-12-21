using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDataTraspasoPlataformas
    {
        public int IdTraspasosPlataformas { get; set; }
        public string Plataforma { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? VolAguaM3 { get; set; }
        public decimal? VolSalmueraM3 { get; set; }
        public decimal? VolSalM3 { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal? ImpregnacionInicial { get; set; }
        public decimal? LitioInicialPct { get; set; }
    }
}
