namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMemebershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = (CASE WHEN Id=1 THEN 'PayAsYouGo' WHEN Id=2 THEN 'Monthly' WHEN Id=3 THEN 'Quarterly' WHEN Id=4 THEN 'Annual' END); ");
            
            // or
            //Sql("UPDATE MembershipTypes SET Name = 'PayAsYouGo' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
