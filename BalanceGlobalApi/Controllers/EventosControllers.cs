
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
    public class EventosController : ControllerBase
    {
        private readonly IEventosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public EventosController(IEventosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<EventosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetEventos()
        {
            return await _service.ReadEventos();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<EventosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetEventos(int id)
        {
            var _model = await _service.ReadEventos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<EventosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutEventos(int id, EventosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdEventos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateEventos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<EventosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostEventos(EventosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateEventos(model, userName);
            var _model = _resp.Data as EventosModel;

            return _httpHelper.GetActionResult(_resp, "GetEventos", new { id = _model?.IdEventos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<EventosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteEventos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteEventos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

