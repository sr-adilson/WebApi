namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableMusica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Estilo = c.String(),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musicas");
        }
    }
}
