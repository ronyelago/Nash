namespace CalculadoraNash.Dominio.ValueObject
{
    public class ResultadoCalculo
    {
        public ResultadoCalculo(string nomeIndice, double score)
        {
            NomeIndice = nomeIndice;
            Score = score;
        }

        public string NomeIndice { get; private set; }
        public double Score { get; private set; }
    }
}
