using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class SchemaColumnsWarning
    {
        public int IdSchemaColumnsWarning { get; set; }
        public int IdSchemaDef { get; set; }
        public string NombreCol { get; set; }
        public int PosicionCol { get; set; }
        public int IdTipoDatoColOrigen { get; set; }
        public decimal? RangoNumInicio { get; set; }
        public decimal? RangoNumFin { get; set; }
        public int? PresicionNumMin { get; set; }
        public int? PresicionNumMax { get; set; }
        public int? LongitudMaxTexto { get; set; }
        public string FormatoTextoRegex { get; set; }
        public string FormatoFechaRegex { get; set; }
        public int? IdIdiomaFecha { get; set; }
        public DateTime? RangoFechaInicio { get; set; }
        public DateTime? RangoFechaFin { get; set; }
        public int? IdDatosEnLista { get; set; }
        public bool? Requerido { get; set; }
        public bool? Unico { get; set; }

        public virtual SchemaDef IdSchemaDefNavigation { get; set; }
    }
}
