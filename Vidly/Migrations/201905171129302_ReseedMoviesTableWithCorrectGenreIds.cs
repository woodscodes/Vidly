namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReseedMoviesTableWithCorrectGenreIds : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreId = 2 WHERE Id = 4");
            Sql("UPDATE Movies SET GenreId = 5 WHERE Id = 5");
            Sql("UPDATE Movies SET GenreId = 4 WHERE Id = 6");
            Sql("UPDATE Movies SET GenreId = 1 WHERE Id = 7");
        }
        
        public override void Down()
        {
        }
    }
}
