using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataReinyeccionDatos2Model : ModelBase
    {
        public DateTime? FechaHora { get; set; }
        public DateTime? Fecha { get; set; }
        public double? KSalmPct { get; set; }
        public double? NaSalmPct { get; set; }
        public double? MgSalmPct { get; set; }
        public double? CaSalmPct { get; set; }
        public double? So4SalmPct { get; set; }
        public double? LiSalmPct { get; set; }
        public double? ClSalmPct { get; set; }
        public double? DensSalmGml { get; set; }
        public double? H3bo3Pct { get; set; }
        public double? KSolPct { get; set; }
        public double? NaSolPct { get; set; }
        public double? MgSolPct { get; set; }
        public double? CaSolPct { get; set; }
        public double? So4SolPct { get; set; }
        public double? LiSolPct { get; set; }
        public double? ClSolPct { get; set; }
        public double? H2o170gcSolPct { get; set; }
        public double? H3bo3SolPct { get; set; }
        public double? TkLims { get; set; }
        public double? TkSipro { get; set; }
        public long? FlujoRepulpeo { get; set; }
        public string Sistema { get; set; }
    }
}
