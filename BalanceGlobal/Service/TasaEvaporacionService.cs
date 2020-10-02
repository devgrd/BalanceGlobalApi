
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITasaEvaporacionService
    {
        Task<TasaEvaporacionModel> CreateTasaEvaporacion(TasaEvaporacionModel TasaEvaporacionModel, string userName);
        Task<List<TasaEvaporacionModel>> ReadTasaEvaporacion();
        Task UpdateTasaEvaporacion(TasaEvaporacionModel TasaEvaporacionModel, string userName);
        Task DeleteTasaEvaporacion(int id, string userName);
        Task<TasaEvaporacionModel> ReadTasaEvaporacion(int id);
    }
    public class TasaEvaporacionService : ITasaEvaporacionService
    {
        private readonly ITasaEvaporacionRepository _repository;
        private readonly IMapper _mapper;

        public TasaEvaporacionService(ITasaEvaporacionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<TasaEvaporacionModel> CreateTasaEvaporacion(TasaEvaporacionModel model, string userName)
        {
            var result = _mapper.Map<TasaEvaporacion>(model);
            await _repository.AddAsync(result, userName);
            model.IdTasaEvaporacion = result.IdTasaEvaporacion;
            return model;
        }

        public async Task<List<TasaEvaporacionModel>> ReadTasaEvaporacion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TasaEvaporacionModel>>(data);

            return result;
        }

        public async Task UpdateTasaEvaporacion(TasaEvaporacionModel model, string userName)
        {
            var result = _mapper.Map<TasaEvaporacion>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteTasaEvaporacion(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<TasaEvaporacionModel> ReadTasaEvaporacion(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<TasaEvaporacionModel>(model);
            return result;
        }

        #endregion
    }
}