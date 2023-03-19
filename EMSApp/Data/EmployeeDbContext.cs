using EMSApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EMSApp.Data
{
    public class EmployeeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database= EmployeeDB;Integrated Security=True;"; 
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().HasData(
                new Employee(1, "Mark", DateTime.Now, "mark@gmail.com", "0911111111"),
                new Employee(2, "Kim", DateTime.Now, "kim@gmail.com", "0911111112"),
                new Employee(3, "Eduard", DateTime.Now, "ed@gmail.com", "0911111113")
                );

            //modelBuilder.Entity<Department>().HasData(
            //    new Department(1, "HR"),
            //    new Department(2, "Support"),
            //    new Department(3, "IT")
            //    );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
