using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ChangeTrackingDetailModel : ModelBase
    {
        public long IdChangeTrackingDetail { get; set; }
        [Required] public int IdChangeTrackingHeader { get; set; }
        [Required] public int Pkvalue { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

    }
}
