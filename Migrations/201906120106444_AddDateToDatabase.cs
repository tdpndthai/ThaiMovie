namespace ThaiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set Date='06/12/2019' where Id=1");
            Sql("update Customers set Date='05/12/2019' where Id=2");
            Sql("update Customers set Date='04/12/2019' where Id=3");
            Sql("update Customers set Date='03/12/2019' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
