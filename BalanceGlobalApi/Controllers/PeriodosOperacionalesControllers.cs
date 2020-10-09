
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
    public class PeriodosOperacionalesController : ControllerBase
    {
        private readonly IPeriodosOperacionalesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PeriodosOperacionalesController(IPeriodosOperacionalesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PeriodosOperacionalesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPeriodosOperacionales()
        {
            return await _service.ReadPeriodosOperacionales();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PeriodosOperacionalesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetPeriodosOperacionales(int id)
        {
            var _model = await _service.ReadPeriodosOperacionales(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PeriodosOperacionalesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPeriodosOperacionales(int id, PeriodosOperacionalesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPeriodosOperacionales)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdatePeriodosOperacionales(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PeriodosOperacionalesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostPeriodosOperacionales(PeriodosOperacionalesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreatePeriodosOperacionales(model, userName);
            var _model = _resp.Data as PeriodosOperacionalesModel;

            return _httpHelper.GetActionResult(_resp, "GetPeriodosOperacionales", new { id = _model?.IdPeriodosOperacionales });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PeriodosOperacionalesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeletePeriodosOperacionales(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeletePeriodosOperacionales(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

