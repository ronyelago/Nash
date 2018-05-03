namespace CalculadoraNash.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        PacienteDados_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PacienteDados", t => t.PacienteDados_Id)
                .Index(t => t.PacienteDados_Id);
            
            CreateTable(
                "dbo.PacienteDados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PacienteId = c.Int(nullable: false),
                        Idade = c.Int(nullable: false),
                        AST = c.Double(nullable: false),
                        ALT = c.Double(nullable: false),
                        IMC = c.Double(nullable: false),
                        Plaquetas = c.Double(nullable: false),
                        Albumina = c.Double(nullable: false),
                        Diabetico = c.Boolean(nullable: false),
                        DataAfericao = c.DateTime(nullable: false),
                        Paciente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paciente", t => t.PacienteId, cascadeDelete: true)
                .ForeignKey("dbo.Paciente", t => t.Paciente_Id)
                .Index(t => t.PacienteId)
                .Index(t => t.Paciente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paciente", "PacienteDados_Id", "dbo.PacienteDados");
            DropForeignKey("dbo.PacienteDados", "Paciente_Id", "dbo.Paciente");
            DropForeignKey("dbo.PacienteDados", "PacienteId", "dbo.Paciente");
            DropIndex("dbo.PacienteDados", new[] { "Paciente_Id" });
            DropIndex("dbo.PacienteDados", new[] { "PacienteId" });
            DropIndex("dbo.Paciente", new[] { "PacienteDados_Id" });
            DropTable("dbo.PacienteDados");
            DropTable("dbo.Paciente");
        }
    }
}
