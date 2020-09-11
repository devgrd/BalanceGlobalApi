﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class SistemasSubSistemas
    {
        public int IdSistemasSubsistemas { get; set; }
        public int IdSistemas { get; set; }
        public int? IdSubsistemas { get; set; }

        [JsonIgnore]
        public virtual Sistemas IdSistemasNavigation { get; set; }
        [JsonIgnore]
        public virtual Subsistemas IdSubsistemasNavigation { get; set; }
    }
}
