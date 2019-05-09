namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Shrek', '05-18-2001', '05-07-2019', 5, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('The Godfather', '03-24-1972', '05-07-2019', 5, 5)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('The Thing (1982)', '06-25-1982', '05-07-2019', 5, 4)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('The Raid', '03-23-2011', '05-07-2019', 5, 1)");

        }

        public override void Down()
        {
        }
    }
}
