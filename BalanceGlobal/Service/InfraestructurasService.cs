
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IInfraestructurasService
    {
        Task<InfraestructurasModel> CreateInfraestructuras(InfraestructurasModel InfraestructurasModel);
        Task<List<InfraestructurasModel>> ReadInfraestructuras();
        Task UpdateInfraestructuras(InfraestructurasModel InfraestructurasModel);
        Task DeleteInfraestructuras(string id);
        Task<InfraestructurasModel> ReadInfraestructuras(string id);
    }
    public class InfraestructurasService : IInfraestructurasService
    {
        private readonly IInfraestructurasRepository _repository;
        private readonly IMapper _mapper;

        public InfraestructurasService(IInfraestructurasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<InfraestructurasModel> CreateInfraestructuras(InfraestructurasModel model)
        {
            var result = _mapper.Map<Infraestructuras>(model);
            await _repository.AddAsync(result);
            model.IdInfraestructuras = result.IdInfraestructuras;
            return model;
        }

        public async Task<List<InfraestructurasModel>> ReadInfraestructuras()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<InfraestructurasModel>>(data);

            return result;
        }

        public async Task UpdateInfraestructuras(InfraestructurasModel model)
        {
            var result = _mapper.Map<Infraestructuras>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteInfraestructuras(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<InfraestructurasModel> ReadInfraestructuras(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<InfraestructurasModel>(model);
            return result;
        }

        #endregion
    }
}