
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IFactoresImpregnacionService
    {
        Task<FactoresImpregnacionModel> CreateFactoresImpregnacion(FactoresImpregnacionModel FactoresImpregnacionModel, string userName);
        Task<List<FactoresImpregnacionModel>> ReadFactoresImpregnacion();
        Task UpdateFactoresImpregnacion(FactoresImpregnacionModel FactoresImpregnacionModel, string userName);
        Task DeleteFactoresImpregnacion(int id, string userName);
        Task<FactoresImpregnacionModel> ReadFactoresImpregnacion(int id);
    }
    public class FactoresImpregnacionService : IFactoresImpregnacionService
    {
        private readonly IFactoresImpregnacionRepository _repository;
        private readonly IMapper _mapper;

        public FactoresImpregnacionService(IFactoresImpregnacionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<FactoresImpregnacionModel> CreateFactoresImpregnacion(FactoresImpregnacionModel model, string userName)
        {
            var result = _mapper.Map<FactoresImpregnacion>(model);
            await _repository.AddAsync(result, userName);
            model.IdFactoresImpregnacion = result.IdFactoresImpregnacion;
            return model;
        }

        public async Task<List<FactoresImpregnacionModel>> ReadFactoresImpregnacion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<FactoresImpregnacionModel>>(data);

            return result;
        }

        public async Task UpdateFactoresImpregnacion(FactoresImpregnacionModel model, string userName)
        {
            var result = _mapper.Map<FactoresImpregnacion>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteFactoresImpregnacion(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<FactoresImpregnacionModel> ReadFactoresImpregnacion(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<FactoresImpregnacionModel>(model);
            return result;
        }

        #endregion
    }
}