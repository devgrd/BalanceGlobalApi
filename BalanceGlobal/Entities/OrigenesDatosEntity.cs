using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class OrigenesDatosEntity
    {

        public int IdOrigenesDatos { get; set; }
        public int IdImportadores { get; set; }
        public string OrigenDatos { get; set; }
        public string Tab { get; set; }
        public int IdTipoOrigen { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int IdTipoHeader { get; set; }
        public bool? Activa { get; set; }

    }
}
