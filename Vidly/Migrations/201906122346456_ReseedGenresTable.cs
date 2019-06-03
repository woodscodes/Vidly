namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReseedGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Genres SET Name = 'Action' WHERE id = 1");
            Sql("UPDATE Genres SET Name = 'Comedy' WHERE id = 2");
            Sql("UPDATE Genres SET Name = 'Drama' WHERE id = 3");
            Sql("UPDATE Genres SET Name = 'Horror' WHERE id = 4");
            Sql("UPDATE Genres SET Name = 'Thriller' WHERE id = 5");

        }
        
        public override void Down()
        {
        }
    }
}
