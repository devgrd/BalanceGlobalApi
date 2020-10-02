
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICargaPlataformasService
    {
        Task<CargaPlataformasModel> CreateCargaPlataformas(CargaPlataformasModel CargaPlataformasModel, string userName);
        Task<List<CargaPlataformasModel>> ReadCargaPlataformas();
        Task UpdateCargaPlataformas(CargaPlataformasModel CargaPlataformasModel, string userName);
        Task DeleteCargaPlataformas(int id, string userName);
        Task<CargaPlataformasModel> ReadCargaPlataformas(int id);
    }
    public class CargaPlataformasService : ICargaPlataformasService
    {
        private readonly ICargaPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public CargaPlataformasService(ICargaPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CargaPlataformasModel> CreateCargaPlataformas(CargaPlataformasModel model, string userName)
        {
            var result = _mapper.Map<CargaPlataformas>(model);
            await _repository.AddAsync(result, userName);
            model.IdCargaPlataformas = result.IdCargaPlataformas;
            return model;
        }

        public async Task<List<CargaPlataformasModel>> ReadCargaPlataformas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CargaPlataformasModel>>(data);

            return result;
        }

        public async Task UpdateCargaPlataformas(CargaPlataformasModel model, string userName)
        {
            var result = _mapper.Map<CargaPlataformas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCargaPlataformas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CargaPlataformasModel> ReadCargaPlataformas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CargaPlataformasModel>(model);
            return result;
        }

        #endregion
    }
}