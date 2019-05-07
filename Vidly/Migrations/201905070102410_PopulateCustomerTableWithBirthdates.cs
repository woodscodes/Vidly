namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerTableWithBirthdates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '10-20-1984' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
