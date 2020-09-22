using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISchemaColumnsWarningService
    {
        Task CreateSchemaColumnsWarning(SchemaColumnsWarningEntity SchemaColumnsWarningEntity);
        Task<List<SchemaColumnsWarningEntity>> ReadSchemaColumnsWarning();
        Task UpdateSchemaColumnsWarning(SchemaColumnsWarningEntity SchemaColumnsWarningEntity);
        Task DeleteSchemaColumnsWarning(string id);
        Task<SchemaColumnsWarningEntity> ReadSchemaColumnsWarning(string id);
    }
    public class SchemaColumnsWarningService : ISchemaColumnsWarningService
    {
        private readonly ISchemaColumnsWarningRepository _repository;
        private readonly IMapper _mapper;

        public SchemaColumnsWarningService(ISchemaColumnsWarningRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateSchemaColumnsWarning(SchemaColumnsWarningEntity entity)
        {
            var result = _mapper.Map<SchemaColumnsWarning>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<SchemaColumnsWarningEntity>> ReadSchemaColumnsWarning()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SchemaColumnsWarningEntity>>(data);

            return result;
        }

        public async Task UpdateSchemaColumnsWarning(SchemaColumnsWarningEntity entity)
        {
            var result = _mapper.Map<SchemaColumnsWarning>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSchemaColumnsWarning(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<SchemaColumnsWarningEntity> ReadSchemaColumnsWarning(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<SchemaColumnsWarningEntity>(entity);
            return result;
        }

        #endregion
    }
}