
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
    public class BgajustesController : ControllerBase
    {
        private readonly IBgajustesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public BgajustesController(IBgajustesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<BgajustesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetBgajustesByPeriodo([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadBgajustesByPeriodo(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgajustesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetBgajustes(int id)
        {
            var _model = await _service.ReadBgajustes(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgajustesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutBgajustes(int id, BgajustesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdBgajustes)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateBgajustes(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgajustesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostBgajustes(BgajustesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateBgajustes(model, userName);
            var _model = _resp.Data as BgajustesModel;

            return _httpHelper.GetActionResult(_resp, "GetBgajustes", new { id = _model?.IdBgajustes });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgajustesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteBgajustes(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteBgajustes(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

