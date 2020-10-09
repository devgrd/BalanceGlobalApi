
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
    public class CorrienteGlobalController : ControllerBase
    {
        private readonly ICorrienteGlobalService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CorrienteGlobalController(ICorrienteGlobalService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CorrienteGlobalModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCorrienteGlobal()
        {
            return await _service.ReadCorrienteGlobal();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrienteGlobalModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCorrienteGlobal(int id)
        {
            var _model = await _service.ReadCorrienteGlobal(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrienteGlobalModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCorrienteGlobal(int id, CorrienteGlobalModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrienteGlobal)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCorrienteGlobal(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrienteGlobalModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCorrienteGlobal(CorrienteGlobalModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCorrienteGlobal(model, userName);
            var _model = _resp.Data as CorrienteGlobalModel;

            return _httpHelper.GetActionResult(_resp, "GetCorrienteGlobal", new { id = _model?.IdCorrienteGlobal });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrienteGlobalModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCorrienteGlobal(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCorrienteGlobal(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

