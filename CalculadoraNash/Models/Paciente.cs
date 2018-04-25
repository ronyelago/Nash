using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraNash.Models
{
    public class Paciente
    {
        public Paciente()
        {
            Indices = new List<Indice>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public DadosPaciente DadosPaciente { get; set; }

        public List<Indice> Indices { get; set; }
    }
}