
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
        Task<InfraestructurasModel> CreateInfraestructuras(InfraestructurasModel InfraestructurasModel, string userName);
        Task<List<InfraestructurasModel>> ReadInfraestructuras();
        Task UpdateInfraestructuras(InfraestructurasModel InfraestructurasModel, string userName);
        Task DeleteInfraestructuras(int id, string userName);
        Task<InfraestructurasModel> ReadInfraestructuras(int id);
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

        public async Task<InfraestructurasModel> CreateInfraestructuras(InfraestructurasModel model, string userName)
        {
            var result = _mapper.Map<Infraestructuras>(model);
            await _repository.AddAsync(result, userName);
            model.IdInfraestructuras = result.IdInfraestructuras;
            return model;
        }

        public async Task<List<InfraestructurasModel>> ReadInfraestructuras()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<InfraestructurasModel>>(data);

            return result;
        }

        public async Task UpdateInfraestructuras(InfraestructurasModel model, string userName)
        {
            var result = _mapper.Map<Infraestructuras>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteInfraestructuras(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<InfraestructurasModel> ReadInfraestructuras(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<InfraestructurasModel>(model);
            return result;
        }

        #endregion
    }
}