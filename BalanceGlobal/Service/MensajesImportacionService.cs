
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IMensajesImportacionService
    {
        Task<MensajesImportacionModel> CreateMensajesImportacion(MensajesImportacionModel MensajesImportacionModel);
        Task<List<MensajesImportacionModel>> ReadMensajesImportacion();
        Task UpdateMensajesImportacion(MensajesImportacionModel MensajesImportacionModel);
        Task DeleteMensajesImportacion(string id);
        Task<MensajesImportacionModel> ReadMensajesImportacion(string id);
    }
    public class MensajesImportacionService : IMensajesImportacionService
    {
        private readonly IMensajesImportacionRepository _repository;
        private readonly IMapper _mapper;

        public MensajesImportacionService(IMensajesImportacionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<MensajesImportacionModel> CreateMensajesImportacion(MensajesImportacionModel model)
        {
            var result = _mapper.Map<MensajesImportacion>(model);
            await _repository.AddAsync(result);
            model.IdMensajesImportacion = result.IdMensajesImportacion;
            return model;
        }

        public async Task<List<MensajesImportacionModel>> ReadMensajesImportacion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<MensajesImportacionModel>>(data);

            return result;
        }

        public async Task UpdateMensajesImportacion(MensajesImportacionModel model)
        {
            var result = _mapper.Map<MensajesImportacion>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteMensajesImportacion(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<MensajesImportacionModel> ReadMensajesImportacion(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<MensajesImportacionModel>(model);
            return result;
        }

        #endregion
    }
}