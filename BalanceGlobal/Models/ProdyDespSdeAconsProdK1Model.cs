using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ProdyDespSdeAconsProdK1Model : ModelBase
    {
        [Required] public int IdProdyDespSdeAconsProdK1 { get; set; }
        [Required] public int IdPeriodos { get; set; }
        [Required] public int IdModalidadPlantas { get; set; }
        [Required] public int IdCorrientes { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
        public int? IdInfraestructuraPlanta { get; set; }
        [Required] public DateTime Fecha { get; set; }
        [Required] public int IdProdyDespSdeAvariablesNum { get; set; }
        public decimal? Valor { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
