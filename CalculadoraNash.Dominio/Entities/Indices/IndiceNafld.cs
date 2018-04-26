using System;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceNafld : IIndice
    {
        public IndiceNafld(Paciente paciente)
        {
            this.Paciente = paciente;
        }

        public int Id { get; set; }

        public Paciente Paciente { get; set; }

        public int PacienteId { get; set; }

        public string Titulo => "Nafld";

        public double GetScore(PacienteDados pacienteDados)
        {
            int d = pacienteDados.Diabetico ? 1 : 0;

            double n1 = 0.037 * pacienteDados.Idade;
            double n2 = 0.094 * pacienteDados.IMC;
            double n3 = 1.13 * d;
            double n4 = 0.99 * (pacienteDados.AST / pacienteDados.ALT);
            double n5 = 0.013 * pacienteDados.Plaquetas;
            double n6 = 0.066 * pacienteDados.Albumina;

            return Math.Round((n1 + n2 + n3 + n4 - n5 - n6 - 1.675), 2);
        }
    }
}
