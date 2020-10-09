
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
    public class SchemaDefController : ControllerBase
    {
        private readonly ISchemaDefService _service;
        private readonly HttpCodeHelper _httpHelper;

        public SchemaDefController(ISchemaDefService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<SchemaDefModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetSchemaDef()
        {
            return await _service.ReadSchemaDef();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaDefModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetSchemaDef(int id)
        {
            var _model = await _service.ReadSchemaDef(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaDefModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutSchemaDef(int id, SchemaDefModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSchemaDef)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateSchemaDef(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaDefModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostSchemaDef(SchemaDefModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateSchemaDef(model, userName);
            var _model = _resp.Data as SchemaDefModel;

            return _httpHelper.GetActionResult(_resp, "GetSchemaDef", new { id = _model?.IdSchemaDef });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SchemaDefModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteSchemaDef(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteSchemaDef(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

