
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITraspasosPlataformasService
    {
        Task<TraspasosPlataformasModel> CreateTraspasosPlataformas(TraspasosPlataformasModel TraspasosPlataformasModel, string userName);
        Task<List<TraspasosPlataformasModel>> ReadTraspasosPlataformas();
        Task UpdateTraspasosPlataformas(TraspasosPlataformasModel TraspasosPlataformasModel, string userName);
        Task DeleteTraspasosPlataformas(int id, string userName);
        Task<TraspasosPlataformasModel> ReadTraspasosPlataformas(int id);
    }
    public class TraspasosPlataformasService : ITraspasosPlataformasService
    {
        private readonly ITraspasosPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public TraspasosPlataformasService(ITraspasosPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<TraspasosPlataformasModel> CreateTraspasosPlataformas(TraspasosPlataformasModel model, string userName)
        {
            var result = _mapper.Map<TraspasosPlataformas>(model);
            await _repository.AddAsync(result, userName);
            model.IdTraspasosPlataformas = result.IdTraspasosPlataformas;
            return model;
        }

        public async Task<List<TraspasosPlataformasModel>> ReadTraspasosPlataformas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TraspasosPlataformasModel>>(data);

            return result;
        }

        public async Task UpdateTraspasosPlataformas(TraspasosPlataformasModel model, string userName)
        {
            var result = _mapper.Map<TraspasosPlataformas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteTraspasosPlataformas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<TraspasosPlataformasModel> ReadTraspasosPlataformas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<TraspasosPlataformasModel>(model);
            return result;
        }

        #endregion
    }
}