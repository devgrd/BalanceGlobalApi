using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class IdescargaPlataformasModel : ModelBase
    {
        public int? IdIdescargaPlataformas { get; set; }
        public string Fecha { get; set; }
        public string MesRes { get; set; }
        public string Plataforma { get; set; }
        public string Origen { get; set; }
        public double? VolumenSalidaM3 { get; set; }
        public double? Impregnación { get; set; }
        public double? VolumenEnPlataformaM3 { get; set; }
        public string Tipo { get; set; }
        public double? MasaTon { get; set; }
        public double? VolumenM3 { get; set; }
        public double? Li { get; set; }
        public double? K { get; set; }
        public double? Mg { get; set; }
        public double? So4 { get; set; }
        public double? Ca { get; set; }
        public double? Cl { get; set; }
        public double? Na { get; set; }
        public double? H3bo3 { get; set; }
    }
}
