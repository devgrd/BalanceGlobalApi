﻿using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Extraccion
    {
        public int IdExtraccion { get; set; }
        public int IdPeriodos { get; set; }
        public DateTime Fecha { get; set; }
        public int IdInfraestructuraOrigen { get; set; }
        public int IdInfraestructuraDestino { get; set; }
        public decimal? VolumenInicialM3 { get; set; }
        public decimal? VolumenFinalM3 { get; set; }
        public decimal? HorasOperacionH { get; set; }
        public decimal? VolTraspasoM3 { get; set; }
        public decimal? KPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? DensidadTonm3 { get; set; }
        public decimal? H3bo3Pct { get; set; }
    }
}
