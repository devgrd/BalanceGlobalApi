using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportDestinoService
    {
        Task CreateImportDestino(ImportDestinoEntity ImportDestinoEntity);
        Task<List<ImportDestinoEntity>> ReadImportDestino();
        Task UpdateImportDestino(ImportDestinoEntity ImportDestinoEntity);
        Task DeleteImportDestino(string id);
        Task<ImportDestinoEntity> ReadImportDestino(string id);
    }
    public class ImportDestinoService : IImportDestinoService
    {
        private readonly IImportDestinoRepository _repository;
        private readonly IMapper _mapper;

        public ImportDestinoService(IImportDestinoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateImportDestino(ImportDestinoEntity entity)
        {
            var result = _mapper.Map<ImportDestino>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<ImportDestinoEntity>> ReadImportDestino()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportDestinoEntity>>(data);

            return result;
        }

        public async Task UpdateImportDestino(ImportDestinoEntity entity)
        {
            var result = _mapper.Map<ImportDestino>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteImportDestino(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ImportDestinoEntity> ReadImportDestino(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<ImportDestinoEntity>(entity);
            return result;
        }

        #endregion
    }
}