
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IModalidadPciService
    {
        Task<ModalidadPciModel> CreateModalidadPci(ModalidadPciModel ModalidadPciModel, string userName);
        Task<List<ModalidadPciModel>> ReadModalidadPci();
        Task UpdateModalidadPci(ModalidadPciModel ModalidadPciModel, string userName);
        Task DeleteModalidadPci(int id, string userName);
        Task<ModalidadPciModel> ReadModalidadPci(int id);
    }
    public class ModalidadPciService : IModalidadPciService
    {
        private readonly IModalidadPciRepository _repository;
        private readonly IMapper _mapper;

        public ModalidadPciService(IModalidadPciRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ModalidadPciModel> CreateModalidadPci(ModalidadPciModel model, string userName)
        {
            var result = _mapper.Map<ModalidadPci>(model);
            await _repository.AddAsync(result, userName);
            model.IdModalidadPci = result.IdModalidadPci;
            return model;
        }

        public async Task<List<ModalidadPciModel>> ReadModalidadPci()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ModalidadPciModel>>(data);

            return result;
        }

        public async Task UpdateModalidadPci(ModalidadPciModel model, string userName)
        {
            var result = _mapper.Map<ModalidadPci>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteModalidadPci(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ModalidadPciModel> ReadModalidadPci(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ModalidadPciModel>(model);
            return result;
        }

        #endregion
    }
}