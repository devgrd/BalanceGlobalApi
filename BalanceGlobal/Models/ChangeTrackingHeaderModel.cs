using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BalanceGlobal.Models
{
    public class ChangeTrackingHeaderModel : ModelBase
    {

        [Required] public int IdChangeTrackingHeader { get; set; }
        [Required] public DateTime TransactionDate { get; set; }
        public string TransactionUser { get; set; }
        public string TransactionType { get; set; }
        public string TableName { get; set; }
        public string Pkname { get; set; }

    }
}
