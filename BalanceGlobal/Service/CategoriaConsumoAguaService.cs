
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICategoriaConsumoAguaService
    {
        Task<CategoriaConsumoAguaModel> CreateCategoriaConsumoAgua(CategoriaConsumoAguaModel CategoriaConsumoAguaModel, string userName);
        Task<List<CategoriaConsumoAguaModel>> ReadCategoriaConsumoAgua();
        Task UpdateCategoriaConsumoAgua(CategoriaConsumoAguaModel CategoriaConsumoAguaModel, string userName);
        Task DeleteCategoriaConsumoAgua(int id, string userName);
        Task<CategoriaConsumoAguaModel> ReadCategoriaConsumoAgua(int id);
    }
    public class CategoriaConsumoAguaService : ICategoriaConsumoAguaService
    {
        private readonly ICategoriaConsumoAguaRepository _repository;
        private readonly IMapper _mapper;

        public CategoriaConsumoAguaService(ICategoriaConsumoAguaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CategoriaConsumoAguaModel> CreateCategoriaConsumoAgua(CategoriaConsumoAguaModel model, string userName)
        {
            var result = _mapper.Map<CategoriaConsumoAgua>(model);
            await _repository.AddAsync(result, userName);
            model.IdCategoriaConsumoAgua = result.IdCategoriaConsumoAgua;
            return model;
        }

        public async Task<List<CategoriaConsumoAguaModel>> ReadCategoriaConsumoAgua()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CategoriaConsumoAguaModel>>(data);

            return result;
        }

        public async Task UpdateCategoriaConsumoAgua(CategoriaConsumoAguaModel model, string userName)
        {
            var result = _mapper.Map<CategoriaConsumoAgua>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCategoriaConsumoAgua(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CategoriaConsumoAguaModel> ReadCategoriaConsumoAgua(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CategoriaConsumoAguaModel>(model);
            return result;
        }

        #endregion
    }
}