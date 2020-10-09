
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
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public UsuariosController(IUsuariosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<UsuariosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetUsuarios()
        {
            return await _service.ReadUsuarios();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<UsuariosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetUsuarios(int id)
        {
            var _model = await _service.ReadUsuarios(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<UsuariosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutUsuarios(int id, UsuariosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdUsuarios)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateUsuarios(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<UsuariosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostUsuarios(UsuariosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateUsuarios(model, userName);
            var _model = _resp.Data as UsuariosModel;

            return _httpHelper.GetActionResult(_resp, "GetUsuarios", new { id = _model?.IdUsuarios });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<UsuariosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteUsuarios(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteUsuarios(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

