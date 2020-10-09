
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
    public class ExtraccionAguaController : ControllerBase
    {
        private readonly IExtraccionAguaService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ExtraccionAguaController(IExtraccionAguaService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ExtraccionAguaModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetExtraccionAgua()
        {
            return await _service.ReadExtraccionAgua();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ExtraccionAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetExtraccionAgua(int id)
        {
            var _model = await _service.ReadExtraccionAgua(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ExtraccionAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutExtraccionAgua(int id, ExtraccionAguaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdExtraccionAgua)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateExtraccionAgua(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ExtraccionAguaModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostExtraccionAgua(ExtraccionAguaModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateExtraccionAgua(model, userName);
            var _model = _resp.Data as ExtraccionAguaModel;

            return _httpHelper.GetActionResult(_resp, "GetExtraccionAgua", new { id = _model?.IdExtraccionAgua });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ExtraccionAguaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteExtraccionAgua(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteExtraccionAgua(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

