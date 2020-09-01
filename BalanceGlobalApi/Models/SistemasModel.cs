using System.ComponentModel.DataAnnotations;

namespace BalanceGlobal.Api.Models
{
    public class SistemasModel
    {
        public int IdSistemas { get; set; }
        [Required]
        public string Sistema { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public bool? Activa { get; set; }
    }
}
