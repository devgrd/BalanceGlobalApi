
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IEvaporacionInfiltracionService
    {
        Task<EvaporacionInfiltracionModel> CreateEvaporacionInfiltracion(EvaporacionInfiltracionModel EvaporacionInfiltracionModel, string userName);
        Task<List<EvaporacionInfiltracionModel>> ReadEvaporacionInfiltracion();
        Task UpdateEvaporacionInfiltracion(EvaporacionInfiltracionModel EvaporacionInfiltracionModel, string userName);
        Task DeleteEvaporacionInfiltracion(int id, string userName);
        Task<EvaporacionInfiltracionModel> ReadEvaporacionInfiltracion(int id);
    }
    public class EvaporacionInfiltracionService : IEvaporacionInfiltracionService
    {
        private readonly IEvaporacionInfiltracionRepository _repository;
        private readonly IMapper _mapper;

        public EvaporacionInfiltracionService(IEvaporacionInfiltracionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<EvaporacionInfiltracionModel> CreateEvaporacionInfiltracion(EvaporacionInfiltracionModel model, string userName)
        {
            var result = _mapper.Map<EvaporacionInfiltracion>(model);
            await _repository.AddAsync(result, userName);
            model.IdEvaporacionInfiltracion = result.IdEvaporacionInfiltracion;
            return model;
        }

        public async Task<List<EvaporacionInfiltracionModel>> ReadEvaporacionInfiltracion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<EvaporacionInfiltracionModel>>(data);

            return result;
        }

        public async Task UpdateEvaporacionInfiltracion(EvaporacionInfiltracionModel model, string userName)
        {
            var result = _mapper.Map<EvaporacionInfiltracion>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteEvaporacionInfiltracion(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<EvaporacionInfiltracionModel> ReadEvaporacionInfiltracion(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<EvaporacionInfiltracionModel>(model);
            return result;
        }

        #endregion
    }
}