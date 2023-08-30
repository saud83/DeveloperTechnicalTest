namespace ASimpleWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO users (FullName, UserName, Password) SELECT 'John Doe', CONCAT(UserId, ' - ', 'John Doe'), '12345'); ");
            Sql("Insert into users (FullName, UserName, Password) Values ('Michel Jordan', 'MichelJordan_02', '12345')");
        }
        
        public override void Down()
        {
        }
    }
}
