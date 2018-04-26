namespace CalculadoraNash.Dominio.Entities.Indices
{
    public interface IIndice
    {
        int Id { get; set; }
        Paciente Paciente { get; set; }
        int PacienteId { get; set; }
        string Titulo { get; }
        double GetScore(PacienteDados pacienteDados);
    }
}