using AutoMapper;
using CalculadoraNash.Dominio.Entities;
using CalculadoraNash.ViewModels;

namespace CalculadoraNash.Mappings
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