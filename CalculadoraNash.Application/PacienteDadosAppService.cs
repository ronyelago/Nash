using CalculadoraNash.Application.Interfaces;
using CalculadoraNash.Domain.Entities;
using CalculadoraNash.Domain.Interfaces.Services;

namespace CalculadoraNash.Application
{
    public class PacienteDadosAppService : AppServiceBase<PacienteDados>, IPacienteDadosAppService
    {
        private readonly IPacienteDadosService _pacienteDadosService;

        public PacienteDadosAppService(IPacienteDadosService pacienteDadosService) : base(pacienteDadosService)
        {
            _pacienteDadosService = pacienteDadosService;
        }
    }
}
