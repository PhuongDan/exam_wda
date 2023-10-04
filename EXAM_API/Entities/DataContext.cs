using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EXAM_API.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Department_Tbl> Departments_Tbl { get; set; }
        public DbSet<Employee_Tbl> Employees_Tbl { get; set; }

    }
}
