
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
    public class CorrientesRilesyRisesController : ControllerBase
    {
        private readonly ICorrientesRilesyRisesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CorrientesRilesyRisesController(ICorrientesRilesyRisesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CorrientesRilesyRisesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCorrientesRilesyRises()
        {
            return await _service.ReadCorrientesRilesyRises();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientesRilesyRisesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCorrientesRilesyRises(int id)
        {
            var _model = await _service.ReadCorrientesRilesyRises(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientesRilesyRisesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCorrientesRilesyRises(int id, CorrientesRilesyRisesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrientesRilesyRises)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCorrientesRilesyRises(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientesRilesyRisesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCorrientesRilesyRises(CorrientesRilesyRisesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCorrientesRilesyRises(model, userName);
            var _model = _resp.Data as CorrientesRilesyRisesModel;

            return _httpHelper.GetActionResult(_resp, "GetCorrientesRilesyRises", new { id = _model?.IdCorrientesRilesyRises });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CorrientesRilesyRisesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCorrientesRilesyRises(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCorrientesRilesyRises(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

