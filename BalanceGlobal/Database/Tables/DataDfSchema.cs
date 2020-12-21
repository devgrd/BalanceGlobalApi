using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class DataDfSchema
    {
        public string Importador { get; set; }
        public string Tipo { get; set; }
        public string IdSchemaDef { get; set; }
        public string Tab { get; set; }
        public string NombreCol { get; set; }
        public double? PosicionCol { get; set; }
        public string IdTipoDatoColOrigen { get; set; }
        public double? RangoNumInicio { get; set; }
        public double? RangoNumFin { get; set; }
        public double? PresicionNumMin { get; set; }
        public double? PresicionNumMax { get; set; }
        public double? LongitudMaxTexto { get; set; }
        public double? FormatoTextoRegex { get; set; }
        public double? FormatoFechaRegex { get; set; }
        public double? IdIdiomaFecha { get; set; }
        public double? RangoFechaInicio { get; set; }
        public double? RangoFechaFin { get; set; }
        public double? IdDatosEnLista { get; set; }
        public double? Requerido { get; set; }
        public double? Unico { get; set; }
        public string Filename { get; set; }
    }
}
