using System.ComponentModel.DataAnnotations;
namespace BalanceGlobal.Models
{
    public class ReservoriosModel : ModelBase
    {
        [Required] public int IdReservorios { get; set; }
        public string NombreReservorio { get; set; }
        public string Descripcion { get; set; }
        [Required] public bool Activa { get; set; }
    }
}
