
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
    public class EvaporacionInfiltracionController : ControllerBase
    {
        private readonly IEvaporacionInfiltracionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public EvaporacionInfiltracionController(IEvaporacionInfiltracionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<EvaporacionInfiltracionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetEvaporacionInfiltracionByPeriodo([Required][FromQuery] int idPeriodo)
        {
            return await _service.ReadEvaporacionInfiltracionByPeriodos(idPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<EvaporacionInfiltracionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetEvaporacionInfiltracion(int id)
        {
            var _model = await _service.ReadEvaporacionInfiltracion(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<EvaporacionInfiltracionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutEvaporacionInfiltracion(int id, EvaporacionInfiltracionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdEvaporacionInfiltracion)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateEvaporacionInfiltracion(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<EvaporacionInfiltracionModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostEvaporacionInfiltracion(EvaporacionInfiltracionModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateEvaporacionInfiltracion(model, userName);
            var _model = _resp.Data as EvaporacionInfiltracionModel;

            return _httpHelper.GetActionResult(_resp, "GetEvaporacionInfiltracion", new { id = _model?.IdEvaporacionInfiltracion });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<EvaporacionInfiltracionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteEvaporacionInfiltracion(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteEvaporacionInfiltracion(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

