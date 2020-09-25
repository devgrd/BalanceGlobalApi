
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IFaenasService
    {
        Task<FaenasModel> CreateFaenas(FaenasModel FaenasModel);
        Task<List<FaenasModel>> ReadFaenas();
        Task UpdateFaenas(FaenasModel FaenasModel);
        Task DeleteFaenas(string id);
        Task<FaenasModel> ReadFaenas(string id);
    }
    public class FaenasService : IFaenasService
    {
        private readonly IFaenasRepository _repository;
        private readonly IMapper _mapper;

        public FaenasService(IFaenasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<FaenasModel> CreateFaenas(FaenasModel model)
        {
            var result = _mapper.Map<Faenas>(model);
            await _repository.AddAsync(result);
            model.IdFaenas = result.IdFaenas;
            return model;
        }

        public async Task<List<FaenasModel>> ReadFaenas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<FaenasModel>>(data);

            return result;
        }

        public async Task UpdateFaenas(FaenasModel model)
        {
            var result = _mapper.Map<Faenas>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteFaenas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<FaenasModel> ReadFaenas(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<FaenasModel>(model);
            return result;
        }

        #endregion
    }
}