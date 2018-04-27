using AutoMapper;
using CalculadoraNash.Dominio.Entities;
using CalculadoraNash.ViewModels;

namespace CalculadoraNash.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Paciente, PacienteViewModel>();
        }
    }
}