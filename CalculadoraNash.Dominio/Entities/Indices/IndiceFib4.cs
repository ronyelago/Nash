using System;
using System.Linq;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceFib4 : IIndice
    {
        public IndiceFib4(PacienteDados pacienteDados)
        {
            Score = GetScore(pacienteDados);
        }
        public double Score { get; set; }

        public string Titulo => "Fib4";

        public double GetScore(PacienteDados pacienteDados)
        {
            return Math.Round((pacienteDados.Idade * pacienteDados.AST) / ((pacienteDados.Plaquetas) * Math.Sqrt(pacienteDados.ALT)), 2);
        }
    }
}
