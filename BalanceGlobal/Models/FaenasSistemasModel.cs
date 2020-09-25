using System.ComponentModel.DataAnnotations;
namespace BalanceGlobal.Models
{
    public class FaenasSistemasModel : ModelBase
    {
        [Required] public int IdFaenasSistemas { get; set; }
        [Required] public int IdFaenas { get; set; }
        [Required] public int IdSistemas { get; set; }

    }
}
