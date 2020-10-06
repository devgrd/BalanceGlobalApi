using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceGlobal.Response
{
    public class ApiResponse<T>
    {
        public int Code { get; set; }
        public T Data { get; set; }
    }
}
