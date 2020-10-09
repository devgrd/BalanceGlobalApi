
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
    public class ConsReactivosController : ControllerBase
    {
        private readonly IConsReactivosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsReactivosController(IConsReactivosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsReactivosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsReactivos()
        {
            return await _service.ReadConsReactivos();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsReactivosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsReactivos(int id)
        {
            var _model = await _service.ReadConsReactivos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsReactivosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsReactivos(int id, ConsReactivosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsReactivos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsReactivos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsReactivosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsReactivos(ConsReactivosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsReactivos(model, userName);
            var _model = _resp.Data as ConsReactivosModel;

            return _httpHelper.GetActionResult(_resp, "GetConsReactivos", new { id = _model?.IdConsReactivos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsReactivosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsReactivos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsReactivos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

