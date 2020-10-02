
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportDestinoService
    {
        Task<ImportDestinoModel> CreateImportDestino(ImportDestinoModel ImportDestinoModel, string userName);
        Task<List<ImportDestinoModel>> ReadImportDestino();
        Task UpdateImportDestino(ImportDestinoModel ImportDestinoModel, string userName);
        Task DeleteImportDestino(int id, string userName);
        Task<ImportDestinoModel> ReadImportDestino(int id);
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

        public async Task<ImportDestinoModel> CreateImportDestino(ImportDestinoModel model, string userName)
        {
            var result = _mapper.Map<ImportDestino>(model);
            await _repository.AddAsync(result, userName);
            model.IdImportDestino = result.IdImportDestino;
            return model;
        }

        public async Task<List<ImportDestinoModel>> ReadImportDestino()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportDestinoModel>>(data);

            return result;
        }

        public async Task UpdateImportDestino(ImportDestinoModel model, string userName)
        {
            var result = _mapper.Map<ImportDestino>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteImportDestino(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ImportDestinoModel> ReadImportDestino(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImportDestinoModel>(model);
            return result;
        }

        #endregion
    }
}