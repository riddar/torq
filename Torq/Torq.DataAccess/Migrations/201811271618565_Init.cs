namespace Torq.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        IsOnline = c.Boolean(nullable: false),
                        LoginError = c.String(),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.Role_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClockedIn = c.Boolean(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Employee_Id = c.Int(),
                        Salary_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.Employee_Id)
                .ForeignKey("dbo.Salary", t => t.Salary_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Salary_Id);
            
            CreateTable(
                "dbo.Salary",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalaryType = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedule", "Salary_Id", "dbo.Salary");
            DropForeignKey("dbo.Schedule", "Employee_Id", "dbo.Employee");
            DropForeignKey("dbo.Employee", "Role_Id", "dbo.Role");
            DropIndex("dbo.Schedule", new[] { "Salary_Id" });
            DropIndex("dbo.Schedule", new[] { "Employee_Id" });
            DropIndex("dbo.Employee", new[] { "Role_Id" });
            DropTable("dbo.Salary");
            DropTable("dbo.Schedule");
            DropTable("dbo.Role");
            DropTable("dbo.Employee");
        }
    }
}
