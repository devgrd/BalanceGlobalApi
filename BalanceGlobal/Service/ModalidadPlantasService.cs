
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IModalidadPlantasService
    {
        Task<ModalidadPlantasModel> CreateModalidadPlantas(ModalidadPlantasModel ModalidadPlantasModel, string userName);
        Task<List<ModalidadPlantasModel>> ReadModalidadPlantas();
        Task UpdateModalidadPlantas(ModalidadPlantasModel ModalidadPlantasModel, string userName);
        Task DeleteModalidadPlantas(int id, string userName);
        Task<ModalidadPlantasModel> ReadModalidadPlantas(int id);
    }
    public class ModalidadPlantasService : IModalidadPlantasService
    {
        private readonly IModalidadPlantasRepository _repository;
        private readonly IMapper _mapper;

        public ModalidadPlantasService(IModalidadPlantasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ModalidadPlantasModel> CreateModalidadPlantas(ModalidadPlantasModel model, string userName)
        {
            var result = _mapper.Map<ModalidadPlantas>(model);
            await _repository.AddAsync(result, userName);
            model.IdModalidadPlantas = result.IdModalidadPlantas;
            return model;
        }

        public async Task<List<ModalidadPlantasModel>> ReadModalidadPlantas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ModalidadPlantasModel>>(data);

            return result;
        }

        public async Task UpdateModalidadPlantas(ModalidadPlantasModel model, string userName)
        {
            var result = _mapper.Map<ModalidadPlantas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteModalidadPlantas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ModalidadPlantasModel> ReadModalidadPlantas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ModalidadPlantasModel>(model);
            return result;
        }

        #endregion
    }
}