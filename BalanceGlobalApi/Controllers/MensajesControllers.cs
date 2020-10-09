
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
    public class MensajesController : ControllerBase
    {
        private readonly IMensajesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public MensajesController(IMensajesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<MensajesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetMensajes()
        {
            return await _service.ReadMensajes();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<MensajesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetMensajes(int id)
        {
            var _model = await _service.ReadMensajes(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<MensajesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutMensajes(int id, MensajesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdMensajes)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateMensajes(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<MensajesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostMensajes(MensajesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateMensajes(model, userName);
            var _model = _resp.Data as MensajesModel;

            return _httpHelper.GetActionResult(_resp, "GetMensajes", new { id = _model?.IdMensajes });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<MensajesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteMensajes(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteMensajes(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

