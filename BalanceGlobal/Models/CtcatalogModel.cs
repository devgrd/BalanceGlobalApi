using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class CtcatalogModel : ModelBase
    {
        [Required] public int IdCtcatalog { get; set; }
        public string TableName { get; set; }
        public string TablePkfield { get; set; }
        public string TrackingFields { get; set; }
        public string TrackingFrom { get; set; }
        public bool? Active { get; set; }
    }
}
