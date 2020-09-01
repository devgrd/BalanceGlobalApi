using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodosController : ControllerBase
    {
        private readonly IService _service;
        public PeriodosController(IService service)
        {
            _service = service;
        }

        // GET: api/<PeriodosController>
        [HttpGet]
        public IEnumerable<Periodos> Get()
        {
            return _service.GetPeriodos();
        }

        // GET api/<PeriodosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PeriodosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeriodosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeriodosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
