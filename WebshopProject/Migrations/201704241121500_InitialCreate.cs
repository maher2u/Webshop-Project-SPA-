namespace WebshopProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        status = c.String(),
                        customerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.customerID, cascadeDelete: true)
                .Index(t => t.customerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        password = c.String(),
                        firstname = c.String(),
                        lastname = c.String(),
                        gender = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        cartID = c.Int(nullable: false),
                        productID = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Carts", t => t.cartID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.productID, cascadeDelete: true)
                .Index(t => t.cartID)
                .Index(t => t.productID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        type = c.String(),
                        name = c.String(),
                        description = c.String(),
                        image = c.String(),
                        category = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "productID", "dbo.Products");
            DropForeignKey("dbo.Orders", "cartID", "dbo.Carts");
            DropForeignKey("dbo.Carts", "customerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "productID" });
            DropIndex("dbo.Orders", new[] { "cartID" });
            DropIndex("dbo.Carts", new[] { "customerID" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Carts");
        }
    }
}
