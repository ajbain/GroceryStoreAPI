namespace GroceryStoreAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        RecipeNum = c.String(nullable: false, maxLength: 128),
                        RecipeName = c.String(nullable: false),
                        Directions = c.String(),
                        dietType = c.Int(nullable: false),
                        hasDietTypeOptions = c.Boolean(nullable: false),
                        TimeToPrepare = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecipeNum);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfTransaction = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transaction");
            DropTable("dbo.Recipe");
        }
    }
}
