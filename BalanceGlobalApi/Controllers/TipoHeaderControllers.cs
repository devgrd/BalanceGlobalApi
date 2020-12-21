
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
    public class TipoHeaderController : ControllerBase
    {
        private readonly ITipoHeaderService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TipoHeaderController(ITipoHeaderService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TipoHeaderModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTipoHeader()
        {
            return await _service.ReadTipoHeader();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoHeaderModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTipoHeader(int id)
        {
            var _model = await _service.ReadTipoHeader(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoHeaderModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTipoHeader(int id, TipoHeaderModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoHeader)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTipoHeader(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoHeaderModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTipoHeader(TipoHeaderModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTipoHeader(model, userName);
            var _model = _resp.Data as TipoHeaderModel;

            return _httpHelper.GetActionResult(_resp, "GetTipoHeader", new { id = _model?.IdTipoHeader });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoHeaderModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTipoHeader(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTipoHeader(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

