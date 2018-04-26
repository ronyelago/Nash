using System;
using CalculadoraNash.Dominio.Entities;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceNafld : IIndice
    {
        public string Titulo => "Nafld";

        public double GetScore(Paciente paciente)
        {
            int d = paciente.Diabetico ? 1 : 0;

            double n1 = 0.037 * paciente.Idade;
            double n2 = 0.094 * paciente.IMC;
            double n3 = 1.13 * d;
            double n4 = 0.99 * (paciente.AST / paciente.ALT);
            double n5 = 0.013 * paciente.Plaquetas;
            double n6 = 0.066 * paciente.Albumina;

            return Math.Round((n1 + n2 + n3 + n4 - n5 - n6 - 1.675), 2);
        }
    }
}
