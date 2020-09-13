using System;
using System.Collections.Generic;

namespace BalanceGlobal.Entities
{
    public partial class Reservorios
    {
        public int IdReservorios { get; set; }
        public string NombreReservorio { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
    }
}
