
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IDescargaInfraestructurasDestinoService
    {
        Task<DescargaInfraestructurasDestinoModel> CreateDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel DescargaInfraestructurasDestinoModel, string userName);
        Task<List<DescargaInfraestructurasDestinoModel>> ReadDescargaInfraestructurasDestino();
        Task UpdateDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel DescargaInfraestructurasDestinoModel, string userName);
        Task DeleteDescargaInfraestructurasDestino(int id, string userName);
        Task<DescargaInfraestructurasDestinoModel> ReadDescargaInfraestructurasDestino(int id);
    }
    public class DescargaInfraestructurasDestinoService : IDescargaInfraestructurasDestinoService
    {
        private readonly IDescargaInfraestructurasDestinoRepository _repository;
        private readonly IMapper _mapper;

        public DescargaInfraestructurasDestinoService(IDescargaInfraestructurasDestinoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<DescargaInfraestructurasDestinoModel> CreateDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel model, string userName)
        {
            var result = _mapper.Map<DescargaInfraestructurasDestino>(model);
            await _repository.AddAsync(result, userName);
            model.IdDescargaInfraestructurasDestino = result.IdDescargaInfraestructurasDestino;
            return model;
        }

        public async Task<List<DescargaInfraestructurasDestinoModel>> ReadDescargaInfraestructurasDestino()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<DescargaInfraestructurasDestinoModel>>(data);

            return result;
        }

        public async Task UpdateDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel model, string userName)
        {
            var result = _mapper.Map<DescargaInfraestructurasDestino>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteDescargaInfraestructurasDestino(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<DescargaInfraestructurasDestinoModel> ReadDescargaInfraestructurasDestino(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<DescargaInfraestructurasDestinoModel>(model);
            return result;
        }

        #endregion
    }
}