﻿using System;

namespace BalanceGlobal.Database.Tables
{
    public partial class Bombas
    {
        public int IdBombas { get; set; }
        public string Bomba { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}