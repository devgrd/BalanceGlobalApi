
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
    public class ConsumoAguaController : ControllerBase
    {
        private readonly IConsumoAguaService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsumoAguaController(IConsumoAguaService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsumoAguaModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsumoAguaByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadConsumoAguaByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsumoAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsumoAgua(int id)
        {
            var _model = await _service.ReadConsumoAgua(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsumoAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsumoAgua(int id, ConsumoAguaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsumoAgua)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsumoAgua(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsumoAguaModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsumoAgua(ConsumoAguaModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsumoAgua(model, userName);
            var _model = _resp.Data as ConsumoAguaModel;

            return _httpHelper.GetActionResult(_resp, "GetConsumoAgua", new { id = _model?.IdConsumoAgua });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsumoAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsumoAgua(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsumoAgua(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

