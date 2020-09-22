using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IMensajesImportacionService
    {
        Task CreateMensajesImportacion(MensajesImportacionEntity MensajesImportacionEntity);
        Task<List<MensajesImportacionEntity>> ReadMensajesImportacion();
        Task UpdateMensajesImportacion(MensajesImportacionEntity MensajesImportacionEntity);
        Task DeleteMensajesImportacion(string id);
        Task<MensajesImportacionEntity> ReadMensajesImportacion(string id);
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

        public async Task CreateMensajesImportacion(MensajesImportacionEntity entity)
        {
            var result = _mapper.Map<MensajesImportacion>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<MensajesImportacionEntity>> ReadMensajesImportacion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<MensajesImportacionEntity>>(data);

            return result;
        }

        public async Task UpdateMensajesImportacion(MensajesImportacionEntity entity)
        {
            var result = _mapper.Map<MensajesImportacion>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteMensajesImportacion(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<MensajesImportacionEntity> ReadMensajesImportacion(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<MensajesImportacionEntity>(entity);
            return result;
        }

        #endregion
    }
}