
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
    public class ImportacionesUserParValuesController : ControllerBase
    {
        private readonly IImportacionesUserParValuesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ImportacionesUserParValuesController(IImportacionesUserParValuesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ImportacionesUserParValuesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetImportacionesUserParValues()
        {
            return await _service.ReadImportacionesUserParValues();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportacionesUserParValuesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetImportacionesUserParValues(int id)
        {
            var _model = await _service.ReadImportacionesUserParValues(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportacionesUserParValuesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutImportacionesUserParValues(int id, ImportacionesUserParValuesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportacionesUserParValues)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateImportacionesUserParValues(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportacionesUserParValuesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostImportacionesUserParValues(ImportacionesUserParValuesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateImportacionesUserParValues(model, userName);
            var _model = _resp.Data as ImportacionesUserParValuesModel;

            return _httpHelper.GetActionResult(_resp, "GetImportacionesUserParValues", new { id = _model?.IdImportacionesUserParValues });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImportacionesUserParValuesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteImportacionesUserParValues(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteImportacionesUserParValues(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

