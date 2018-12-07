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
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        IsOnline = c.Boolean(nullable: false),
                        LoginError = c.String(),
                        RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId);
            
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
                        EmployeeId = c.Int(),
                        SalaryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .ForeignKey("dbo.Salary", t => t.SalaryId)
                .Index(t => t.EmployeeId)
                .Index(t => t.SalaryId);
            
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
            DropForeignKey("dbo.Schedule", "SalaryId", "dbo.Salary");
            DropForeignKey("dbo.Schedule", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "RoleId", "dbo.Role");
            DropIndex("dbo.Schedule", new[] { "SalaryId" });
            DropIndex("dbo.Schedule", new[] { "EmployeeId" });
            DropIndex("dbo.Employee", new[] { "RoleId" });
            DropTable("dbo.Salary");
            DropTable("dbo.Schedule");
            DropTable("dbo.Role");
            DropTable("dbo.Employee");
        }
    }
}
