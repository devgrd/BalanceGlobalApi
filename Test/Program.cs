using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Test.Scaffolding;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo tables = new DirectoryInfo(@"C:\Users\Gerardo\source\repos\BalanceGlobalApi\BalanceGlobal\Database\Tables");
            //var repository = new DirectoryInfo(@"C:\Users\Gerardo\source\repos\BalanceGlobalApi\BalanceGlobal\Repository").GetFiles();

            //var infos = entities.GetFiles()
            //    .Where(x => x.Name != "EntityBase.cs")
            //    .Select(x => @"..\..\..\Repository\"+x.Name.Replace("Entity.cs", "Repository.cs"));

            //var infos = entities.GetFiles()
            //    .Where(x => x.Name != "EntityBase.cs")
            //    .Select(x => @"..\..\..\Service\"+x.Name.Replace("Entity.cs", "Service.cs"));

            //var infos = tables.GetFiles()
            //    .Where(x => x.Name != "EntityBase.cs")
            //    .Select(x => @"..\..\..\Controller\"+x.Name+"Controller.cs");


            //foreach (var r in infos)
            //{
            //    //Directory.CreateDirectory("");
            //    var file = File.Create(r);
            //    file.Close();
            //    File.WriteAllText(r, GetControllerString(r));
            //}

            //Console.WriteLine(count);

            new Scaffold().Create();
        }

        

        public static string GetRepositoryString(string entity) 
        {
            string _entity = Path.GetFileNameWithoutExtension(entity).Replace("Repository", "");

string scaffold = string.Format(@"
using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{{
    public interface I{0}Repository : IRepository<{0}>
    {{

    }}
    public class {0}Repository : RepositoryBase<{0}>, I{0}Repository
    {{
        public {0}Repository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {{

        }}
    }}

}}".Trim(), _entity);

            return scaffold;

        }

        public static string GetDtoString(string entity)
        {
            string _entity = Path.GetFileNameWithoutExtension(entity).Replace("Repository", "");

            string scaffold = string.Format(@"
using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Infrastructure;

namespace BalanceGlobal.Repository
{{
    public interface I{0}Repository : IRepository<{0}>
    {{

    }}
    public class {0}Repository : RepositoryBase<{0}>, I{0}Repository
    {{
        public {0}Repository(BalanceGlobalContext balanceGlobalContext) : base(balanceGlobalContext)
        {{

        }}
    }}

}}".Trim(), _entity);

            return scaffold;

        }

        public static string GetAutoMapperString(string entity) 
        {
            string _entity = Path.GetFileNameWithoutExtension(entity).Replace("Repository", "");

            string _result = "";

string scaffold = string.Format(@"
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;

namespace BalanceGlobal.AutoMapper
{{
    public class AutoMapperProfile1 : Profile
    {{
        public AutoMapperProfile1()
        {{
            

        }}
    }}
}}
".Trim(), _result);

            return scaffold;

        }

        public static string GetServiceString(string entity)
        {
            string _entity = Path.GetFileNameWithoutExtension(entity).Replace("Service", "");

            string scaffold = string.Format(@"
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{{

    public interface I{0}Service
    {{
        Task<{0}Entity> Create{0}({0}Entity {0}Entity);
        Task<List<{0}Entity>> Read{0}();
        Task Update{0}({0}Entity {0}Entity);
        Task Delete{0}(string id);
        Task<{0}Entity> Read{0}(string id);
    }}
    public class {0}Service : I{0}Service
    {{
        private readonly I{0}Repository _repository;
        private readonly IMapper _mapper;

        public {0}Service(I{0}Repository repository, IMapper mapper)
        {{
            _repository = repository;
            _mapper = mapper;
        }}

        #region CRUD

        public async Task<{0}Entity> Create{0}({0}Entity entity)
        {{
            var result = _mapper.Map<{0}>(entity);
            await _repository.AddAsync(result);
            entity.Id{0} = result.Id{0};
            return entity;
        }}

        public async Task<List<{0}Entity>> Read{0}()
        {{
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<{0}Entity>>(data);

            return result;
        }}

        public async Task Update{0}({0}Entity entity)
        {{
            var result = _mapper.Map<{0}>(entity);
            await _repository.UpdateAsync(result);
        }}

        public async Task Delete{0}(string id)
        {{
            await _repository.RemoveAsync(id);
        }}

        public async Task<{0}Entity> Read{0}(string id)
        {{
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<{0}Entity>(entity);
            return result;
        }}

        #endregion
    }}
}}".Trim(), _entity);

            return scaffold;

        }

        public static string GetControllerString(string entity)
        {
            string _entity = Path.GetFileNameWithoutExtension(entity).Replace("Controller", "");

            string scaffold = string.Format(@"
using BalanceGlobal.Entities;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Controllers
{{
    [Route(""api/[controller]"")]
    [ApiController]
    public class {0}Controller : ControllerBase
    {{
        private readonly I{0}Service _service;

        public {0}Controller(I{0}Service service)
        {{
            _service = service;
        }}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<{0}Entity>>> Get{0}()
        {{
            return await _service.Read{0}();
        }}

        [HttpGet(""{{id}}"")]
        public async Task<ActionResult<{0}Entity>> Get{0}(int id)
        {{
            var entity = await _service.Read{0}(id.ToString());

            if (entity == null)
            {{
                return NotFound();
            }}

            return entity;
        }}

        [HttpPut(""{{id}}"")]
        public async Task<IActionResult> Put{0}(int id, {0}Entity entity)
        {{
            if (id != entity.Id{0})
            {{
                return BadRequest();
            }}

            try
            {{
                await _service.Update{0}(entity);
            }}
            catch (DbUpdateConcurrencyException)
            {{
                if (_service.Read{0}(id.ToString()) == null)
                {{
                    return NotFound();
                }}
                else
                {{
                    throw;
                }}
            }}

            return NoContent();
        }}

        [HttpPost]
        public async Task<ActionResult<{0}Entity>> Post{0}({0}Entity entity)
        {{
            var model = await _service.Create{0}(entity);
            return CreatedAtAction(""Get{0}"", new {{ id = model.Id{0} }}, model);
        }}

        [HttpDelete(""{{id}}"")]
        public async Task<ActionResult<{0}Entity>> Delete{0}(int id)
        {{
            var entity = await _service.Read{0}(id.ToString());
            if (entity == null)
            {{
                return NotFound();
            }}

            await _service.Delete{0}(id.ToString());

            return entity;
        }}

    }}
}}
".Trim(), _entity);

            return scaffold;

        }
    
        
    }
}
