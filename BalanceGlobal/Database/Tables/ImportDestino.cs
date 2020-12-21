using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ImportDestino
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

        public virtual JobTipo IdJobTipoNavigation { get; set; }
        public virtual SchemaDef IdSchemaDefNavigation { get; set; }
    }
}
