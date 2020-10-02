using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ModalidadPciModel : ModelBase
    {

        [Required] public int IdModalidadPci { get; set; }
        public string ModalidadPci1 { get; set; }
        public string Descripcion { get; set; }
        [Required] public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
