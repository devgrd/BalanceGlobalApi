
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
    public class OperaPozasController : ControllerBase
    {
        private readonly IOperaPozasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public OperaPozasController(IOperaPozasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<OperaPozasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetOperaPozas()
        {
            return await _service.ReadOperaPozas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OperaPozasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetOperaPozas(int id)
        {
            var _model = await _service.ReadOperaPozas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OperaPozasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutOperaPozas(int id, OperaPozasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdOperaPozas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateOperaPozas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OperaPozasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostOperaPozas(OperaPozasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateOperaPozas(model, userName);
            var _model = _resp.Data as OperaPozasModel;

            return _httpHelper.GetActionResult(_resp, "GetOperaPozas", new { id = _model?.IdOperaPozas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OperaPozasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteOperaPozas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteOperaPozas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

