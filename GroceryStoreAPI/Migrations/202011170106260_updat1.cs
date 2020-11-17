namespace GroceryStoreAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updat1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Transaction", new[] { "IngredientID" });
            CreateIndex("dbo.Transaction", "IngredientId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Transaction", new[] { "IngredientId" });
            CreateIndex("dbo.Transaction", "IngredientID");
        }
    }
}
