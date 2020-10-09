
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
    public class ImportadoresUserParController : ControllerBase
    {
        private readonly IImportadoresUserParService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ImportadoresUserParController(IImportadoresUserParService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ImportadoresUserParModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetImportadoresUserPar()
        {
            return await _service.ReadImportadoresUserPar();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportadoresUserParModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetImportadoresUserPar(int id)
        {
            var _model = await _service.ReadImportadoresUserPar(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportadoresUserParModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutImportadoresUserPar(int id, ImportadoresUserParModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportadoresUserPar)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateImportadoresUserPar(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportadoresUserParModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostImportadoresUserPar(ImportadoresUserParModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateImportadoresUserPar(model, userName);
            var _model = _resp.Data as ImportadoresUserParModel;

            return _httpHelper.GetActionResult(_resp, "GetImportadoresUserPar", new { id = _model?.IdImportadoresUserPar });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportadoresUserParModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteImportadoresUserPar(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteImportadoresUserPar(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

