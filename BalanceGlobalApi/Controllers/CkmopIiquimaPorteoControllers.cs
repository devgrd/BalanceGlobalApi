
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
    public class CkmopIiquimaPorteoController : ControllerBase
    {
        private readonly ICkmopIiquimaPorteoService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CkmopIiquimaPorteoController(ICkmopIiquimaPorteoService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CkmopIiquimaPorteoModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCkmopIiquimaPorteoByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadCkmopIiquimaPorteoByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CkmopIiquimaPorteoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCkmopIiquimaPorteo(int id)
        {
            var _model = await _service.ReadCkmopIiquimaPorteo(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CkmopIiquimaPorteoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCkmopIiquimaPorteo(int id, CkmopIiquimaPorteoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCkmopIiquimaPorteo)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCkmopIiquimaPorteo(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CkmopIiquimaPorteoModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCkmopIiquimaPorteo(CkmopIiquimaPorteoModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCkmopIiquimaPorteo(model, userName);
            var _model = _resp.Data as CkmopIiquimaPorteoModel;

            return _httpHelper.GetActionResult(_resp, "GetCkmopIiquimaPorteo", new { id = _model?.IdCkmopIiquimaPorteo });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CkmopIiquimaPorteoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCkmopIiquimaPorteo(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCkmopIiquimaPorteo(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

