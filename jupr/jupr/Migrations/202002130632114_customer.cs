namespace jupr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        quality = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.productcustomers",
                c => new
                    {
                        product_id = c.Int(nullable: false),
                        customer_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.product_id, t.customer_id })
                .ForeignKey("dbo.products", t => t.product_id, cascadeDelete: true)
                .ForeignKey("dbo.customers", t => t.customer_id, cascadeDelete: true)
                .Index(t => t.product_id)
                .Index(t => t.customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.productcustomers", "customer_id", "dbo.customers");
            DropForeignKey("dbo.productcustomers", "product_id", "dbo.products");
            DropIndex("dbo.productcustomers", new[] { "customer_id" });
            DropIndex("dbo.productcustomers", new[] { "product_id" });
            DropTable("dbo.productcustomers");
            DropTable("dbo.products");
            DropTable("dbo.customers");
        }
    }
}
