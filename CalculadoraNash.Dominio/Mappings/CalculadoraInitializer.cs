using CalculadoraNash.Dominio.Entities;
using System;
using System.Collections.Generic;

namespace CalculadoraNash.Dominio.Mappings
{
    public class CalculadoraInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CalculadoraContext>
    {
        protected override void Seed(CalculadoraContext context)
        {
            var pacientes = new List<Paciente>
            {
                new Paciente { Nome = "Jovelino" },
                new Paciente { Nome = "Jubilane" },
                new Paciente { Nome = "Tobias" }
            };

            pacientes.ForEach(p => context.Pacientes.Add(p));
            context.SaveChanges();

            var pacienesDados = new List<PacienteDados>
            {
                new PacienteDados
                {
                    Idade = 32,
                    AST = 300,
                    ALT = 300,
                    IMC = 26,
                    Plaquetas = 200,
                    Albumina = 300,
                    Diabetico = true,
                    DataAfericao = DateTime.Now
                },

                new PacienteDados
                {
                    Idade = 42,
                    AST = 300,
                    ALT = 300,
                    IMC = 22,
                    Plaquetas = 200,
                    Albumina = 300,
                    Diabetico = false,
                    DataAfericao = DateTime.Now
                },

                new PacienteDados
                {
                    Idade = 51,
                    AST = 400,
                    ALT = 300,
                    IMC = 23,
                    Plaquetas = 200,
                    Albumina = 300,
                    Diabetico = false,
                    DataAfericao = DateTime.Now
                }
            };

            pacienesDados.ForEach(d => context.PacientesDados.Add(d));
            context.SaveChanges();
        }
    }
}
