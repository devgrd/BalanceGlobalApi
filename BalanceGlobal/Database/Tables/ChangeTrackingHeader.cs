using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ChangeTrackingHeader
    {
        public ChangeTrackingHeader()
        {
            ChangeTrackingDetail = new HashSet<ChangeTrackingDetail>();
        }

        public int IdChangeTrackingHeader { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionUser { get; set; }
        public string TransactionType { get; set; }
        public string TableName { get; set; }
        public string Pkname { get; set; }

        public virtual ICollection<ChangeTrackingDetail> ChangeTrackingDetail { get; set; }
    }
}
