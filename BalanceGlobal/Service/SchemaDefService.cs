using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISchemaDefService
    {
        Task CreateSchemaDef(SchemaDefEntity SchemaDefEntity);
        Task<List<SchemaDefEntity>> ReadSchemaDef();
        Task UpdateSchemaDef(SchemaDefEntity SchemaDefEntity);
        Task DeleteSchemaDef(string id);
        Task<SchemaDefEntity> ReadSchemaDef(string id);
    }
    public class SchemaDefService : ISchemaDefService
    {
        private readonly ISchemaDefRepository _repository;
        private readonly IMapper _mapper;

        public SchemaDefService(ISchemaDefRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateSchemaDef(SchemaDefEntity entity)
        {
            var result = _mapper.Map<SchemaDef>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<SchemaDefEntity>> ReadSchemaDef()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SchemaDefEntity>>(data);

            return result;
        }

        public async Task UpdateSchemaDef(SchemaDefEntity entity)
        {
            var result = _mapper.Map<SchemaDef>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSchemaDef(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<SchemaDefEntity> ReadSchemaDef(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<SchemaDefEntity>(entity);
            return result;
        }

        #endregion
    }
}