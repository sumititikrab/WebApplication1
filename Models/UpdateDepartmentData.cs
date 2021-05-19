using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace WebApplication1.Models
{
    public partial class UpdateDepartmentData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Departments(DepartmentName)Values('IT')");
            Sql("Insert into Departments(DepartmentName)Values('HR')");
            Sql("Insert into Departments(DepartmentName)Values('Payroll')");
            Sql("Insert into Departments(DepartmentName)Values('Talent Acquisition')");
            Sql("Insert into Departments(DepartmentName)Values('Training & Development')");
        }

        public override void Down()
        {
        }
    }
}