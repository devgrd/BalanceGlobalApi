
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
    public class FaenasSistemasController : ControllerBase
    {
        private readonly IFaenasSistemasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public FaenasSistemasController(IFaenasSistemasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<FaenasSistemasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetFaenasSistemas()
        {
            return await _service.ReadFaenasSistemas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FaenasSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetFaenasSistemas(int id)
        {
            var _model = await _service.ReadFaenasSistemas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FaenasSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutFaenasSistemas(int id, FaenasSistemasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdFaenasSistemas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateFaenasSistemas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FaenasSistemasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostFaenasSistemas(FaenasSistemasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateFaenasSistemas(model, userName);
            var _model = _resp.Data as FaenasSistemasModel;

            return _httpHelper.GetActionResult(_resp, "GetFaenasSistemas", new { id = _model?.IdFaenasSistemas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FaenasSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteFaenasSistemas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteFaenasSistemas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

