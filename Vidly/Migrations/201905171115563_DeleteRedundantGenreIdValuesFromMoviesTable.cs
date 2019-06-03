namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRedundantGenreIdValuesFromMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre_Id = null");
        }
        
        public override void Down()
        {
        }
    }
}
