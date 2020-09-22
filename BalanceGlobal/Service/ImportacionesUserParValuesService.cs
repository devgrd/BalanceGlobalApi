using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportacionesUserParValuesService
    {
        Task CreateImportacionesUserParValues(ImportacionesUserParValuesEntity ImportacionesUserParValuesEntity);
        Task<List<ImportacionesUserParValuesEntity>> ReadImportacionesUserParValues();
        Task UpdateImportacionesUserParValues(ImportacionesUserParValuesEntity ImportacionesUserParValuesEntity);
        Task DeleteImportacionesUserParValues(string id);
        Task<ImportacionesUserParValuesEntity> ReadImportacionesUserParValues(string id);
    }
    public class ImportacionesUserParValuesService : IImportacionesUserParValuesService
    {
        private readonly IImportacionesUserParValuesRepository _repository;
        private readonly IMapper _mapper;

        public ImportacionesUserParValuesService(IImportacionesUserParValuesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateImportacionesUserParValues(ImportacionesUserParValuesEntity entity)
        {
            var result = _mapper.Map<ImportacionesUserParValues>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<ImportacionesUserParValuesEntity>> ReadImportacionesUserParValues()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportacionesUserParValuesEntity>>(data);

            return result;
        }

        public async Task UpdateImportacionesUserParValues(ImportacionesUserParValuesEntity entity)
        {
            var result = _mapper.Map<ImportacionesUserParValues>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteImportacionesUserParValues(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ImportacionesUserParValuesEntity> ReadImportacionesUserParValues(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<ImportacionesUserParValuesEntity>(entity);
            return result;
        }

        #endregion
    }
}