namespace ThaiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Date");
        }
    }
}
