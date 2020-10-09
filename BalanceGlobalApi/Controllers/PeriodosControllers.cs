
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
    public class PeriodosController : ControllerBase
    {
        private readonly IPeriodosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PeriodosController(IPeriodosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PeriodosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPeriodos()
        {
            return await _service.ReadPeriodos();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PeriodosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetPeriodos(int id)
        {
            var _model = await _service.ReadPeriodos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PeriodosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPeriodos(int id, PeriodosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPeriodos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdatePeriodos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PeriodosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostPeriodos(PeriodosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreatePeriodos(model, userName);
            var _model = _resp.Data as PeriodosModel;

            return _httpHelper.GetActionResult(_resp, "GetPeriodos", new { id = _model?.IdPeriodos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PeriodosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeletePeriodos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeletePeriodos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

