namespace Torq.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee", "UserName", c => c.String());
            AlterColumn("dbo.Employee", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "UserName", c => c.String(nullable: false));
        }
    }
}
