using CalculadoraNash.Dominio.Entities;

namespace CalculadoraNash.Dominio.ValueObject
{
    public class IndiceFibrose
    {
        public IndiceFibrose(Paciente paciente)
        {
            this.Paciente = paciente;
        }

        public int PacienteId { get; set; }

        public Paciente Paciente { get; set; }

        // F0, F1, F2, F3 ou F4
        public string Estagio { get; set; }

        // Risco Baixo, Risco Intermediário, Risco Alto
        public string DescricaoEstagio { get; set; }

        
    }
}
