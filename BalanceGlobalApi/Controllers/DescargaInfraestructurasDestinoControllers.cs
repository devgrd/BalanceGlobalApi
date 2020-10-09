
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
    public class DescargaInfraestructurasDestinoController : ControllerBase
    {
        private readonly IDescargaInfraestructurasDestinoService _service;
        private readonly HttpCodeHelper _httpHelper;

        public DescargaInfraestructurasDestinoController(IDescargaInfraestructurasDestinoService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<DescargaInfraestructurasDestinoModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetDescargaInfraestructurasDestino()
        {
            return await _service.ReadDescargaInfraestructurasDestino();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DescargaInfraestructurasDestinoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetDescargaInfraestructurasDestino(int id)
        {
            var _model = await _service.ReadDescargaInfraestructurasDestino(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DescargaInfraestructurasDestinoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutDescargaInfraestructurasDestino(int id, DescargaInfraestructurasDestinoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdDescargaInfraestructurasDestino)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateDescargaInfraestructurasDestino(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DescargaInfraestructurasDestinoModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateDescargaInfraestructurasDestino(model, userName);
            var _model = _resp.Data as DescargaInfraestructurasDestinoModel;

            return _httpHelper.GetActionResult(_resp, "GetDescargaInfraestructurasDestino", new { id = _model?.IdDescargaInfraestructurasDestino });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DescargaInfraestructurasDestinoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteDescargaInfraestructurasDestino(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteDescargaInfraestructurasDestino(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

