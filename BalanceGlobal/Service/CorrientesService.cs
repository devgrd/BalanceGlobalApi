
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICorrientesService
    {
        Task<CorrientesModel> CreateCorrientes(CorrientesModel CorrientesModel, string userName);
        Task<List<CorrientesModel>> ReadCorrientes();
        Task UpdateCorrientes(CorrientesModel CorrientesModel, string userName);
        Task DeleteCorrientes(int id, string userName);
        Task<CorrientesModel> ReadCorrientes(int id);
    }
    public class CorrientesService : ICorrientesService
    {
        private readonly ICorrientesRepository _repository;
        private readonly IMapper _mapper;

        public CorrientesService(ICorrientesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CorrientesModel> CreateCorrientes(CorrientesModel model, string userName)
        {
            var result = _mapper.Map<Corrientes>(model);
            await _repository.AddAsync(result, userName);
            model.IdCorrientes = result.IdCorrientes;
            return model;
        }

        public async Task<List<CorrientesModel>> ReadCorrientes()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CorrientesModel>>(data);

            return result;
        }

        public async Task UpdateCorrientes(CorrientesModel model, string userName)
        {
            var result = _mapper.Map<Corrientes>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCorrientes(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CorrientesModel> ReadCorrientes(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CorrientesModel>(model);
            return result;
        }

        #endregion
    }
}