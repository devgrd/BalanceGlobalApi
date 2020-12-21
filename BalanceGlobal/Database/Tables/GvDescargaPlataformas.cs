﻿using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvDescargaPlataformas
    {
        public int IdDescargaPlataformas { get; set; }
        public DateTime Fecha { get; set; }
        public string Periodo { get; set; }
        public string Plataforma { get; set; }
        public decimal? VolSalidaM3 { get; set; }
        public decimal? ImpregnacionPct { get; set; }
        public decimal? VolenPlataformaM3 { get; set; }
        public string TipoSal { get; set; }
        public decimal? LiPct { get; set; }
        public decimal? KPct { get; set; }
        public decimal? MgPct { get; set; }
        public decimal? So4Pct { get; set; }
        public decimal? CaPct { get; set; }
        public decimal? ClPct { get; set; }
        public decimal? NaPct { get; set; }
        public decimal? H3b3oPct { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
