
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISubSistemasService
    {
        Task<SubSistemasModel> CreateSubSistemas(SubSistemasModel SubSistemasModel, string userName);
        Task<List<SubSistemasModel>> ReadSubSistemas();
        Task UpdateSubSistemas(SubSistemasModel SubSistemasModel, string userName);
        Task DeleteSubSistemas(string id, string userName);
        Task<SubSistemasModel> ReadSubSistemas(string id);
    }
    public class SubSistemasService : ISubSistemasService
    {
        private readonly ISubSistemasRepository _repository;
        private readonly IMapper _mapper;

        public SubSistemasService(ISubSistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<SubSistemasModel> CreateSubSistemas(SubSistemasModel model, string userName)
        {
            var result = _mapper.Map<SubSistemas>(model);
            await _repository.AddAsync(result, userName);
            model.IdSubSistemas = result.IdSubSistemas;
            return model;
        }

        public async Task<List<SubSistemasModel>> ReadSubSistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SubSistemasModel>>(data);

            return result;
        }

        public async Task UpdateSubSistemas(SubSistemasModel model, string userName)
        {
            var result = _mapper.Map<SubSistemas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteSubSistemas(string id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<SubSistemasModel> ReadSubSistemas(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<SubSistemasModel>(model);
            return result;
        }

        #endregion
    }
}