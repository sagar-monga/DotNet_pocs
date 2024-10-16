using System;
using _01WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace _01WebApi.DbContexts;

public class EmployeeContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    public EmployeeContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

}
