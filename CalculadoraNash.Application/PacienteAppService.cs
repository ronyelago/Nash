using CalculadoraNash.Application.Interfaces;
using CalculadoraNash.Domain.Entities;
using CalculadoraNash.Domain.Interfaces.Services;

namespace CalculadoraNash.Application
{
    public class PacienteAppService : AppServiceBase<Paciente>, IPacienteAppService
    {
        private readonly IPacienteService _pacienteService;

        public PacienteAppService(IPacienteService pacienteService) : base(pacienteService)
        {
            _pacienteService = pacienteService; 
        }
    }
}
