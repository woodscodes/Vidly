namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRedundantGenreIdFromMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("DROP INDEX IX_Genre_Id ON Movies");
        }
        
        public override void Down()
        {
        }
    }
}
