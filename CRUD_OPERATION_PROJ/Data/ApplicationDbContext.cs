using System;
using Microsoft.EntityFrameworkCore;
using CRUD_OPERATION_PROJ.Models;
namespace CRUD_OPERATION_PROJ.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}

