using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class DataInvAnatacamaConsInvModel : ModelBase
    {
        public string Sistema { get; set; }
        public string Tipo { get; set; }
        public DateTime? MesInvent { get; set; }
        public string NProducc { get; set; }
        public string Factor { get; set; }
        public string Pozas { get; set; }
        public string Area { get; set; }
        public string AlturaSalm { get; set; }
        public string Dens { get; set; }
        public string Ton { get; set; }
        public string K { get; set; }
        public string Mg { get; set; }
        public string Li { get; set; }
        public string So4 { get; set; }
        public string Ca { get; set; }
        public string Cl { get; set; }
        public string Na { get; set; }
        public string H3bo3 { get; set; }
        public double? KclEqv { get; set; }
        public string Li2Co3Eqv { get; set; }
        public double? K2so4Eqv { get; set; }
        public double? MgCl26h2o { get; set; }
        public double? Volumen { get; set; }
        public double? SatK { get; set; }
    }
}
