
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
    public class FaenasController : ControllerBase
    {
        private readonly IFaenasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public FaenasController(IFaenasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<FaenasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetFaenas()
        {
            return await _service.ReadFaenas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FaenasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetFaenas(int id)
        {
            var _model = await _service.ReadFaenas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FaenasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutFaenas(int id, FaenasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdFaenas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateFaenas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FaenasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostFaenas(FaenasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateFaenas(model, userName);
            var _model = _resp.Data as FaenasModel;

            return _httpHelper.GetActionResult(_resp, "GetFaenas", new { id = _model?.IdFaenas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FaenasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteFaenas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteFaenas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

