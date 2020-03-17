namespace movie_mvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Mid = c.Int(nullable: false, identity: true),
                        Mname = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        Theatre_Tid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Mid)
                .ForeignKey("dbo.Theatres", t => t.Theatre_Tid, cascadeDelete: true)
                .Index(t => t.Theatre_Tid);
            
            CreateTable(
                "dbo.Theatres",
                c => new
                    {
                        Tid = c.Int(nullable: false, identity: true),
                        Tname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Tid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Theatre_Tid", "dbo.Theatres");
            DropIndex("dbo.Movies", new[] { "Theatre_Tid" });
            DropTable("dbo.Theatres");
            DropTable("dbo.Movies");
        }
    }
}
