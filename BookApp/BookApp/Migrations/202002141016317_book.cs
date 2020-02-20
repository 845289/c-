namespace BookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class book : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        Aid = c.Int(nullable: false, identity: true),
                        Aname = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Aid);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        price = c.Double(nullable: false),
                        Aid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bid)
                .ForeignKey("dbo.Author", t => t.Aid, cascadeDelete: true)
                .Index(t => t.Aid);
            
            CreateTable(
                "dbo.Detail",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Aid = c.Int(nullable: false),
                        bid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Author", t => t.Aid, cascadeDelete: true)
                .ForeignKey("dbo.Book", t => t.bid, cascadeDelete: true)
                .Index(t => t.Aid)
                .Index(t => t.bid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detail", "bid", "dbo.Book");
            DropForeignKey("dbo.Detail", "Aid", "dbo.Author");
            DropForeignKey("dbo.Book", "Aid", "dbo.Author");
            DropIndex("dbo.Detail", new[] { "bid" });
            DropIndex("dbo.Detail", new[] { "Aid" });
            DropIndex("dbo.Book", new[] { "Aid" });
            DropTable("dbo.Detail");
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}
