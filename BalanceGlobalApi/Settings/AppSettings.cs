using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Settings
{
    public class AppSettings
    {
        public Credentials Credentials { get; set; }
    }

    public class Credentials 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
