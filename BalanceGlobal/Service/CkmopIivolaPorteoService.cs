
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICkmopIivolaPorteoService
    {
        Task<CkmopIivolaPorteoModel> CreateCkmopIivolaPorteo(CkmopIivolaPorteoModel CkmopIivolaPorteoModel, string userName);
        Task<List<CkmopIivolaPorteoModel>> ReadCkmopIivolaPorteo();
        Task UpdateCkmopIivolaPorteo(CkmopIivolaPorteoModel CkmopIivolaPorteoModel, string userName);
        Task DeleteCkmopIivolaPorteo(int id, string userName);
        Task<CkmopIivolaPorteoModel> ReadCkmopIivolaPorteo(int id);
    }
    public class CkmopIivolaPorteoService : ICkmopIivolaPorteoService
    {
        private readonly ICkmopIivolaPorteoRepository _repository;
        private readonly IMapper _mapper;

        public CkmopIivolaPorteoService(ICkmopIivolaPorteoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CkmopIivolaPorteoModel> CreateCkmopIivolaPorteo(CkmopIivolaPorteoModel model, string userName)
        {
            var result = _mapper.Map<CkmopIivolaPorteo>(model);
            await _repository.AddAsync(result, userName);
            model.IdCkmopIivolaPorteo = result.IdCkmopIivolaPorteo;
            return model;
        }

        public async Task<List<CkmopIivolaPorteoModel>> ReadCkmopIivolaPorteo()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CkmopIivolaPorteoModel>>(data);

            return result;
        }

        public async Task UpdateCkmopIivolaPorteo(CkmopIivolaPorteoModel model, string userName)
        {
            var result = _mapper.Map<CkmopIivolaPorteo>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCkmopIivolaPorteo(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CkmopIivolaPorteoModel> ReadCkmopIivolaPorteo(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CkmopIivolaPorteoModel>(model);
            return result;
        }

        #endregion
    }
}