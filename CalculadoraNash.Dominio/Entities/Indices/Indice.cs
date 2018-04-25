namespace CalculadoraNash.Models
{
    public interface IIndice
    {
        string Nome { get; }
        double Score(Paciente dadosPaciente);
    }
}