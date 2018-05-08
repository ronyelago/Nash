using System.Linq;

namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceBard : IIndice
    {
        public IndiceBard(PacienteDados pacienteDados)
        {
            Score = GetScore(pacienteDados);
        }
        public double Score { get; set; }

        public string Titulo => "Bard";

        public double GetScore(PacienteDados pacienteDados)
        {
            double bard = 0;

            if (pacienteDados.IMC >= 28)
            {
                bard += 1;
            }

            if (pacienteDados.AST / pacienteDados.ALT >= 0.8)
            {
                bard += 2;
            }

            if (pacienteDados.Diabetico)
            {
                bard += 1;
            }

            return bard;
        }
    }
}
