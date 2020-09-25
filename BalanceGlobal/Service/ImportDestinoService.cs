
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
        Task<ImportDestinoModel> CreateImportDestino(ImportDestinoModel ImportDestinoModel);
        Task<List<ImportDestinoModel>> ReadImportDestino();
        Task UpdateImportDestino(ImportDestinoModel ImportDestinoModel);
        Task DeleteImportDestino(string id);
        Task<ImportDestinoModel> ReadImportDestino(string id);
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

        public async Task<ImportDestinoModel> CreateImportDestino(ImportDestinoModel model)
        {
            var result = _mapper.Map<ImportDestino>(model);
            await _repository.AddAsync(result);
            model.IdImportDestino = result.IdImportDestino;
            return model;
        }

        public async Task<List<ImportDestinoModel>> ReadImportDestino()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportDestinoModel>>(data);

            return result;
        }

        public async Task UpdateImportDestino(ImportDestinoModel model)
        {
            var result = _mapper.Map<ImportDestino>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteImportDestino(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ImportDestinoModel> ReadImportDestino(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImportDestinoModel>(model);
            return result;
        }

        #endregion
    }
}