using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class CatalogoTablas
    {
        public int IdCatalogoTablas { get; set; }
        public string Tabla { get; set; }
        public string Corriente { get; set; }
        public string VistaAsociada { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Alias { get; set; }
    }
}
