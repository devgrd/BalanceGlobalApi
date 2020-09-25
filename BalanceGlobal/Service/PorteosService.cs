
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
        Task<PorteosModel> CreatePorteos(PorteosModel PorteosModel);
        Task<List<PorteosModel>> ReadPorteos();
        Task UpdatePorteos(PorteosModel PorteosModel);
        Task DeletePorteos(string id);
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

        public async Task<PorteosModel> CreatePorteos(PorteosModel model)
        {
            var result = _mapper.Map<Porteos>(model);
            await _repository.AddAsync(result);
            model.IdPorteos = result.IdPorteos;
            return model;
        }

        public async Task<List<PorteosModel>> ReadPorteos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PorteosModel>>(data);

            return result;
        }

        public async Task UpdatePorteos(PorteosModel model)
        {
            var result = _mapper.Map<Porteos>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeletePorteos(string id)
        {
            await _repository.RemoveAsync(id);
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