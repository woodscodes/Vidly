namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDataInMoviesTableStockNumberAndAvailabilityNumber : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberInStock = 5");
        }
        
        public override void Down()
        {
        }
    }
}
