using IEnumerableApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Products.API.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ToDo>().HasData(
                new ToDo() { Id = 1, Item = "Tomato" },
                new ToDo() { Id = 2, Item = "Onion" },
                new ToDo() { Id = 3, Item = "Rice" },
                new ToDo() { Id = 4, Item = "Cheese" }
            );

            builder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Salary = 10000, DepartmentId = 1, Name = "alex" },
                new Employee() { Id = 2, Salary = 50000, DepartmentId = 2, Name = "seb" },
                new Employee() { Id = 3, Salary = 100000, DepartmentId = 3, Name = "kate" },
                new Employee() { Id = 4, Salary = 9000, DepartmentId = 4, Name = "chris" }
            );

            builder.Entity<Customer>().HasData(
                new Customer() { Id = 1, Revenue = 10000 },
                new Customer() { Id = 2, Revenue = 60000 },
                new Customer() { Id = 3, Revenue = 100000 },
                new Customer() { Id = 4, Revenue = 9000 }
            );
        }
    }
}
