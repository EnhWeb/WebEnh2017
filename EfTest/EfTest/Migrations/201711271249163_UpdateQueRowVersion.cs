namespace EfTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQueRowVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ques", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ques", "RowVersion");
        }
    }
}
