namespace CalculadoraNash.Dominio.Entities.Indices
{
    public interface IIndice
    {
        string Titulo { get; }
        double Score { get; }
        double GetScore(PacienteDados pacienteDados);
    }
}