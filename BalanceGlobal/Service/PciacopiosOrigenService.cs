
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPciacopiosOrigenService
    {
        Task<PciacopiosOrigenModel> CreatePciacopiosOrigen(PciacopiosOrigenModel PciacopiosOrigenModel, string userName);
        Task<List<PciacopiosOrigenModel>> ReadPciacopiosOrigen();
        Task UpdatePciacopiosOrigen(PciacopiosOrigenModel PciacopiosOrigenModel, string userName);
        Task DeletePciacopiosOrigen(int id, string userName);
        Task<PciacopiosOrigenModel> ReadPciacopiosOrigen(int id);
    }
    public class PciacopiosOrigenService : IPciacopiosOrigenService
    {
        private readonly IPciacopiosOrigenRepository _repository;
        private readonly IMapper _mapper;

        public PciacopiosOrigenService(IPciacopiosOrigenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<PciacopiosOrigenModel> CreatePciacopiosOrigen(PciacopiosOrigenModel model, string userName)
        {
            var result = _mapper.Map<PciacopiosOrigen>(model);
            await _repository.AddAsync(result, userName);
            model.IdPciacopiosOrigen = result.IdPciacopiosOrigen;
            return model;
        }

        public async Task<List<PciacopiosOrigenModel>> ReadPciacopiosOrigen()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PciacopiosOrigenModel>>(data);

            return result;
        }

        public async Task UpdatePciacopiosOrigen(PciacopiosOrigenModel model, string userName)
        {
            var result = _mapper.Map<PciacopiosOrigen>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeletePciacopiosOrigen(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<PciacopiosOrigenModel> ReadPciacopiosOrigen(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<PciacopiosOrigenModel>(model);
            return result;
        }

        #endregion
    }
}