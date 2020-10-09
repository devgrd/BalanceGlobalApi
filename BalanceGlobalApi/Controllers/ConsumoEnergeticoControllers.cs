
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
    public class ConsumoEnergeticoController : ControllerBase
    {
        private readonly IConsumoEnergeticoService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsumoEnergeticoController(IConsumoEnergeticoService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsumoEnergeticoModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsumoEnergetico()
        {
            return await _service.ReadConsumoEnergetico();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsumoEnergeticoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsumoEnergetico(int id)
        {
            var _model = await _service.ReadConsumoEnergetico(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsumoEnergeticoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsumoEnergetico(int id, ConsumoEnergeticoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsumoEnergetico)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsumoEnergetico(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsumoEnergeticoModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsumoEnergetico(ConsumoEnergeticoModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsumoEnergetico(model, userName);
            var _model = _resp.Data as ConsumoEnergeticoModel;

            return _httpHelper.GetActionResult(_resp, "GetConsumoEnergetico", new { id = _model?.IdConsumoEnergetico });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsumoEnergeticoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsumoEnergetico(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsumoEnergetico(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

