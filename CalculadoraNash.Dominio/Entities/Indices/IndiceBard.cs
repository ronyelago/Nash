namespace CalculadoraNash.Dominio.Entities.Indices
{
    public class IndiceBard : IIndice
    {
        public IndiceBard(Paciente paciente)
        {
            this.Paciente = paciente;
        }

        public int Id { get; set; }

        public Paciente Paciente { get; set; }

        public int PacienteId { get; set; }

        public double Score
        {
            get { return GetScore(Paciente.PacienteDados); }
        }

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
