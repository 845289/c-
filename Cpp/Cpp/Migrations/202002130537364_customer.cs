namespace Cpp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productname = c.String(nullable: false, maxLength: 128),
                        productid = c.Int(nullable: false),
                        productcost = c.Double(nullable: false),
                        cutomer_name = c.String(),
                        cid = c.String(),
                        purchase = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        customer_productname = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.productname)
                .ForeignKey("dbo.Products", t => t.customer_productname)
                .Index(t => t.customer_productname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "customer_productname", "dbo.Products");
            DropIndex("dbo.Products", new[] { "customer_productname" });
            DropTable("dbo.Products");
        }
    }
}
