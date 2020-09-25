
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IFaenasSistemasService
    {
        Task<FaenasSistemasModel> CreateFaenasSistemas(FaenasSistemasModel FaenasSistemasModel);
        Task<List<FaenasSistemasModel>> ReadFaenasSistemas();
        Task UpdateFaenasSistemas(FaenasSistemasModel FaenasSistemasModel);
        Task DeleteFaenasSistemas(string id);
        Task<FaenasSistemasModel> ReadFaenasSistemas(string id);
    }
    public class FaenasSistemasService : IFaenasSistemasService
    {
        private readonly IFaenasSistemasRepository _repository;
        private readonly IMapper _mapper;

        public FaenasSistemasService(IFaenasSistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<FaenasSistemasModel> CreateFaenasSistemas(FaenasSistemasModel model)
        {
            var result = _mapper.Map<FaenasSistemas>(model);
            await _repository.AddAsync(result);
            model.IdFaenasSistemas = result.IdFaenasSistemas;
            return model;
        }

        public async Task<List<FaenasSistemasModel>> ReadFaenasSistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<FaenasSistemasModel>>(data);

            return result;
        }

        public async Task UpdateFaenasSistemas(FaenasSistemasModel model)
        {
            var result = _mapper.Map<FaenasSistemas>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteFaenasSistemas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<FaenasSistemasModel> ReadFaenasSistemas(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<FaenasSistemasModel>(model);
            return result;
        }

        #endregion
    }
}