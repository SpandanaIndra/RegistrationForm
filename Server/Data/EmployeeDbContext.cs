﻿using Microsoft.EntityFrameworkCore;
using RegistrationForm.Shared;

namespace RegistrationForm.Server.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
