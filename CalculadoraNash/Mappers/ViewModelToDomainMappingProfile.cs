using AutoMapper;
using CalculadoraNash.Domain.Entities;
using CalculadoraNash.ViewModels;

namespace CalculadoraNash.Mappers
{
    /// <summary>
    /// Perfis de mapeamento de objetos "ViewModel" para objetos "Domain"
    /// </summary>
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PacienteViewModel, Paciente>();
        }
    }
}