
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPorteosService
    {
        Task<PorteosModel> CreatePorteos(PorteosModel PorteosModel, string userName);
        Task<List<PorteosModel>> ReadPorteos();
        Task UpdatePorteos(PorteosModel PorteosModel, string userName);
        Task DeletePorteos(string id, string userName);
        Task<PorteosModel> ReadPorteos(string id);
    }
    public class PorteosService : IPorteosService
    {
        private readonly IPorteosRepository _repository;
        private readonly IMapper _mapper;

        public PorteosService(IPorteosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<PorteosModel> CreatePorteos(PorteosModel model, string userName)
        {
            var result = _mapper.Map<Porteos>(model);
            await _repository.AddAsync(result, userName);
            model.IdPorteos = result.IdPorteos;
            return model;
        }

        public async Task<List<PorteosModel>> ReadPorteos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PorteosModel>>(data);

            return result;
        }

        public async Task UpdatePorteos(PorteosModel model, string userName)
        {
            var result = _mapper.Map<Porteos>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeletePorteos(string id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<PorteosModel> ReadPorteos(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<PorteosModel>(model);
            return result;
        }

        #endregion
    }
}