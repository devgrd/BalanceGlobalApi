using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class ImportDestinoEntity
    {
        public int IdImportDestino { get; set; }
        public int IdSchemaDef { get; set; }
        public byte ImportJobSeq { get; set; }
        public string ImportJobNombre { get; set; }
        public int IdJobTipo { get; set; }
        public string Sqlref { get; set; }
        public string PyRef { get; set; }
        public string Comentario { get; set; }
        public bool? Activa { get; set; }

    }
}
