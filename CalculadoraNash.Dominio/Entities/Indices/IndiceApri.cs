using System;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceApri : IIndice
    {
        public IndiceApri(PacienteDados pacienteDados)
        {
            Score = GetScore(pacienteDados);
        }

        public string Titulo => "APRI";

        public double Score { get; set; }

        public double GetScore(PacienteDados pacienteDados)
        {
            return Math.Round((pacienteDados.AST / 35) * 100 / (pacienteDados.Plaquetas) * 100) / 100;
        }
    }
}
