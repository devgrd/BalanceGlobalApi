using System.ComponentModel.DataAnnotations;
namespace BalanceGlobal.Models
{
    public class TransSistemasCosechasModel : ModelBase
    {
        [Required] public int IdTransSistemasCosechas { get; set; }
        public string SistemaOrigen { get; set; }
        public string SubsistemaOrigen { get; set; }
        [Required] public int IdSistemasSubsistemas { get; set; }
    }
}
