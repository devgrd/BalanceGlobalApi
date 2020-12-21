
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
    public class PerfilesUsuarioController : ControllerBase
    {
        private readonly IPerfilesUsuarioService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PerfilesUsuarioController(IPerfilesUsuarioService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PerfilesUsuarioModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPerfilesUsuario()
        {
            return await _service.ReadPerfilesUsuario();
        }

        [HttpGet("schemadef/{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PerfilesUsuarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetPerfilesUsuario(int id)
        {
            var _model = await _service.ReadPerfilesUsuario(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PerfilesUsuarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPerfilesUsuario(int id, PerfilesUsuarioModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPerfilUsuario)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdatePerfilesUsuario(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [HttpPut("{id:int}/details")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PerfilesUsuarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPerfilesUsuarioDetalle(int id, List<DetallePerfilModel> model, [Required][FromHeader] string userName)
        {

            var _resp = await _service.UpdatePerfilesUsuarioDetalle(id, model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PerfilesUsuarioModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostPerfilesUsuario(PerfilesUsuarioModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreatePerfilesUsuario(model, userName);
            var _model = _resp.Data as PerfilesUsuarioModel;

            return _httpHelper.GetActionResult(_resp, "GetPerfilesUsuario", new { id = _model?.IdPerfilUsuario });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PerfilesUsuarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeletePerfilesUsuario(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeletePerfilesUsuario(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

