namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceBard : IIndice
    {
        public string Titulo => "Bard";

        public double GetScore(Paciente paciente)
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
