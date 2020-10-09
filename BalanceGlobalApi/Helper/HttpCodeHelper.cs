using BalanceGlobal.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Helper
{
    public class HttpCodeHelper : ControllerBase
    {
        public ActionResult GetActionResult(ApiResponse resp, string action = "", object prms = null) =>
        resp.Code switch
        {
            200 => new OkObjectResult(resp),
            201 => CreatedAtAction(action, prms, resp.Data),
            404 => new NotFoundObjectResult(resp),
            409 => new ConflictObjectResult(resp),
            _ => new BadRequestObjectResult(resp)

        };
    }
}
