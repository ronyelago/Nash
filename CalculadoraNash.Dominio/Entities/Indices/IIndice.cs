namespace CalculadoraNash.Dominio.Entities.Indices
{
    public interface IIndice
    {
        string Titulo { get; }
        double GetScore(Paciente dadosPaciente);
    }
}