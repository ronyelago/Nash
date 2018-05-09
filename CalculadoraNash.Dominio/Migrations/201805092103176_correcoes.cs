namespace CalculadoraNash.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcoes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PacienteDados", "PacienteId", "dbo.Paciente");
            AddForeignKey("dbo.PacienteDados", "PacienteId", "dbo.Paciente", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PacienteDados", "PacienteId", "dbo.Paciente");
            AddForeignKey("dbo.PacienteDados", "PacienteId", "dbo.Paciente", "Id", cascadeDelete: true);
        }
    }
}
