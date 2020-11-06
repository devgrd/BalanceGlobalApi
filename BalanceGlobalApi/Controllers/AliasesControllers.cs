
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
    public class AliasesController : ControllerBase
    {
        private readonly IAliasesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public AliasesController(IAliasesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<AliasesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetAliases()
        {
            return await _service.ReadAliases();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<AliasesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetAliases(int id)
        {
            var _model = await _service.ReadAliases(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<AliasesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutAliases(int id, AliasesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdAliases)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateAliases(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<AliasesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostAliases(AliasesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateAliases(model, userName);
            var _model = _resp.Data as AliasesModel;

            return _httpHelper.GetActionResult(_resp, "GetAliases", new { id = _model?.IdAliases });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<AliasesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteAliases(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteAliases(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

