using BalanceGlobal.Database.Tables;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{
    public interface IService
    {
        Task<IEnumerable<Periodos>> GetPeriodos();
        Task<IEnumerable<Sistemas>> GetSistemas();
        Task<IEnumerable<Subsistemas>> GetSubSistemas();


    }
    public class Service : IService
    {
        private readonly IPeriodoRepository _periodoRepository;
        private readonly ISistemasRepository _sistemasRepository;
        private readonly ISubSistemasRepository _subSistemasRepository;

        public Service(
            IPeriodoRepository periodoReposirory,
            ISistemasRepository sistemasRepository,
            ISubSistemasRepository subSistemasRepository
            )
        {
            _periodoRepository = periodoReposirory;
            _sistemasRepository = sistemasRepository;
            _subSistemasRepository = subSistemasRepository;
        }

        public async Task<IEnumerable<Periodos>> GetPeriodos()
        {
            return await _periodoRepository.GetAllAsync();
        }
        public async Task DeletePeriodos(object id)
        {
             await _periodoRepository.RemoveAsync(id);
        }
        public async Task UpdatePeriodos(Periodos periodos)
        {
            await _periodoRepository.UpdateAsync(periodos);
        }
        public async Task CreatePeriodos(Periodos periodos)
        {
            await _periodoRepository.AddAsync(periodos);
        }

        public async Task<IEnumerable<Sistemas>> GetSistemas()
        {
            return await _sistemasRepository.GetAllAsync();
        }

        public async Task DeleteSistemas(object id)
        {
            await _sistemasRepository.RemoveAsync(id);
        }
        public async Task UpdateSistemas(Sistemas sistemas)
        {
            await _sistemasRepository.UpdateAsync(sistemas);
        }
        public async Task CreateSistemas(Sistemas sistemas)
        {
            await _sistemasRepository.AddAsync(sistemas);
        }

        public async Task<IEnumerable<Subsistemas>> GetSubSistemas()
        {
            return await _subSistemasRepository.GetAllAsync();
        }

        public async Task DeleteSubSistemas(object id)
        {
            await _subSistemasRepository.RemoveAsync(id);
        }
        public async Task UpdateSubSistemas(Subsistemas subSistemas)
        {
            await _subSistemasRepository.UpdateAsync(subSistemas);
        }
        public async Task CreateSubSistemas(Subsistemas subSistemas)
        {
            await _subSistemasRepository.AddAsync(subSistemas);
        }
    }
}
