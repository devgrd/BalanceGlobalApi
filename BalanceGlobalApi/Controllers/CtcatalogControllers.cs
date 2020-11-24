
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
    public class CtcatalogController : ControllerBase
    {
        private readonly ICtcatalogService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CtcatalogController(ICtcatalogService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CtcatalogModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCtcatalog()
        {
            return await _service.ReadCtcatalog();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CtcatalogModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCtcatalog(int id)
        {
            var _model = await _service.ReadCtcatalog(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CtcatalogModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCtcatalog(int id, CtcatalogModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCtcatalog)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCtcatalog(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CtcatalogModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCtcatalog(CtcatalogModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCtcatalog(model, userName);
            var _model = _resp.Data as CtcatalogModel;

            return _httpHelper.GetActionResult(_resp, "GetCtcatalog", new { id = _model?.IdCtcatalog });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CtcatalogModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCtcatalog(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCtcatalog(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

