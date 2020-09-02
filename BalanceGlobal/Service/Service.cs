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

        public async Task<IEnumerable<Sistemas>> GetSistemas()
        {
            return await _sistemasRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Subsistemas>> GetSubSistemas()
        {
            return await _subSistemasRepository.GetAllAsync();
        }
    }
}
