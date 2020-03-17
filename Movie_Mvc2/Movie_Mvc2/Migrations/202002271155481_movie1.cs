namespace Movie_Mvc2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movie1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Mid = c.Int(nullable: false, identity: true),
                        Mname = c.String(),
                        price = c.Double(nullable: false),
                        location = c.String(),
                    })
                .PrimaryKey(t => t.Mid);
            
            CreateTable(
                "dbo.Theatres",
                c => new
                    {
                        Tid = c.Int(nullable: false, identity: true),
                        theatre = c.String(),
                        Movie_Mid = c.Int(),
                    })
                .PrimaryKey(t => t.Tid)
                .ForeignKey("dbo.Movies", t => t.Movie_Mid)
                .Index(t => t.Movie_Mid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Theatres", "Movie_Mid", "dbo.Movies");
            DropIndex("dbo.Theatres", new[] { "Movie_Mid" });
            DropTable("dbo.Theatres");
            DropTable("dbo.Movies");
        }
    }
}
