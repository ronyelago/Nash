using CalculadoraNash.Dominio.Entities;

namespace CalculadoraNash.Dominio.ValueObject
{
    public class ScoreFibrose
    {
        public ScoreFibrose(string nomeIndice, double score)
        {
            NomeIndice = nomeIndice;
            Score = score;
        }

        public Paciente MyProperty { get; set; }

        public string NomeIndice { get; private set; }
        public double Score { get; private set; }
    }
}
