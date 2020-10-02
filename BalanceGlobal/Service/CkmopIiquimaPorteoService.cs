
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICkmopIiquimaPorteoService
    {
        Task<CkmopIiquimaPorteoModel> CreateCkmopIiquimaPorteo(CkmopIiquimaPorteoModel CkmopIiquimaPorteoModel, string userName);
        Task<List<CkmopIiquimaPorteoModel>> ReadCkmopIiquimaPorteo();
        Task UpdateCkmopIiquimaPorteo(CkmopIiquimaPorteoModel CkmopIiquimaPorteoModel, string userName);
        Task DeleteCkmopIiquimaPorteo(int id, string userName);
        Task<CkmopIiquimaPorteoModel> ReadCkmopIiquimaPorteo(int id);
    }
    public class CkmopIiquimaPorteoService : ICkmopIiquimaPorteoService
    {
        private readonly ICkmopIiquimaPorteoRepository _repository;
        private readonly IMapper _mapper;

        public CkmopIiquimaPorteoService(ICkmopIiquimaPorteoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CkmopIiquimaPorteoModel> CreateCkmopIiquimaPorteo(CkmopIiquimaPorteoModel model, string userName)
        {
            var result = _mapper.Map<CkmopIiquimaPorteo>(model);
            await _repository.AddAsync(result, userName);
            model.IdCkmopIiquimaPorteo = result.IdCkmopIiquimaPorteo;
            return model;
        }

        public async Task<List<CkmopIiquimaPorteoModel>> ReadCkmopIiquimaPorteo()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CkmopIiquimaPorteoModel>>(data);

            return result;
        }

        public async Task UpdateCkmopIiquimaPorteo(CkmopIiquimaPorteoModel model, string userName)
        {
            var result = _mapper.Map<CkmopIiquimaPorteo>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCkmopIiquimaPorteo(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CkmopIiquimaPorteoModel> ReadCkmopIiquimaPorteo(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CkmopIiquimaPorteoModel>(model);
            return result;
        }

        #endregion
    }
}