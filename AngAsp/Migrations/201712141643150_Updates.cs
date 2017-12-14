namespace AngAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FModels");
        }
    }
}
