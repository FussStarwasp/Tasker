namespace Tasker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatus : DbMigration
    {
        public override void Up()
        {

            Sql(@"SET IDENTITY_INSERT ChoreStatus ON;
INSERT INTO ChoreStatus(Id, Name)
VALUES 
('1','Due'),
('2','In Progress'),
('3','Completed'),
('4','Revisited')
;
          SET IDENTITY_INSERT ChoreStatus OFF;");

            
           

        }
        
        public override void Down()
        {
        }
    }
}
