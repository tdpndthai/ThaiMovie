namespace ThaiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToCustomerAndDeleDateFromMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.MembershipTypes", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "Date");
        }
    }
}
