namespace ThaiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleDateFormCustomers : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Date", c => c.DateTime(nullable: false));
        }
    }
}
