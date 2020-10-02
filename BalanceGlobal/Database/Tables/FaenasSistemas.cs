﻿using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class FaenasSistemas
    {
        public int IdFaenasSistemas { get; set; }
        public int IdFaenas { get; set; }
        public int IdSistemas { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Faenas IdFaenasNavigation { get; set; }
        public virtual Sistemas IdSistemasNavigation { get; set; }
    }
}
