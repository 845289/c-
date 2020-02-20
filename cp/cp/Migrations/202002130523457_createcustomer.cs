namespace cp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createcustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productid = c.Int(nullable: false, identity: true),
                        productname = c.String(),
                        pcost = c.Double(nullable: false),
                        customer_id = c.Int(),
                        customer_name = c.String(),
                        purchase = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        product_productid = c.Int(),
                    })
                .PrimaryKey(t => t.productid)
                .ForeignKey("dbo.Products", t => t.product_productid)
                .Index(t => t.product_productid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "product_productid", "dbo.Products");
            DropIndex("dbo.Products", new[] { "product_productid" });
            DropTable("dbo.Products");
        }
    }
}
