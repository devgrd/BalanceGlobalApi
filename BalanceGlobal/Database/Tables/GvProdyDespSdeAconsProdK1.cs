﻿using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class GvProdyDespSdeAconsProdK1
    {
        public int IdProdyDespSdeAconsProdK1 { get; set; }
        public string Periodo { get; set; }
        public string ModalidadPlanta { get; set; }
        public string Corriente { get; set; }
        public string Sistema { get; set; }
        public string Subsistema { get; set; }
        public string InfraestructuraPlanta { get; set; }
        public DateTime Fecha { get; set; }
        public string ProdyDespSdeAvariablesNum { get; set; }
        public decimal? Valor { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
