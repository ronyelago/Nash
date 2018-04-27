using System;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceApri : IIndice
    {
        public IndiceApri(Paciente paciente)
        {
            this.Paciente = paciente;
        }

        public int Id { get; set; }

        public string Titulo => "APRI";

        public Paciente Paciente { get; set; }

        public int PacienteId { get; set; }

        public double Score
        {
            get { return GetScore(Paciente.PacienteDados); }
        }

        public double GetScore(PacienteDados pacienteDados)
        {
            return Math.Round((pacienteDados.AST / 35) * 100 / (pacienteDados.Plaquetas) * 100) / 100;
        }
    }
}
