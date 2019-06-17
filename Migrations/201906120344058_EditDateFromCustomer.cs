namespace ThaiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDateFromCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Date", c => c.DateTime(nullable: false));
        }
    }
}
