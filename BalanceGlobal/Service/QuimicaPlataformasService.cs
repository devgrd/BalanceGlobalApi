
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IQuimicaPlataformasService
    {
        Task<QuimicaPlataformasModel> CreateQuimicaPlataformas(QuimicaPlataformasModel QuimicaPlataformasModel, string userName);
        Task<List<QuimicaPlataformasModel>> ReadQuimicaPlataformas();
        Task UpdateQuimicaPlataformas(QuimicaPlataformasModel QuimicaPlataformasModel, string userName);
        Task DeleteQuimicaPlataformas(int id, string userName);
        Task<QuimicaPlataformasModel> ReadQuimicaPlataformas(int id);
    }
    public class QuimicaPlataformasService : IQuimicaPlataformasService
    {
        private readonly IQuimicaPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public QuimicaPlataformasService(IQuimicaPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<QuimicaPlataformasModel> CreateQuimicaPlataformas(QuimicaPlataformasModel model, string userName)
        {
            var result = _mapper.Map<QuimicaPlataformas>(model);
            await _repository.AddAsync(result, userName);
            model.IdQuimicaPlataformas = result.IdQuimicaPlataformas;
            return model;
        }

        public async Task<List<QuimicaPlataformasModel>> ReadQuimicaPlataformas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<QuimicaPlataformasModel>>(data);

            return result;
        }

        public async Task UpdateQuimicaPlataformas(QuimicaPlataformasModel model, string userName)
        {
            var result = _mapper.Map<QuimicaPlataformas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteQuimicaPlataformas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<QuimicaPlataformasModel> ReadQuimicaPlataformas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<QuimicaPlataformasModel>(model);
            return result;
        }

        #endregion
    }
}