namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Animated')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
