using System.Collections.Generic;

namespace CalculadoraNash.ViewModels
{
    public class CalculadoraViewModel
    {
        public CalculadoraViewModel()
        {
            Resultados = new List<ResultadoCalculoViewModel>();
        }

        public PacienteViewModel Paciente { get; set; }
        public ICollection<ResultadoCalculoViewModel> Resultados { get; set; }
    }
}