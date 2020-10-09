
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
    public class TipoInfraestructurasController : ControllerBase
    {
        private readonly ITipoInfraestructurasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TipoInfraestructurasController(ITipoInfraestructurasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TipoInfraestructurasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTipoInfraestructuras()
        {
            return await _service.ReadTipoInfraestructuras();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoInfraestructurasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTipoInfraestructuras(int id)
        {
            var _model = await _service.ReadTipoInfraestructuras(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoInfraestructurasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTipoInfraestructuras(int id, TipoInfraestructurasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoInfraestructuras)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTipoInfraestructuras(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoInfraestructurasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTipoInfraestructuras(TipoInfraestructurasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTipoInfraestructuras(model, userName);
            var _model = _resp.Data as TipoInfraestructurasModel;

            return _httpHelper.GetActionResult(_resp, "GetTipoInfraestructuras", new { id = _model?.IdTipoInfraestructuras });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoInfraestructurasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTipoInfraestructuras(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTipoInfraestructuras(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

