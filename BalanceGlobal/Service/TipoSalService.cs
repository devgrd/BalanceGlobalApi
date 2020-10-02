
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITipoSalService
    {
        Task<TipoSalModel> CreateTipoSal(TipoSalModel TipoSalModel, string userName);
        Task<List<TipoSalModel>> ReadTipoSal();
        Task UpdateTipoSal(TipoSalModel TipoSalModel, string userName);
        Task DeleteTipoSal(int id, string userName);
        Task<TipoSalModel> ReadTipoSal(int id);
    }
    public class TipoSalService : ITipoSalService
    {
        private readonly ITipoSalRepository _repository;
        private readonly IMapper _mapper;

        public TipoSalService(ITipoSalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<TipoSalModel> CreateTipoSal(TipoSalModel model, string userName)
        {
            var result = _mapper.Map<TipoSal>(model);
            await _repository.AddAsync(result, userName);
            model.IdTipoSal = result.IdTipoSal;
            return model;
        }

        public async Task<List<TipoSalModel>> ReadTipoSal()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TipoSalModel>>(data);

            return result;
        }

        public async Task UpdateTipoSal(TipoSalModel model, string userName)
        {
            var result = _mapper.Map<TipoSal>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteTipoSal(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<TipoSalModel> ReadTipoSal(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<TipoSalModel>(model);
            return result;
        }

        #endregion
    }
}