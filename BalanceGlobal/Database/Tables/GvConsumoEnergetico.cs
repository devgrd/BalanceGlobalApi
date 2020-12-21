﻿using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvConsumoEnergetico
    {
        public int IdConsumoEnergetico { get; set; }
        public string Periodo { get; set; }
        public string Up { get; set; }
        public string UpD { get; set; }
        public string Concepto { get; set; }
        public string ConceptoD { get; set; }
        public string Um { get; set; }
        public decimal? Valor { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
