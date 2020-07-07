namespace Tasker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedItemTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Items", "ItemType_Id", c => c.Int());
            CreateIndex("dbo.Items", "ItemType_Id");
            AddForeignKey("dbo.Items", "ItemType_Id", "dbo.ItemTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ItemType_Id", "dbo.ItemTypes");
            DropIndex("dbo.Items", new[] { "ItemType_Id" });
            DropColumn("dbo.Items", "ItemType_Id");
            DropTable("dbo.ItemTypes");
        }
    }
}
