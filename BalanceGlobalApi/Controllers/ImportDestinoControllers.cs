
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
    public class ImportDestinoController : ControllerBase
    {
        private readonly IImportDestinoService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ImportDestinoController(IImportDestinoService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ImportDestinoModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetImportDestino()
        {
            return await _service.ReadImportDestino();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportDestinoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetImportDestino(int id)
        {
            var _model = await _service.ReadImportDestino(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportDestinoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutImportDestino(int id, ImportDestinoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportDestino)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateImportDestino(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportDestinoModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostImportDestino(ImportDestinoModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateImportDestino(model, userName);
            var _model = _resp.Data as ImportDestinoModel;

            return _httpHelper.GetActionResult(_resp, "GetImportDestino", new { id = _model?.IdImportDestino });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportDestinoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteImportDestino(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteImportDestino(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

