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
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        IsOnline = c.Boolean(nullable: false),
                        RoleId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId_Id)
                .Index(t => t.RoleId_Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schema",
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
                        SalaryType = c.String(maxLength: 50),
                        Amount = c.Int(nullable: false),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schema", "Salary_Id", "dbo.Salary");
            DropForeignKey("dbo.Salary", "Employee_Id", "dbo.Employee");
            DropForeignKey("dbo.Schema", "Employee_Id", "dbo.Employee");
            DropForeignKey("dbo.Employee", "RoleId_Id", "dbo.Role");
            DropIndex("dbo.Salary", new[] { "Employee_Id" });
            DropIndex("dbo.Schema", new[] { "Salary_Id" });
            DropIndex("dbo.Schema", new[] { "Employee_Id" });
            DropIndex("dbo.Employee", new[] { "RoleId_Id" });
            DropTable("dbo.Salary");
            DropTable("dbo.Schema");
            DropTable("dbo.Role");
            DropTable("dbo.Employee");
        }
    }
}
