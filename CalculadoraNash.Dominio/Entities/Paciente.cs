using System.Collections.Generic;

namespace CalculadoraNash.Dominio.Entities
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public PacienteDados PacienteDados { get; set; }

        public List<PacienteDados> ListaPacienteDados { get; set; }
    }
}