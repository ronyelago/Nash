using CalculadoraNash.Domain.Entities;
using CalculadoraNash.Domain.Interfaces.Repositories;
using CalculadoraNash.Domain.Interfaces.Services;

namespace CalculadoraNash.Domain.Services
{
    public class PacienteDadosServices : ServiceBase<PacienteDados>, IPacienteDadosService
    {
        private readonly IPacienteDadosRepository _pacienteDadosRepository;

        public PacienteDadosServices(IPacienteDadosRepository pacienteDadosrepository) : base(pacienteDadosrepository)
        {
            _pacienteDadosRepository = pacienteDadosrepository;
        }
    }
}
