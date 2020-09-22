using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISchemaColumnsService
    {
        Task CreateSchemaColumns(SchemaColumnsEntity SchemaColumnsEntity);
        Task<List<SchemaColumnsEntity>> ReadSchemaColumns();
        Task UpdateSchemaColumns(SchemaColumnsEntity SchemaColumnsEntity);
        Task DeleteSchemaColumns(string id);
        Task<SchemaColumnsEntity> ReadSchemaColumns(string id);
    }
    public class SchemaColumnsService : ISchemaColumnsService
    {
        private readonly ISchemaColumnsRepository _repository;
        private readonly IMapper _mapper;

        public SchemaColumnsService(ISchemaColumnsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateSchemaColumns(SchemaColumnsEntity entity)
        {
            var result = _mapper.Map<SchemaColumns>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<SchemaColumnsEntity>> ReadSchemaColumns()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SchemaColumnsEntity>>(data);

            return result;
        }

        public async Task UpdateSchemaColumns(SchemaColumnsEntity entity)
        {
            var result = _mapper.Map<SchemaColumns>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSchemaColumns(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<SchemaColumnsEntity> ReadSchemaColumns(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<SchemaColumnsEntity>(entity);
            return result;
        }

        #endregion
    }
}