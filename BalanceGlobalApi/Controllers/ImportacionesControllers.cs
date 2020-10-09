
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
    public class ImportacionesController : ControllerBase
    {
        private readonly IImportacionesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ImportacionesController(IImportacionesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ImportacionesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetImportaciones()
        {
            return await _service.ReadImportaciones();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportacionesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetImportaciones(int id)
        {
            var _model = await _service.ReadImportaciones(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportacionesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutImportaciones(int id, ImportacionesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportaciones)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateImportaciones(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportacionesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostImportaciones(ImportacionesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateImportaciones(model, userName);
            var _model = _resp.Data as ImportacionesModel;

            return _httpHelper.GetActionResult(_resp, "GetImportaciones", new { id = _model?.IdImportaciones });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportacionesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteImportaciones(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteImportaciones(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

