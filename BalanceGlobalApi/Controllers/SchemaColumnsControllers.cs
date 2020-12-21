
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
    public class SchemaColumnsController : ControllerBase
    {
        private readonly ISchemaColumnsService _service;
        private readonly HttpCodeHelper _httpHelper;

        public SchemaColumnsController(ISchemaColumnsService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<SchemaColumnsModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetSchemaColumns([Required][FromQuery] string nombre)
        {
            return await _service.ReadSchemaColumns(nombre);
        }

        [HttpGet("schemadef/{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<SchemaColumnsModel>>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetSchemaColumns(int id)
        {
            var _model = await _service.ReadSchemaColumns(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaColumnsModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutSchemaColumns(int id, SchemaColumnsModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSchemaColumns)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateSchemaColumns(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaColumnsModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostSchemaColumns(SchemaColumnsModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateSchemaColumns(model, userName);
            var _model = _resp.Data as SchemaColumnsModel;

            return _httpHelper.GetActionResult(_resp, "GetSchemaColumns", new { id = _model?.IdSchemaColumns });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaColumnsModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteSchemaColumns(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteSchemaColumns(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

