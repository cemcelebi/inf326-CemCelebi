namespace APIcem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crossTableUyumlu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Cart_Id", "dbo.Carts");
            DropForeignKey("dbo.Carts", "UserId", "dbo.Users");
            DropIndex("dbo.Carts", new[] { "UserId" });
            DropIndex("dbo.Products", new[] { "Cart_Id" });
            RenameColumn(table: "dbo.Carts", name: "UserId", newName: "User_Id");
            CreateTable(
                "dbo.inCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartId = c.Int(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carts", t => t.CartId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.CartId)
                .Index(t => t.Product_Id);
            
            AddColumn("dbo.Carts", "dateOfCreation", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Carts", "User_Id", c => c.Int());
            CreateIndex("dbo.Carts", "User_Id");
            AddForeignKey("dbo.Carts", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.Products", "Cart_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Cart_Id", c => c.Int());
            DropForeignKey("dbo.Carts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.inCarts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.inCarts", "CartId", "dbo.Carts");
            DropIndex("dbo.inCarts", new[] { "Product_Id" });
            DropIndex("dbo.inCarts", new[] { "CartId" });
            DropIndex("dbo.Carts", new[] { "User_Id" });
            AlterColumn("dbo.Carts", "User_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Carts", "dateOfCreation");
            DropTable("dbo.inCarts");
            RenameColumn(table: "dbo.Carts", name: "User_Id", newName: "UserId");
            CreateIndex("dbo.Products", "Cart_Id");
            CreateIndex("dbo.Carts", "UserId");
            AddForeignKey("dbo.Carts", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "Cart_Id", "dbo.Carts", "Id");
        }
    }
}
