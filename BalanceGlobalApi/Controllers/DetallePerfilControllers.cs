
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
    public class DetallePerfilController : ControllerBase
    {
        private readonly IDetallePerfilService _service;
        private readonly HttpCodeHelper _httpHelper;

        public DetallePerfilController(IDetallePerfilService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<DetallePerfilModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetDetallePerfil()
        {
            return await _service.ReadDetallePerfil();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DetallePerfilModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetDetallePerfil(int id)
        {
            var _model = await _service.ReadDetallePerfil(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DetallePerfilModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutDetallePerfil(int id, DetallePerfilModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdDetallePerfil)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateDetallePerfil(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DetallePerfilModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostDetallePerfil(DetallePerfilModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateDetallePerfil(model, userName);
            var _model = _resp.Data as DetallePerfilModel;

            return _httpHelper.GetActionResult(_resp, "GetDetallePerfil", new { id = _model?.IdDetallePerfil });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DetallePerfilModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteDetallePerfil(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteDetallePerfil(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

