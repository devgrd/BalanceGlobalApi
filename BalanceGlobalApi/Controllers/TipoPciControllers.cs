
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
    public class TipoPciController : ControllerBase
    {
        private readonly ITipoPciService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TipoPciController(ITipoPciService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TipoPciModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTipoPci()
        {
            return await _service.ReadTipoPci();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoPciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTipoPci(int id)
        {
            var _model = await _service.ReadTipoPci(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoPciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTipoPci(int id, TipoPciModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoPci)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTipoPci(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoPciModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTipoPci(TipoPciModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTipoPci(model, userName);
            var _model = _resp.Data as TipoPciModel;

            return _httpHelper.GetActionResult(_resp, "GetTipoPci", new { id = _model?.IdTipoPci });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoPciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTipoPci(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTipoPci(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

