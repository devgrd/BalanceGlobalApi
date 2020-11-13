using System;
using System.Collections.Generic;

namespace BalanceGlobal.Database.Tables
{
    public partial class ChangeTrackingDetail
    {
        public long IdChangeTrackingDetail { get; set; }
        public int IdChangeTrackingHeader { get; set; }
        public int Pkvalue { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual ChangeTrackingHeader IdChangeTrackingHeaderNavigation { get; set; }
    }
}
