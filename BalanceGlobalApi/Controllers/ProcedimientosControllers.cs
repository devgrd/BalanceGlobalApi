
using BalanceGlobal.Api.Helper;
using BalanceGlobal.Models;
using BalanceGlobal.Response;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedimientosController : ControllerBase
    {
        private readonly IProcedimientosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ProcedimientosController(IProcedimientosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<AliasesModel>>))]
        [HttpGet("ultimosperiodos")]
        public async Task<ActionResult<ApiResponse>> GetUltimosPeriodosTablasDatos()
        {     
            var _resp = await _service.GspGetUltimosPeriodosTablasDatos();
            return _httpHelper.GetActionResult(_resp);
        }
        
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<string>))]
        [HttpPost("poblarTablaTeporteBalance")]
        public async Task<ActionResult<ApiResponse>> Post([Required][FromHeader] string userName)
        {
            var _resp = await _service.GspPueblaTablaReporteBalance(userName);
            return _httpHelper.GetActionResult(_resp);
        } 
        
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<dynamic>>))]
        [HttpGet("UltimosSeisPeriodosTablasDatos")]
        public ActionResult<ApiResponse> UltimosSeisPeriodosTablasDatos()
        {
            var _resp = _service.GspGetUltimosSeisPeriodosTablasDatos();
            return _httpHelper.GetActionResult(_resp);
        }   
    }
}

