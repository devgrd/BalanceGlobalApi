
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
    public class BgclasificacionController : ControllerBase
    {
        private readonly IBgclasificacionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public BgclasificacionController(IBgclasificacionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<BgclasificacionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetBgclasificacion()
        {
            return await _service.ReadBgclasificacion();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgclasificacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetBgclasificacion(int id)
        {
            var _model = await _service.ReadBgclasificacion(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgclasificacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutBgclasificacion(int id, BgclasificacionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdBgclasificacion)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateBgclasificacion(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgclasificacionModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostBgclasificacion(BgclasificacionModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateBgclasificacion(model, userName);
            var _model = _resp.Data as BgclasificacionModel;

            return _httpHelper.GetActionResult(_resp, "GetBgclasificacion", new { id = _model?.IdBgclasificacion });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgclasificacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteBgclasificacion(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteBgclasificacion(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

