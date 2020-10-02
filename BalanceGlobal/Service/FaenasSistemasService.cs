
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
        Task<FaenasSistemasModel> CreateFaenasSistemas(FaenasSistemasModel FaenasSistemasModel, string userName);
        Task<List<FaenasSistemasModel>> ReadFaenasSistemas();
        Task UpdateFaenasSistemas(FaenasSistemasModel FaenasSistemasModel, string userName);
        Task DeleteFaenasSistemas(int id, string userName);
        Task<FaenasSistemasModel> ReadFaenasSistemas(int id);
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

        public async Task<FaenasSistemasModel> CreateFaenasSistemas(FaenasSistemasModel model, string userName)
        {
            var result = _mapper.Map<FaenasSistemas>(model);
            await _repository.AddAsync(result, userName);
            model.IdFaenasSistemas = result.IdFaenasSistemas;
            return model;
        }

        public async Task<List<FaenasSistemasModel>> ReadFaenasSistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<FaenasSistemasModel>>(data);

            return result;
        }

        public async Task UpdateFaenasSistemas(FaenasSistemasModel model, string userName)
        {
            var result = _mapper.Map<FaenasSistemas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteFaenasSistemas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<FaenasSistemasModel> ReadFaenasSistemas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<FaenasSistemasModel>(model);
            return result;
        }

        #endregion
    }
}