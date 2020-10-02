
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IExtraccionAguaService
    {
        Task<ExtraccionAguaModel> CreateExtraccionAgua(ExtraccionAguaModel ExtraccionAguaModel, string userName);
        Task<List<ExtraccionAguaModel>> ReadExtraccionAgua();
        Task UpdateExtraccionAgua(ExtraccionAguaModel ExtraccionAguaModel, string userName);
        Task DeleteExtraccionAgua(int id, string userName);
        Task<ExtraccionAguaModel> ReadExtraccionAgua(int id);
    }
    public class ExtraccionAguaService : IExtraccionAguaService
    {
        private readonly IExtraccionAguaRepository _repository;
        private readonly IMapper _mapper;

        public ExtraccionAguaService(IExtraccionAguaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ExtraccionAguaModel> CreateExtraccionAgua(ExtraccionAguaModel model, string userName)
        {
            var result = _mapper.Map<ExtraccionAgua>(model);
            await _repository.AddAsync(result, userName);
            model.IdExtraccionAgua = result.IdExtraccionAgua;
            return model;
        }

        public async Task<List<ExtraccionAguaModel>> ReadExtraccionAgua()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ExtraccionAguaModel>>(data);

            return result;
        }

        public async Task UpdateExtraccionAgua(ExtraccionAguaModel model, string userName)
        {
            var result = _mapper.Map<ExtraccionAgua>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteExtraccionAgua(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ExtraccionAguaModel> ReadExtraccionAgua(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ExtraccionAguaModel>(model);
            return result;
        }

        #endregion
    }
}