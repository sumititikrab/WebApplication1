﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace WebApplication1.Models
{
    public partial class EmployeeDepartmentModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                {
                    DepartmentId = c.Int(nullable: false, identity: true),
                    DepartmentName = c.String(),
                })
                .PrimaryKey(t => t.DepartmentId);

            CreateTable(
                "dbo.Employees",
                c => new
                {
                    EmployeeId = c.Int(nullable: false, identity: true),
                    EmployeeName = c.String(),
                    EmployeeDesignation = c.String(),
                    EmployeeAddress = c.String(),
                    EmployeePassport = c.String(),
                    EmployeePhone = c.Int(nullable: false),
                    EmployeeGender = c.String(),
                    City = c.String(),
                    Project = c.String(),
                    CompanyName = c.String(),
                    PinCode = c.Int(nullable: false),
                    DepartmentId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}  
