namespace CalculadoraNash.ViewModels
{
    public class PacienteViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public double AST { get; set; }

        public double ALT { get; set; }

        public double IMC { get; set; }
        
        public double Plaquetas { get; set; }

        public double Albumina { get; set; }

        public bool Diabetico { get; set; }
    }
}