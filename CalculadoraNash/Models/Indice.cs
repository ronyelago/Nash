using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraNash.Models
{
    public class Indice
    {
        public Paciente Paciente { get; set; }

        public int PacienteId { get; set; }

        public string Calculo { get; set; }

        public double Score { get; set; }

        public string Observacao { get; set; }

        public string Estagio { get; set; }

        public static double CalculaFib4(DadosPaciente dp)
        {
            return Math.Round((dp.Idade * dp.AST) / ((dp.Plaquetas) * Math.Sqrt(dp.ALT)), 2);
        }

        public static double CalculaBard(DadosPaciente dp)
        {
            double bard = 0;

            if (dp.IMC >= 28)
            {
                bard += 1;
            }

            if (dp.AST / dp.ALT >= 0.8)
            {
                bard += 2;
            }

            if (dp.Diabetico)
            {
                bard += 1;
            }

            return bard;
        }

        public static double CalculaNafld(DadosPaciente dp)
        {
            int d = dp.Diabetico ? 1 : 0;
            
            double n1 = 0.037 * dp.Idade;
            double n2 = 0.094 * dp.IMC;
            double n3 = 1.13 * d;
            double n4 = 0.99 * (dp.AST / dp.ALT);
            double n5 = 0.013 * dp.Plaquetas;
            double n6 = 0.066 * dp.Albumina;

            return Math.Round((n1 + n2 + n3 + n4 - n5 - n6 - 1.675), 2);
        }
    }
}