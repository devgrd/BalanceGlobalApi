
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
    public class CorrienteLi2Co3Controller : ControllerBase
    {
        private readonly ICorrienteLi2Co3Service _service;
        private readonly HttpCodeHelper _httpHelper;

        public CorrienteLi2Co3Controller(ICorrienteLi2Co3Service service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CorrienteLi2Co3Model>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCorrienteLi2Co3()
        {
            return await _service.ReadCorrienteLi2Co3();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrienteLi2Co3Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCorrienteLi2Co3(int id)
        {
            var _model = await _service.ReadCorrienteLi2Co3(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrienteLi2Co3Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCorrienteLi2Co3(int id, CorrienteLi2Co3Model model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrienteLi2Co3)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCorrienteLi2Co3(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrienteLi2Co3Model>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCorrienteLi2Co3(CorrienteLi2Co3Model model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCorrienteLi2Co3(model, userName);
            var _model = _resp.Data as CorrienteLi2Co3Model;

            return _httpHelper.GetActionResult(_resp, "GetCorrienteLi2Co3", new { id = _model?.IdCorrienteLi2Co3 });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrienteLi2Co3Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCorrienteLi2Co3(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCorrienteLi2Co3(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

