using System;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceFib4 : IIndice
    {
        public string Titulo => "Fib4";

        public double GetScore(Paciente paciente)
        {
            return Math.Round((paciente.Idade * paciente.AST) / ((paciente.Plaquetas) * Math.Sqrt(paciente.ALT)), 2);
        }
    }
}
