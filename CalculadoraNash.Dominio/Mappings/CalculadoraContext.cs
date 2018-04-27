using CalculadoraNash.Dominio.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CalculadoraNash.Dominio.Mappings
{
    public class CalculadoraContext : DbContext
    {
        // Construtor vazio
        public CalculadoraContext() : base("CalculadoraContext") { }

        //This code creates a DbSet property for each entity set.In Entity Framework terminology, an entity set typically corresponds
        //to a database table, and an entity corresponds to a row in the table.
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PacienteDados> PacientesDados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
