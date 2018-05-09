using CalculadoraNash.Dominio.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace CalculadoraNash.Dominio.Mappings
{
    public class CalculadoraContext : DbContext
    {
        public CalculadoraContext() : base("CalculadoraDB") { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PacienteDados> PacientesDados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataAfericao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataAfericao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAfericao").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
