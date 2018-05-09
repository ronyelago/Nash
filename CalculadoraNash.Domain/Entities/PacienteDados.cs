using System;

namespace CalculadoraNash.Domain.Entities
{
    public class PacienteDados
    {
        public virtual Paciente Paciente { get; set; }

        public int PacienteId { get; set; }

        public int Id { get; set; }

        public int Idade { get; set; }

        public double AST { get; set; }

        public double ALT { get; set; }

        public double IMC { get; set; }

        public double Plaquetas { get; set; }

        public double Albumina { get; set; }

        public bool Diabetico { get; set; }

        public DateTime DataAfericao { get; set; }
    }
}
