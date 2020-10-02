
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICosechasService
    {
        Task<CosechasModel> CreateCosechas(CosechasModel CosechasModel, string userName);
        Task<List<CosechasModel>> ReadCosechas();
        Task UpdateCosechas(CosechasModel CosechasModel, string userName);
        Task DeleteCosechas(int id, string userName);
        Task<CosechasModel> ReadCosechas(int id);
    }
    public class CosechasService : ICosechasService
    {
        private readonly ICosechasRepository _repository;
        private readonly IMapper _mapper;

        public CosechasService(ICosechasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CosechasModel> CreateCosechas(CosechasModel model, string userName)
        {
            var result = _mapper.Map<Cosechas>(model);
            await _repository.AddAsync(result, userName);
            model.IdCosechas = result.IdCosechas;
            return model;
        }

        public async Task<List<CosechasModel>> ReadCosechas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CosechasModel>>(data);

            return result;
        }

        public async Task UpdateCosechas(CosechasModel model, string userName)
        {
            var result = _mapper.Map<Cosechas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCosechas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CosechasModel> ReadCosechas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CosechasModel>(model);
            return result;
        }

        #endregion
    }
}