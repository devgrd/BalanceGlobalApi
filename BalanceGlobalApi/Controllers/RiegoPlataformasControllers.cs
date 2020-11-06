
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
    public class RiegoPlataformasController : ControllerBase
    {
        private readonly IRiegoPlataformasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public RiegoPlataformasController(IRiegoPlataformasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<RiegoPlataformasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetRiegoPlataformasByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadRiegoPlataformasByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<RiegoPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetRiegoPlataformas(int id)
        {
            var _model = await _service.ReadRiegoPlataformas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<RiegoPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutRiegoPlataformas(int id, RiegoPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdRiegoPlataformas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateRiegoPlataformas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<RiegoPlataformasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostRiegoPlataformas(RiegoPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateRiegoPlataformas(model, userName);
            var _model = _resp.Data as RiegoPlataformasModel;

            return _httpHelper.GetActionResult(_resp, "GetRiegoPlataformas", new { id = _model?.IdRiegoPlataformas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<RiegoPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteRiegoPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteRiegoPlataformas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

