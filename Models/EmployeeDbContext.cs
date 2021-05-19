﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}