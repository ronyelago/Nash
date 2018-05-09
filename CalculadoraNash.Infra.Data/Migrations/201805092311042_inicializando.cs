namespace CalculadoraNash.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicializando : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paciente", t => t.PacienteId)
                .Index(t => t.PacienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PacienteDados", "PacienteId", "dbo.Paciente");
            DropIndex("dbo.PacienteDados", new[] { "PacienteId" });
            DropTable("dbo.PacienteDados");
            DropTable("dbo.Paciente");
        }
    }
}
