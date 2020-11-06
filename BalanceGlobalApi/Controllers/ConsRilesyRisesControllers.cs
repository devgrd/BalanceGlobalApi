
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
    public class ConsRilesyRisesController : ControllerBase
    {
        private readonly IConsRilesyRisesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsRilesyRisesController(IConsRilesyRisesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsRilesyRisesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsRilesyRisesByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadConsRilesyRisesByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsRilesyRisesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsRilesyRises(int id)
        {
            var _model = await _service.ReadConsRilesyRises(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsRilesyRisesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsRilesyRises(int id, ConsRilesyRisesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsRilesyRises)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsRilesyRises(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsRilesyRisesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsRilesyRises(ConsRilesyRisesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsRilesyRises(model, userName);
            var _model = _resp.Data as ConsRilesyRisesModel;

            return _httpHelper.GetActionResult(_resp, "GetConsRilesyRises", new { id = _model?.IdConsRilesyRises });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsRilesyRisesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsRilesyRises(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsRilesyRises(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

