
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
    public class InventariosAtacamaController : ControllerBase
    {
        private readonly IInventariosAtacamaService _service;
        private readonly HttpCodeHelper _httpHelper;

        public InventariosAtacamaController(IInventariosAtacamaService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<InventariosAtacamaModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetInventariosAtacamaByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadInventariosAtacamaByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InventariosAtacamaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetInventariosAtacama(int id)
        {
            var _model = await _service.ReadInventariosAtacama(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InventariosAtacamaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutInventariosAtacama(int id, InventariosAtacamaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdInventariosAtacama)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateInventariosAtacama(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InventariosAtacamaModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostInventariosAtacama(InventariosAtacamaModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateInventariosAtacama(model, userName);
            var _model = _resp.Data as InventariosAtacamaModel;

            return _httpHelper.GetActionResult(_resp, "GetInventariosAtacama", new { id = _model?.IdInventariosAtacama });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InventariosAtacamaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteInventariosAtacama(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteInventariosAtacama(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

