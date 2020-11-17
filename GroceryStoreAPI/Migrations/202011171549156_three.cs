namespace GroceryStoreAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class three : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Recipe");
            AddColumn("dbo.Ingredients", "Recipe_RecipeNum", c => c.String(maxLength: 128));
            AlterColumn("dbo.Recipe", "RecipeNum", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Recipe", "RecipeNum");
            CreateIndex("dbo.Ingredients", "Recipe_RecipeNum");
            AddForeignKey("dbo.Ingredients", "Recipe_RecipeNum", "dbo.Recipe", "RecipeNum");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "Recipe_RecipeNum", "dbo.Recipe");
            DropIndex("dbo.Ingredients", new[] { "Recipe_RecipeNum" });
            DropPrimaryKey("dbo.Recipe");
            AlterColumn("dbo.Recipe", "RecipeNum", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Ingredients", "Recipe_RecipeNum");
            AddPrimaryKey("dbo.Recipe", "RecipeNum");
        }
    }
}
