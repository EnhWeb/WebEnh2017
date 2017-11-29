namespace EfTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdToQueId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Ques");
            AddColumn("dbo.Ques", "QueId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Ques", "QueId");
            DropColumn("dbo.Ques", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ques", "Id", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.Ques");
            DropColumn("dbo.Ques", "QueId");
            AddPrimaryKey("dbo.Ques", "Id");
        }
    }
}
