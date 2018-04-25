using System;
using CalculadoraNash.Models;

namespace CalculadoraNash.Dominio.Entidades.Indices
{
    public class IndiceApri : IIndice
    {
        public string Nome => "Nafld";

        public double Score(Paciente paciente)
        {
            return Math.Round((paciente.AST / 35) * 100 / (paciente.Plaquetas) * 100) / 100;
        }
    }
}
