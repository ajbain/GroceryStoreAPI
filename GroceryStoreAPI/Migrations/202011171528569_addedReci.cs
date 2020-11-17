namespace GroceryStoreAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedReci : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Recipe");
            AddColumn("dbo.Ingredients", "Location", c => c.Int(nullable: false));
            AlterColumn("dbo.Recipe", "RecipeNum", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Recipe", "RecipeNum");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Recipe");
            AlterColumn("dbo.Recipe", "RecipeNum", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Ingredients", "Location");
            AddPrimaryKey("dbo.Recipe", "RecipeNum");
        }
    }
}
