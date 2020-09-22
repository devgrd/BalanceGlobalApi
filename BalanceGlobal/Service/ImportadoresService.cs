using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportadoresService
    {
        Task CreateImportadores(ImportadoresEntity ImportadoresEntity);
        Task<List<ImportadoresEntity>> ReadImportadores();
        Task UpdateImportadores(ImportadoresEntity ImportadoresEntity);
        Task DeleteImportadores(string id);
        Task<ImportadoresEntity> ReadImportadores(string id);
    }
    public class ImportadoresService : IImportadoresService
    {
        private readonly IImportadoresRepository _repository;
        private readonly IMapper _mapper;

        public ImportadoresService(IImportadoresRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateImportadores(ImportadoresEntity entity)
        {
            var result = _mapper.Map<Importadores>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<ImportadoresEntity>> ReadImportadores()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportadoresEntity>>(data);

            return result;
        }

        public async Task UpdateImportadores(ImportadoresEntity entity)
        {
            var result = _mapper.Map<Importadores>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteImportadores(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ImportadoresEntity> ReadImportadores(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<ImportadoresEntity>(entity);
            return result;
        }

        #endregion
    }
}