namespace ThaiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Date='06/12/2019' where Id=1");
            Sql("update MembershipTypes set Date='05/12/2019' where Id=2");
            Sql("update MembershipTypes set Date='04/12/2019' where Id=3");
            Sql("update MembershipTypes set Date='03/12/2019' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
