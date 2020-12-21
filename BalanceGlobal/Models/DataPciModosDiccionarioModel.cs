using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataPciModosDiccionarioModel : ModelBase
    {
        public string ArchivoOrigen { get; set; }
        public string TabOrigen { get; set; }
        public string ColumnaOrigen { get; set; }
        public string Modalidad { get; set; }
        public string Corriente { get; set; }
        public string Tipo { get; set; }
        public string Variable { get; set; }
        public string Migrar { get; set; }
        public string Descripcion { get; set; }
        public string Observación { get; set; }
        public string TipoTabla { get; set; }
        public string TablaDestino { get; set; }
        public string DescripcionTabla { get; set; }
        public string ColumnaDestino { get; set; }
        public string DataType { get; set; }
        public string Nullable { get; set; }
    }
}
