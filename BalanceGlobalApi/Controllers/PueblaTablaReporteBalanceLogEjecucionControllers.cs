
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
    public class PueblaTablaReporteBalanceLogEjecucionController : ControllerBase
    {
        private readonly IPueblaTablaReporteBalanceLogEjecucionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PueblaTablaReporteBalanceLogEjecucionController(IPueblaTablaReporteBalanceLogEjecucionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PueblaTablaReporteBalanceLogEjecucionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPueblaTablaReporteBalanceLogEjecucion()
        {
            return await _service.ReadPueblaTablaReporteBalanceLogEjecucion();
        }

        //[HttpGet("{id}")]
        //[SwaggerResponse(200, "Ok", typeof(ApiResponse<PueblaTablaReporteBalanceLogEjecucionModel>))]
        //[SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        //public async Task<ActionResult<ApiResponse>> GetPueblaTablaReporteBalanceLogEjecucion(int id)
        //{
        //    var _model = await _service.ReadPueblaTablaReporteBalanceLogEjecucion(id);

        //    return _model;
        //}

        //[HttpPut("{id}")]
        //[SwaggerResponse(200, "Ok", typeof(ApiResponse<PueblaTablaReporteBalanceLogEjecucionModel>))]
        //[SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        //[SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        //public async Task<ActionResult<ApiResponse>> PutPueblaTablaReporteBalanceLogEjecucion(int id, PueblaTablaReporteBalanceLogEjecucionModel model, [Required][FromHeader] string userName)
        //{
        //    if (id != model.IdPueblaTablaReporteBalanceLogEjecucion)
        //    {
        //        return BadRequest(new ApiResponse("Bad Request", 400));
        //    }

        //    var _resp = await _service.UpdatePueblaTablaReporteBalanceLogEjecucion(model, userName);

        //    return _httpHelper.GetActionResult(_resp);
        //}

        //[SwaggerResponse(200, "Ok", typeof(ApiResponse<PueblaTablaReporteBalanceLogEjecucionModel>))]
        //[SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        //[HttpPost]
        //public async Task<ActionResult<ApiResponse>> PostPueblaTablaReporteBalanceLogEjecucion(PueblaTablaReporteBalanceLogEjecucionModel model, [Required][FromHeader] string userName)
        //{
        //    var _resp = await _service.CreatePueblaTablaReporteBalanceLogEjecucion(model, userName);
        //    var _model = _resp.Data as PueblaTablaReporteBalanceLogEjecucionModel;

        //    return _httpHelper.GetActionResult(_resp, "GetPueblaTablaReporteBalanceLogEjecucion", new { id = _model?.IdPueblaTablaReporteBalanceLogEjecucion });
        //}

        //[SwaggerResponse(200, "Ok", typeof(ApiResponse<PueblaTablaReporteBalanceLogEjecucionModel>))]
        //[SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        //[SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<ApiResponse>> DeletePueblaTablaReporteBalanceLogEjecucion(int id, [Required][FromHeader] string userName)
        //{
        //    var _resp = await _service.DeletePueblaTablaReporteBalanceLogEjecucion(id, userName);

        //    return _httpHelper.GetActionResult(_resp);
        //}
    }
}

