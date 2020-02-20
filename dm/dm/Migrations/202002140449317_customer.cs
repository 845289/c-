namespace dm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.String(),
                        phno = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        pid = c.Int(nullable: false, identity: true),
                        pname = c.String(),
                        price = c.Double(nullable: false),
                        cid_cid = c.Int(),
                    })
                .PrimaryKey(t => t.pid)
                .ForeignKey("dbo.Customer", t => t.cid_cid)
                .Index(t => t.cid_cid);
            
            CreateTable(
                "dbo.Purchase",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        cid = c.Int(nullable: false),
                        pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customer", t => t.cid, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.pid, cascadeDelete: true)
                .Index(t => t.cid)
                .Index(t => t.pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchase", "pid", "dbo.Product");
            DropForeignKey("dbo.Purchase", "cid", "dbo.Customer");
            DropForeignKey("dbo.Product", "cid_cid", "dbo.Customer");
            DropIndex("dbo.Purchase", new[] { "pid" });
            DropIndex("dbo.Purchase", new[] { "cid" });
            DropIndex("dbo.Product", new[] { "cid_cid" });
            DropTable("dbo.Purchase");
            DropTable("dbo.Product");
            DropTable("dbo.Customer");
        }
    }
}
