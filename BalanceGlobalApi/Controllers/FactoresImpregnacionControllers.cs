
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
    public class FactoresImpregnacionController : ControllerBase
    {
        private readonly IFactoresImpregnacionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public FactoresImpregnacionController(IFactoresImpregnacionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<FactoresImpregnacionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetFactoresImpregnacion()
        {
            return await _service.ReadFactoresImpregnacion();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FactoresImpregnacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetFactoresImpregnacion(int id)
        {
            var _model = await _service.ReadFactoresImpregnacion(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FactoresImpregnacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutFactoresImpregnacion(int id, FactoresImpregnacionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdFactoresImpregnacion)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateFactoresImpregnacion(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FactoresImpregnacionModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostFactoresImpregnacion(FactoresImpregnacionModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateFactoresImpregnacion(model, userName);
            var _model = _resp.Data as FactoresImpregnacionModel;

            return _httpHelper.GetActionResult(_resp, "GetFactoresImpregnacion", new { id = _model?.IdFactoresImpregnacion });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FactoresImpregnacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteFactoresImpregnacion(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteFactoresImpregnacion(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

