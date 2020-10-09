
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
    public class MensajesImportacionController : ControllerBase
    {
        private readonly IMensajesImportacionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public MensajesImportacionController(IMensajesImportacionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<MensajesImportacionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetMensajesImportacion()
        {
            return await _service.ReadMensajesImportacion();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<MensajesImportacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetMensajesImportacion(int id)
        {
            var _model = await _service.ReadMensajesImportacion(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<MensajesImportacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutMensajesImportacion(int id, MensajesImportacionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdMensajesImportacion)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateMensajesImportacion(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<MensajesImportacionModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostMensajesImportacion(MensajesImportacionModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateMensajesImportacion(model, userName);
            var _model = _resp.Data as MensajesImportacionModel;

            return _httpHelper.GetActionResult(_resp, "GetMensajesImportacion", new { id = _model?.IdMensajesImportacion });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<MensajesImportacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteMensajesImportacion(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteMensajesImportacion(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

