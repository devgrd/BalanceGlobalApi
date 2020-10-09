
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
    public class ImportadoresController : ControllerBase
    {
        private readonly IImportadoresService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ImportadoresController(IImportadoresService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ImportadoresModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetImportadores()
        {
            return await _service.ReadImportadores();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportadoresModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetImportadores(int id)
        {
            var _model = await _service.ReadImportadores(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportadoresModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutImportadores(int id, ImportadoresModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportadores)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateImportadores(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportadoresModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostImportadores(ImportadoresModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateImportadores(model, userName);
            var _model = _resp.Data as ImportadoresModel;

            return _httpHelper.GetActionResult(_resp, "GetImportadores", new { id = _model?.IdImportadores });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportadoresModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteImportadores(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteImportadores(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

