using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ImportDestinoModel : ModelBase
    {
        [Required] public int IdImportDestino { get; set; }
        [Required] public int IdSchemaDef { get; set; }
        public byte ImportJobSeq { get; set; }
        public string ImportJobNombre { get; set; }
        [Required] public int IdJobTipo { get; set; }
        public string Sqlref { get; set; }
        public string PyRef { get; set; }
        public string Comentario { get; set; }
        public bool? Activa { get; set; }

    }
}
