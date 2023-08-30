namespace ASimpleWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTask : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO tasks (UserId, Description, IsCompleted) Values (2, 'This is my First Task', 0); ");
            Sql("INSERT INTO tasks (UserId, Description, IsCompleted) Values (2, 'This is second Task', 1); ");
        }
        
        public override void Down()
        {
        }
    }
}
