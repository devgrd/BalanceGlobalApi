
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPcimodosService
    {
        Task<PcimodosModel> CreatePcimodos(PcimodosModel PcimodosModel, string userName);
        Task<List<PcimodosModel>> ReadPcimodos();
        Task UpdatePcimodos(PcimodosModel PcimodosModel, string userName);
        Task DeletePcimodos(int id, string userName);
        Task<PcimodosModel> ReadPcimodos(int id);
    }
    public class PcimodosService : IPcimodosService
    {
        private readonly IPcimodosRepository _repository;
        private readonly IMapper _mapper;

        public PcimodosService(IPcimodosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<PcimodosModel> CreatePcimodos(PcimodosModel model, string userName)
        {
            var result = _mapper.Map<Pcimodos>(model);
            await _repository.AddAsync(result, userName);
            model.IdPcimodos = result.IdPcimodos;
            return model;
        }

        public async Task<List<PcimodosModel>> ReadPcimodos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PcimodosModel>>(data);

            return result;
        }

        public async Task UpdatePcimodos(PcimodosModel model, string userName)
        {
            var result = _mapper.Map<Pcimodos>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeletePcimodos(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<PcimodosModel> ReadPcimodos(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<PcimodosModel>(model);
            return result;
        }

        #endregion
    }
}