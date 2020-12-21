
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
    public class SchemaColumnsWarningController : ControllerBase
    {
        private readonly ISchemaColumnsWarningService _service;
        private readonly HttpCodeHelper _httpHelper;

        public SchemaColumnsWarningController(ISchemaColumnsWarningService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<SchemaColumnsWarningModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetSchemaColumnsWarning([Required][FromQuery] string nombre)
        {
            return await _service.ReadSchemaColumnsWarning(nombre);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaColumnsWarningModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetSchemaColumnsWarning(int id)
        {
            var _model = await _service.ReadSchemaColumnsWarning(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaColumnsWarningModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutSchemaColumnsWarning(int id, SchemaColumnsWarningModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSchemaColumnsWarning)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateSchemaColumnsWarning(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaColumnsWarningModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostSchemaColumnsWarning(SchemaColumnsWarningModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateSchemaColumnsWarning(model, userName);
            var _model = _resp.Data as SchemaColumnsWarningModel;

            return _httpHelper.GetActionResult(_resp, "GetSchemaColumnsWarning", new { id = _model?.IdSchemaColumnsWarning });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaColumnsWarningModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteSchemaColumnsWarning(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteSchemaColumnsWarning(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

