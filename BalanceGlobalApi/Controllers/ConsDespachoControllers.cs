
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
    public class ConsDespachoController : ControllerBase
    {
        private readonly IConsDespachoService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsDespachoController(IConsDespachoService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsDespachoModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsDespachoByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadConsDespachoByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsDespachoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsDespacho(int id)
        {
            var _model = await _service.ReadConsDespacho(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsDespachoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsDespacho(int id, ConsDespachoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsDespacho)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsDespacho(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsDespachoModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsDespacho(ConsDespachoModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsDespacho(model, userName);
            var _model = _resp.Data as ConsDespachoModel;

            return _httpHelper.GetActionResult(_resp, "GetConsDespacho", new { id = _model?.IdConsDespacho });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsDespachoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsDespacho(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsDespacho(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

