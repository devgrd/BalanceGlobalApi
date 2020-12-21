
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
    public class TipoDatoControlController : ControllerBase
    {
        private readonly ITipoDatoControlService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TipoDatoControlController(ITipoDatoControlService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TipoDatoControlModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTipoDatoControl()
        {
            return await _service.ReadTipoDatoControl();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoDatoControlModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTipoDatoControl(int id)
        {
            var _model = await _service.ReadTipoDatoControl(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoDatoControlModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTipoDatoControl(int id, TipoDatoControlModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoDatoControl)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTipoDatoControl(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoDatoControlModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTipoDatoControl(TipoDatoControlModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTipoDatoControl(model, userName);
            var _model = _resp.Data as TipoDatoControlModel;

            return _httpHelper.GetActionResult(_resp, "GetTipoDatoControl", new { id = _model?.IdTipoDatoControl });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoDatoControlModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTipoDatoControl(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTipoDatoControl(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

