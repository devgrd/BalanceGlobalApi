
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IRiegoPlataformasService
    {
        Task<RiegoPlataformasModel> CreateRiegoPlataformas(RiegoPlataformasModel RiegoPlataformasModel, string userName);
        Task<List<RiegoPlataformasModel>> ReadRiegoPlataformas();
        Task UpdateRiegoPlataformas(RiegoPlataformasModel RiegoPlataformasModel, string userName);
        Task DeleteRiegoPlataformas(int id, string userName);
        Task<RiegoPlataformasModel> ReadRiegoPlataformas(int id);
    }
    public class RiegoPlataformasService : IRiegoPlataformasService
    {
        private readonly IRiegoPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public RiegoPlataformasService(IRiegoPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<RiegoPlataformasModel> CreateRiegoPlataformas(RiegoPlataformasModel model, string userName)
        {
            var result = _mapper.Map<RiegoPlataformas>(model);
            await _repository.AddAsync(result, userName);
            model.IdRiegoPlataformas = result.IdRiegoPlataformas;
            return model;
        }

        public async Task<List<RiegoPlataformasModel>> ReadRiegoPlataformas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<RiegoPlataformasModel>>(data);

            return result;
        }

        public async Task UpdateRiegoPlataformas(RiegoPlataformasModel model, string userName)
        {
            var result = _mapper.Map<RiegoPlataformas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteRiegoPlataformas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<RiegoPlataformasModel> ReadRiegoPlataformas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<RiegoPlataformasModel>(model);
            return result;
        }

        #endregion
    }
}