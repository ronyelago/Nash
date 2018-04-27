using System.Collections.Generic;

namespace CalculadoraNash.Dominio.Entities
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual PacienteDados PacienteDados { get; set; }

        public virtual List<PacienteDados> ListaPacienteDados { get; set; }
    }
}