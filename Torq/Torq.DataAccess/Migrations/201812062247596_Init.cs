namespace Torq.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employee", name: "Role_Id", newName: "RoleId");
            RenameColumn(table: "dbo.Schedule", name: "Employee_Id", newName: "EmployeeId");
            RenameColumn(table: "dbo.Schedule", name: "Salary_Id", newName: "SalaryId");
            RenameIndex(table: "dbo.Employee", name: "IX_Role_Id", newName: "IX_RoleId");
            RenameIndex(table: "dbo.Schedule", name: "IX_Employee_Id", newName: "IX_EmployeeId");
            RenameIndex(table: "dbo.Schedule", name: "IX_Salary_Id", newName: "IX_SalaryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Schedule", name: "IX_SalaryId", newName: "IX_Salary_Id");
            RenameIndex(table: "dbo.Schedule", name: "IX_EmployeeId", newName: "IX_Employee_Id");
            RenameIndex(table: "dbo.Employee", name: "IX_RoleId", newName: "IX_Role_Id");
            RenameColumn(table: "dbo.Schedule", name: "SalaryId", newName: "Salary_Id");
            RenameColumn(table: "dbo.Schedule", name: "EmployeeId", newName: "Employee_Id");
            RenameColumn(table: "dbo.Employee", name: "RoleId", newName: "Role_Id");
        }
    }
}
