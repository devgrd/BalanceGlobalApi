using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DestinationVtModel : ModelBase
    {
        public long? _0IdSincronizacionCorfo { get; set; }
        public string _0IdMensaje { get; set; }
        public string _0NombreTabla { get; set; }
        public string _0TipoTransaccion { get; set; }
        public string _1IdVariable { get; set; }
        public string _1Descripcion { get; set; }
        public string _1Fecha { get; set; }
        public double? _1Valor { get; set; }
        public double? _1ResultNumber { get; set; }
        public string _1SValor { get; set; }
    }
}
