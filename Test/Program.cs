using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo entities = new DirectoryInfo(@"C:\Users\Gerardo\source\repos\BalanceGlobalApi\BalanceGlobal\Entities");
            var repository = new DirectoryInfo(@"C:\Users\Gerardo\source\repos\BalanceGlobalApi\BalanceGlobal\Repository").GetFiles();
            //var infos = entities.GetFiles()
            //    .Where(x => x.Name != "EntityBase.cs")
            //    .Select(x => @"..\..\..\Repo\"+x.Name.Replace("Entity.cs", "Repository.cs"));
            
            var infos = entities.GetFiles()
                .Where(x => x.Name != "EntityBase.cs")
                .Select(x => @"..\..\..\Service\"+x.Name.Replace("Entity.cs", "Service.cs"));

            List<string> files = new List<string>();
            //C:\Users\Gerardo\source\repos\BalanceGlobalApi\BalanceGlobal\Repository\ConsInvCarmenRepository.cs
            //C:\Users\Gerardo\source\repos\BalanceGlobalApi\BalanceGlobal\Repository\ConsInvCarmenReporitory.cs
            foreach (var r in infos)
            {
                //Directory.CreateDirectory("");
                var file = File.Create(r);
                file.Close();
                File.WriteAllText(r, GetServiceString(r));
            }

            //Console.WriteLine(count);
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
        Task Create{0}({0}Entity {0}Entity);
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

        public async Task Create{0}({0}Entity entity)
        {{
            var result = _mapper.Map<{0}>(entity);
            await _repository.AddAsync(result);
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
    }
}
