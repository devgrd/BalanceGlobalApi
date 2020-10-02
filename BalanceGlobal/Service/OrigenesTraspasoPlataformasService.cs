
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IOrigenesTraspasoPlataformasService
    {
        Task<OrigenesTraspasoPlataformasModel> CreateOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel OrigenesTraspasoPlataformasModel, string userName);
        Task<List<OrigenesTraspasoPlataformasModel>> ReadOrigenesTraspasoPlataformas();
        Task UpdateOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel OrigenesTraspasoPlataformasModel, string userName);
        Task DeleteOrigenesTraspasoPlataformas(int id, string userName);
        Task<OrigenesTraspasoPlataformasModel> ReadOrigenesTraspasoPlataformas(int id);
    }
    public class OrigenesTraspasoPlataformasService : IOrigenesTraspasoPlataformasService
    {
        private readonly IOrigenesTraspasoPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public OrigenesTraspasoPlataformasService(IOrigenesTraspasoPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<OrigenesTraspasoPlataformasModel> CreateOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel model, string userName)
        {
            var result = _mapper.Map<OrigenesTraspasoPlataformas>(model);
            await _repository.AddAsync(result, userName);
            model.IdIdOrigenesTraspasoPlataformas = result.IdIdOrigenesTraspasoPlataformas;
            return model;
        }

        public async Task<List<OrigenesTraspasoPlataformasModel>> ReadOrigenesTraspasoPlataformas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<OrigenesTraspasoPlataformasModel>>(data);

            return result;
        }

        public async Task UpdateOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel model, string userName)
        {
            var result = _mapper.Map<OrigenesTraspasoPlataformas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteOrigenesTraspasoPlataformas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<OrigenesTraspasoPlataformasModel> ReadOrigenesTraspasoPlataformas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<OrigenesTraspasoPlataformasModel>(model);
            return result;
        }

        #endregion
    }
}