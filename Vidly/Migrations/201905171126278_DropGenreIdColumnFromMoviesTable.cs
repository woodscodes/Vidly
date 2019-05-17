namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropGenreIdColumnFromMoviesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("Movies", "Genre_Id");
        }
        
        public override void Down()
        {
        }
    }
}
