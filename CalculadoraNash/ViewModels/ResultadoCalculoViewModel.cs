namespace CalculadoraNash.ViewModels
{
    public class ResultadoCalculoViewModel
    {
        public ResultadoCalculoViewModel(string nomeIndice, double score)
        {
            NomeIndice = nomeIndice;
            Score = score;
        }

        public string NomeIndice { get; private set; }
        public double Score { get; private set; }
    }
}