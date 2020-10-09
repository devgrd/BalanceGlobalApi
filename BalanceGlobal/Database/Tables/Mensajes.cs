using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class Mensajes
    {
        public int IdMensajes { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public string Tipo { get; set; }
        public string Idioma { get; set; }
        public int Codigo { get; set; }
    }
}
