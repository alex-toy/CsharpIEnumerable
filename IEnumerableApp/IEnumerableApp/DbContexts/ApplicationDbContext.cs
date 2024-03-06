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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ToDo>().HasData(
                new ToDo() { Id = 1, Item = "Tomato" },
                new ToDo() { Id = 2, Item = "Onion" },
                new ToDo() { Id = 3, Item = "Rice" },
                new ToDo() { Id = 4, Item = "Cheese" }
            );
        }
    }
}
