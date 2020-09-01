using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Models
{
    public class SubsistemasModel
    {
        public int IdSubsistemas { get; set; }
        [Required]
        public string Subsistema { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public bool? Activa { get; set; }
    }
}
