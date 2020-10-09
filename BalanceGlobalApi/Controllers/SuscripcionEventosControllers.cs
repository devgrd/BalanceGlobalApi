
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
    public class SuscripcionEventosController : ControllerBase
    {
        private readonly ISuscripcionEventosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public SuscripcionEventosController(ISuscripcionEventosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<SuscripcionEventosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetSuscripcionEventos()
        {
            return await _service.ReadSuscripcionEventos();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SuscripcionEventosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetSuscripcionEventos(int id)
        {
            var _model = await _service.ReadSuscripcionEventos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SuscripcionEventosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutSuscripcionEventos(int id, SuscripcionEventosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSuscripcionEventos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateSuscripcionEventos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SuscripcionEventosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostSuscripcionEventos(SuscripcionEventosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateSuscripcionEventos(model, userName);
            var _model = _resp.Data as SuscripcionEventosModel;

            return _httpHelper.GetActionResult(_resp, "GetSuscripcionEventos", new { id = _model?.IdSuscripcionEventos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SuscripcionEventosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteSuscripcionEventos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteSuscripcionEventos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

