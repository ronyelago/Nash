using CalculadoraNash.Domain.Entities;
using CalculadoraNash.Domain.Interfaces.Repositories;
using CalculadoraNash.Domain.Interfaces.Services;

namespace CalculadoraNash.Domain.Services
{
    public class PacienteService : ServiceBase<Paciente>, IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository) : base(pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
    }
}
