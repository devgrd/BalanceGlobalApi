
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
    public class CategoriaConsumoAguaController : ControllerBase
    {
        private readonly ICategoriaConsumoAguaService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CategoriaConsumoAguaController(ICategoriaConsumoAguaService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CategoriaConsumoAguaModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCategoriaConsumoAgua()
        {
            return await _service.ReadCategoriaConsumoAgua();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CategoriaConsumoAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCategoriaConsumoAgua(int id)
        {
            var _model = await _service.ReadCategoriaConsumoAgua(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CategoriaConsumoAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCategoriaConsumoAgua(int id, CategoriaConsumoAguaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCategoriaConsumoAgua)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCategoriaConsumoAgua(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CategoriaConsumoAguaModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCategoriaConsumoAgua(CategoriaConsumoAguaModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCategoriaConsumoAgua(model, userName);
            var _model = _resp.Data as CategoriaConsumoAguaModel;

            return _httpHelper.GetActionResult(_resp, "GetCategoriaConsumoAgua", new { id = _model?.IdCategoriaConsumoAgua });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CategoriaConsumoAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCategoriaConsumoAgua(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCategoriaConsumoAgua(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

