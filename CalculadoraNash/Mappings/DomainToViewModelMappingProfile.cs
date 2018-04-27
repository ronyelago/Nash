using AutoMapper;
using CalculadoraNash.Dominio.Entities;
using CalculadoraNash.ViewModels;

namespace CalculadoraNash.Mappings
{

    /// <summary>
    /// Perfis de mapeamento de objetos "Domain" para objetos "ViewModel"
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Paciente, PacienteViewModel>();
        }
    }
}