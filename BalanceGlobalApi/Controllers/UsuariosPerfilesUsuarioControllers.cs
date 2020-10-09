
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
    public class UsuariosPerfilesUsuarioController : ControllerBase
    {
        private readonly IUsuariosPerfilesUsuarioService _service;
        private readonly HttpCodeHelper _httpHelper;

        public UsuariosPerfilesUsuarioController(IUsuariosPerfilesUsuarioService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<UsuariosPerfilesUsuarioModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetUsuariosPerfilesUsuario()
        {
            return await _service.ReadUsuariosPerfilesUsuario();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<UsuariosPerfilesUsuarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetUsuariosPerfilesUsuario(int id)
        {
            var _model = await _service.ReadUsuariosPerfilesUsuario(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<UsuariosPerfilesUsuarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutUsuariosPerfilesUsuario(int id, UsuariosPerfilesUsuarioModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdUsuariosPerfilesUsuario)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateUsuariosPerfilesUsuario(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<UsuariosPerfilesUsuarioModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostUsuariosPerfilesUsuario(UsuariosPerfilesUsuarioModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateUsuariosPerfilesUsuario(model, userName);
            var _model = _resp.Data as UsuariosPerfilesUsuarioModel;

            return _httpHelper.GetActionResult(_resp, "GetUsuariosPerfilesUsuario", new { id = _model?.IdUsuariosPerfilesUsuario });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<UsuariosPerfilesUsuarioModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteUsuariosPerfilesUsuario(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteUsuariosPerfilesUsuario(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

