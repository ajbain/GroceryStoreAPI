namespace GroceryStoreAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transaction", "IngredientID", c => c.Int(nullable: false));
            CreateIndex("dbo.Transaction", "IngredientID");
            AddForeignKey("dbo.Transaction", "IngredientID", "dbo.Ingredients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaction", "IngredientID", "dbo.Ingredients");
            DropIndex("dbo.Transaction", new[] { "IngredientID" });
            DropColumn("dbo.Transaction", "IngredientID");
        }
    }
}
