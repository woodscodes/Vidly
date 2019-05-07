namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreType) VALUES ('Action')");
            Sql("INSERT INTO Genres (GenreType) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (GenreType) VALUES ('Drama')");
            Sql("INSERT INTO Genres (GenreType) VALUES ('Horror')");
            Sql("INSERT INTO Genres (GenreType) VALUES ('Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
