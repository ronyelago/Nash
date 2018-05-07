namespace CalculadoraNash.ViewModels
{
    public class PacienteViewModel
    {
        public PacienteViewModel()
        {
            PacienteDados = new PacienteDadosViewModel();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public PacienteDadosViewModel PacienteDados { get; set; }

        public bool Calculado { get; set; }
    }
}