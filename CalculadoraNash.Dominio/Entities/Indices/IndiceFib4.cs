using System;
using CalculadoraNash.Models;

namespace CalculadoraNash.Dominio.Entidades.Indices
{
    public class IndiceFib4 : IIndice
    {
        public string Nome => "Fib4";

        public double Score(Paciente paciente)
        {
            return Math.Round((paciente.Idade * paciente.AST) / ((paciente.Plaquetas) * Math.Sqrt(paciente.ALT)), 2);
        }
    }
}
