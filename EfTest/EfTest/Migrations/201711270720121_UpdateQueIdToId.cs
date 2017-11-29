namespace EfTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQueIdToId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Ques");
            AddColumn("dbo.Ques", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Ques", "Id");
            DropColumn("dbo.Ques", "QueId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ques", "QueId", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.Ques");
            DropColumn("dbo.Ques", "Id");
            AddPrimaryKey("dbo.Ques", "QueId");
        }
    }
}
