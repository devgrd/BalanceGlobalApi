
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
    public class CorrientePciController : ControllerBase
    {
        private readonly ICorrientePciService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CorrientePciController(ICorrientePciService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CorrientePciModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCorrientePci()
        {
            return await _service.ReadCorrientePci();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientePciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCorrientePci(int id)
        {
            var _model = await _service.ReadCorrientePci(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientePciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCorrientePci(int id, CorrientePciModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrientePci)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCorrientePci(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientePciModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCorrientePci(CorrientePciModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCorrientePci(model, userName);
            var _model = _resp.Data as CorrientePciModel;

            return _httpHelper.GetActionResult(_resp, "GetCorrientePci", new { id = _model?.IdCorrientePci });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientePciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCorrientePci(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCorrientePci(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

