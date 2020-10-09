
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
    public class TiposInventarioController : ControllerBase
    {
        private readonly ITiposInventarioService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TiposInventarioController(ITiposInventarioService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TiposInventarioModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTiposInventario()
        {
            return await _service.ReadTiposInventario();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TiposInventarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTiposInventario(int id)
        {
            var _model = await _service.ReadTiposInventario(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TiposInventarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTiposInventario(int id, TiposInventarioModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTiposInventario)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTiposInventario(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TiposInventarioModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTiposInventario(TiposInventarioModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTiposInventario(model, userName);
            var _model = _resp.Data as TiposInventarioModel;

            return _httpHelper.GetActionResult(_resp, "GetTiposInventario", new { id = _model?.IdTiposInventario });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TiposInventarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTiposInventario(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTiposInventario(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

