using System;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceApri : IIndice
    {
        public string Titulo => "Nafld";

        public double GetScore(Paciente paciente)
        {
            return Math.Round((paciente.AST / 35) * 100 / (paciente.Plaquetas) * 100) / 100;
        }
    }
}
