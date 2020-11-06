
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
    public class CargaPlataformasController : ControllerBase
    {
        private readonly ICargaPlataformasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CargaPlataformasController(ICargaPlataformasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CargaPlataformasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCargaPlataformasByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadCargaPlataformasByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CargaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCargaPlataformas(int id)
        {
            var _model = await _service.ReadCargaPlataformas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CargaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCargaPlataformas(int id, CargaPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCargaPlataformas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCargaPlataformas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CargaPlataformasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCargaPlataformas(CargaPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCargaPlataformas(model, userName);
            var _model = _resp.Data as CargaPlataformasModel;

            return _httpHelper.GetActionResult(_resp, "GetCargaPlataformas", new { id = _model?.IdCargaPlataformas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CargaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCargaPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCargaPlataformas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

