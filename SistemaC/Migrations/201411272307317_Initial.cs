namespace SistemaC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Acessos",
                c => new
                    {
                        AcessoId = c.Int(nullable: false, identity: true),
                        NivelAcessoId = c.Int(nullable: false),
                        Usuario = c.String(nullable: false),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.AcessoId)
                .ForeignKey("dbo.NiveisAcessos", t => t.NivelAcessoId, cascadeDelete: true)
                .Index(t => t.NivelAcessoId);
            
            CreateTable(
                "dbo.NiveisAcessos",
                c => new
                    {
                        NivelAcessoId = c.Int(nullable: false, identity: true),
                        Nivel = c.String(),
                    })
                .PrimaryKey(t => t.NivelAcessoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Acessos", "NivelAcessoId", "dbo.NiveisAcessos");
            DropIndex("dbo.Acessos", new[] { "NivelAcessoId" });
            DropTable("dbo.NiveisAcessos");
            DropTable("dbo.Acessos");
        }
    }
}
