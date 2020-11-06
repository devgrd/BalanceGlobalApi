
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
    public class TipoDatoColOrigenController : ControllerBase
    {
        private readonly ITipoDatoColOrigenService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TipoDatoColOrigenController(ITipoDatoColOrigenService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TipoDatoColOrigenModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTipoDatoColOrigen()
        {
            return await _service.ReadTipoDatoColOrigen();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoDatoColOrigenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTipoDatoColOrigen(int id)
        {
            var _model = await _service.ReadTipoDatoColOrigen(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoDatoColOrigenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTipoDatoColOrigen(int id, TipoDatoColOrigenModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoDatoColOrigen)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTipoDatoColOrigen(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoDatoColOrigenModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTipoDatoColOrigen(TipoDatoColOrigenModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTipoDatoColOrigen(model, userName);
            var _model = _resp.Data as TipoDatoColOrigenModel;

            return _httpHelper.GetActionResult(_resp, "GetTipoDatoColOrigen", new { id = _model?.IdTipoDatoColOrigen });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoDatoColOrigenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTipoDatoColOrigen(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTipoDatoColOrigen(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

