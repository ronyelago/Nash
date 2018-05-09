using System.Collections.Generic;

namespace CalculadoraNash.Domain.Entities
{
    public class Paciente
    {
        public Paciente()
        {
            ListaPacienteDados = new List<PacienteDados>();
        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<PacienteDados> ListaPacienteDados { get; set; }
    }
}