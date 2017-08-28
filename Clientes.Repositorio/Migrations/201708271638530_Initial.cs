namespace Clientes.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Guid(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        ContaID = c.Guid(nullable: false, identity: true),
                        Agencia = c.Int(nullable: false),
                        NumeroConta = c.Int(nullable: false),
                        TipoConta = c.Int(nullable: false),
                        Saldo = c.Double(nullable: false),
                        ClienteID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ContaID)
                .ForeignKey("dbo.Clientes", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contas", "ClienteID", "dbo.Clientes");
            DropIndex("dbo.Contas", new[] { "ClienteID" });
            DropTable("dbo.Contas");
            DropTable("dbo.Clientes");
        }
    }
}
