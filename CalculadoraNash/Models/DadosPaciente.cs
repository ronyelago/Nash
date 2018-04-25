using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraNash.Models
{
    public class DadosPaciente
    {
        public Paciente Paciente { get; set; }

        public int PacienteId { get; set; }

        public double AST { get; set; }

        public double ALT { get; set; }

        public double IMC { get; set; }

        public int Idade { get; set; }

        public double Plaquetas { get; set; }

        public double Albumina { get; set; }

        public bool Diabetico { get; set; }
    }
}