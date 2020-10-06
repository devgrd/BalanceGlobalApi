using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceGlobal.Response
{
    public class ApiResponse<T>
    {
        public ApiResponse(T data, bool isError = false, int code = 200)
        {
            IsError = isError;
            Code = code;
            Data = data;
        }

        public bool IsError { get; set; }
        public int Code { get; set; }
        public T Data { get; set; }
    }

    public class ApiResponse
    {
        public ApiResponse(object data, bool isError = false, int code = 200)
        {
            IsError = isError;
            Code = code;
            Data = data ?? default;
        }

        public bool IsError { get; set; }
        public int Code { get; set; }
        public object Data { get; set; } = null;
    }
}
