namespace ThaiMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name='Monthly' where Id=1");
            Sql("update MembershipTypes set Name='PayAsYouGo' where Id=2");
            Sql("update MembershipTypes set Name='Monthly1' where Id=3");
            Sql("update MembershipTypes set Name='Monthly2' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
