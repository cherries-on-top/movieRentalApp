namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewPropertiesToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Released", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddedToDatabase", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Stock", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "Stock");
            DropColumn("dbo.Movies", "AddedToDatabase");
            DropColumn("dbo.Movies", "Released");
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
