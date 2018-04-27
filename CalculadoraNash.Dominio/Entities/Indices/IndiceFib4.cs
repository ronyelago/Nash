using System;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceFib4 : IIndice
    {
        public IndiceFib4(Paciente paciente)
        {
            this.Paciente = paciente;
        }

        public int Id { get; set; }

        public Paciente Paciente { get; set; }

        public int PacienteId { get; set; }

        public double Score
        {
            get { return GetScore(Paciente.PacienteDados); }
        }

        public string Titulo => "Fib4";

        public double GetScore(PacienteDados pacienteDados)
        {
            return Math.Round((pacienteDados.Idade * pacienteDados.AST) / ((pacienteDados.Plaquetas) * Math.Sqrt(pacienteDados.ALT)), 2);
        }
    }
}
