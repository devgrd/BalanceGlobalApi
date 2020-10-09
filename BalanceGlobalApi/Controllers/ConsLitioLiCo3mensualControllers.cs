
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
    public class ConsLitioLiCo3mensualController : ControllerBase
    {
        private readonly IConsLitioLiCo3mensualService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsLitioLiCo3mensualController(IConsLitioLiCo3mensualService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsLitioLiCo3mensualModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsLitioLiCo3mensual()
        {
            return await _service.ReadConsLitioLiCo3mensual();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsLitioLiCo3mensualModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsLitioLiCo3mensual(int id)
        {
            var _model = await _service.ReadConsLitioLiCo3mensual(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsLitioLiCo3mensualModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsLitioLiCo3mensual(int id, ConsLitioLiCo3mensualModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsLitioLiCo3mensual)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsLitioLiCo3mensual(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsLitioLiCo3mensualModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsLitioLiCo3mensual(model, userName);
            var _model = _resp.Data as ConsLitioLiCo3mensualModel;

            return _httpHelper.GetActionResult(_resp, "GetConsLitioLiCo3mensual", new { id = _model?.IdConsLitioLiCo3mensual });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsLitioLiCo3mensualModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsLitioLiCo3mensual(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsLitioLiCo3mensual(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

