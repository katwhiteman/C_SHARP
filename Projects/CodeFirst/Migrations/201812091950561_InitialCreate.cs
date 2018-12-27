namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groceries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Item = c.String(),
                        Groceries_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groceries", t => t.Groceries_Id)
                .Index(t => t.Groceries_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groceries", "Groceries_Id", "dbo.Groceries");
            DropIndex("dbo.Groceries", new[] { "Groceries_Id" });
            DropTable("dbo.Groceries");
        }
    }
}
