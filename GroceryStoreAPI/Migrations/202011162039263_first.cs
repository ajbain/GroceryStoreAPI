namespace GroceryStoreAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Ingredients");
            AddColumn("dbo.Ingredients", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Ingredients", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Ingredients", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Ingredients");
            AlterColumn("dbo.Ingredients", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Ingredients", "Id");
            AddPrimaryKey("dbo.Ingredients", "Name");
        }
    }
}
