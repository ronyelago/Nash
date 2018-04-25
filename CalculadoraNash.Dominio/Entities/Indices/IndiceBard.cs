using System;
using CalculadoraNash.Models;

namespace CalculadoraNash.Dominio.Entidades.Indices
{
    public class IndiceBard : IIndice
    {
        public string Nome => "Bard";

        public double Score(Paciente paciente)
        {
            double bard = 0;

            if (paciente.IMC >= 28)
            {
                bard += 1;
            }

            if (paciente.AST / paciente.ALT >= 0.8)
            {
                bard += 2;
            }

            if (paciente.Diabetico)
            {
                bard += 1;
            }

            return bard;
        }
    }
}
