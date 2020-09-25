using System.ComponentModel.DataAnnotations;
using System;

namespace BalanceGlobal.Models
{
    public class PeriodosOperacionalesModel : ModelBase
    {
        [Required] public int IdPeriodosOperacionales { get; set; }
        [Required] public int IdSistemas { get; set; }
        [Required] public int IdPeriodo { get; set; }
        [Required] public DateTime FechaInicio { get; set; }
        [Required] public DateTime FechaFin { get; set; }
    }
}
