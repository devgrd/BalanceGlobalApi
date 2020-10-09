
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
    public class CorrientesController : ControllerBase
    {
        private readonly ICorrientesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CorrientesController(ICorrientesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CorrientesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCorrientes()
        {
            return await _service.ReadCorrientes();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCorrientes(int id)
        {
            var _model = await _service.ReadCorrientes(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCorrientes(int id, CorrientesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrientes)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCorrientes(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCorrientes(CorrientesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCorrientes(model, userName);
            var _model = _resp.Data as CorrientesModel;

            return _httpHelper.GetActionResult(_resp, "GetCorrientes", new { id = _model?.IdCorrientes });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCorrientes(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCorrientes(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

