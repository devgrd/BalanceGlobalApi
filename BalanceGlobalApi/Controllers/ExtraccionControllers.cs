
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
    public class ExtraccionController : ControllerBase
    {
        private readonly IExtraccionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ExtraccionController(IExtraccionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ExtraccionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetExtraccion()
        {
            return await _service.ReadExtraccion();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ExtraccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetExtraccion(int id)
        {
            var _model = await _service.ReadExtraccion(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ExtraccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutExtraccion(int id, ExtraccionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdExtraccion)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateExtraccion(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ExtraccionModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostExtraccion(ExtraccionModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateExtraccion(model, userName);
            var _model = _resp.Data as ExtraccionModel;

            return _httpHelper.GetActionResult(_resp, "GetExtraccion", new { id = _model?.IdExtraccion });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ExtraccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteExtraccion(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteExtraccion(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

