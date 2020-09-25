using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test.Scaffolding
{
    public class Scaffold
    {
        public Scaffold()
        {
            Entities = new List<string> {"Repository", "Service", "Controller" };
        }
        public Scaffold(List<string> entities)
        {
            Entities = entities;
        }

        public string RepositoryTemplateFormat { get => @"
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

}}".Trim(); }
        public string ServiceTemplateFormat { get => @"
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{{

    public interface I{0}Service
    {{
        Task<{0}Model> Create{0}({0}Model {0}Model);
        Task<List<{0}Model>> Read{0}();
        Task Update{0}({0}Model {0}Model);
        Task Delete{0}(string id);
        Task<{0}Model> Read{0}(string id);
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

        public async Task<{0}Model> Create{0}({0}Model model)
        {{
            var result = _mapper.Map<{0}>(model);
            await _repository.AddAsync(result);
            model.Id{0} = result.Id{0};
            return model;
        }}

        public async Task<List<{0}Model>> Read{0}()
        {{
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<{0}Model>>(data);

            return result;
        }}

        public async Task Update{0}({0}Model model)
        {{
            var result = _mapper.Map<{0}>(model);
            await _repository.UpdateAsync(result);
        }}

        public async Task Delete{0}(string id)
        {{
            await _repository.RemoveAsync(id);
        }}

        public async Task<{0}Model> Read{0}(string id)
        {{
            var model = await _repository.GetById(id);
            var result = _mapper.Map<{0}Model>(model);
            return result;
        }}

        #endregion
    }}
}}"; }
        public string ControllerTemplateFormat { get => @"
using BalanceGlobal.Models;
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
        public async Task<ActionResult<IEnumerable<{0}Model>>> Get{0}()
        {{
            return await _service.Read{0}();
        }}

        [HttpGet(""{{id}}"")]
        public async Task<ActionResult<{0}Model>> Get{0}(int id)
        {{
            var _model = await _service.Read{0}(id.ToString());

            if (_model == null)
            {{
                return NotFound();
            }}

            return _model;
        }}

        [HttpPut(""{{id}}"")]
        public async Task<IActionResult> Put{0}(int id, {0}Model model)
        {{
            if (id != model.Id{0})
            {{
                return BadRequest();
            }}

            try
            {{
                await _service.Update{0}(model);
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
        public async Task<ActionResult<{0}Model>> Post{0}({0}Model model)
        {{
            var _model = await _service.Create{0}(model);
            return CreatedAtAction(""Get{0}"", new {{ id = _model.Id{0} }}, _model);
        }}

        [HttpDelete(""{{id}}"")]
        public async Task<ActionResult<{0}Model>> Delete{0}(int id)
        {{
            var _model = await _service.Read{0}(id.ToString());
            if (_model == null)
            {{
                return NotFound();
            }}

            await _service.Delete{0}(id.ToString());

            return _model;
        }}

    }}
}}"; }
        public string AutoMapperTemplateFormat { get => @"
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;

namespace BalanceGlobal.AutoMapper
{{
    public class AutoMapperProfile1 : Profile
    {{
        public AutoMapperProfile1()
        {{
            {0}

        }}
    }}
}}"; }

        public string BaseUrl { get; set; }
      
        private List<string> Entities { get; set; }

        public List<FileInfo> Files { get => new DirectoryInfo(@"C:\Users\Gerardo\source\repos\BalanceGlobalApi\BalanceGlobal\Database\Tables").GetFiles().ToList(); }
        private string GetTemplateString(string entity, string model) 
        {
            switch (entity)
            {
                case "Repository":
                    return string.Format(RepositoryTemplateFormat, model);

                case "Service":
                    return string.Format(ServiceTemplateFormat, model);

                case "Controller": 
                    return string.Format(ControllerTemplateFormat, model);

                case "AutoMapper": 
                    return string.Format(AutoMapperTemplateFormat, model);

                default: return null;

            }
        }


        public void Create() 
        {
            foreach (var f in Files.Where(x => x.Name == "Flujos.cs" || x.Name == "Reinyeccion.cs"))
            {
                string newFile = $@"..\..\..\Models\{f.Name.Replace(".cs", "Model.cs")}";
                string _modelName = Path.GetFileNameWithoutExtension(newFile).Replace("Model", "");

                File.Copy(f.FullName, newFile, true);

                string text = File.ReadAllText(newFile);
                text = "using System.ComponentModel.DataAnnotations;" + "\n" + text;
                text = text
                    .Replace("BalanceGlobal.Database.Tables", "BalanceGlobal.Models")
                    .Replace("class " + _modelName, $"class {_modelName}Model : ModelBase")
                    .Replace($"public {_modelName}", $"public {_modelName}Model")
                    .Replace("partial ", "")
                    .Replace("public DateTime ", "[Required] public DateTime ")
                    .Replace("public int ", "[Required] public int ")
                    .Replace("public decimal ", "[Required] public decimal ")
                    .Replace("public double ", "[Required] public double ")
                    .Replace("public bool ", "[Required] public bool ")
                    ;

                File.WriteAllText(newFile, text);

                var lines = File.ReadAllLines(newFile).Where(x => !x.Trim().Contains("public virtual")).ToList();
                
                
                File.WriteAllLines(newFile, lines.ToArray());
                
                var index1 = lines.FindIndex(x => x.Contains($"public {_modelName}Model"));

                if (index1 > 0)
                {
                    var index2 = lines.FindIndex(index1, x => x.Contains("}"))+1;
                    
                    lines.RemoveRange(index1, index2-index1);
                    File.WriteAllLines(newFile, lines.ToArray());
                }
                
            }

            foreach (var e in Entities)
            {
                _CreateFiles(e);
            }
        }

        private void _CreateFiles(string entity) 
        {
      

            var files = Files.Where(x => x.Name == "Flujos.cs" || x.Name == "Reinyeccion.cs").Select(x => $@"..\..\..\{entity}\{x.Name.Replace(".cs", "")}{entity}.cs").ToList();

            foreach (var r in files)
            {
                string _modelName = Path.GetFileNameWithoutExtension(r).Replace(entity, "");

                var file = File.Create(r);
                file.Close();
                File.WriteAllText(r, GetTemplateString(entity, _modelName));
            }


        }

        #region backup

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


        public static string GetDtoString(List<string> entities)
        {
            string _entity = "";//Path.GetFileNameWithoutExtension(entities).Replace("Repository", "");

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

        #endregion
    }
}
