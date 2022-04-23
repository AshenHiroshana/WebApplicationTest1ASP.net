using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationTest1.Models;

namespace WebApplicationTest1.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-150BK28; Database=MyTodoDb; User Id=root; Password=1234";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 1,
                Title = "A",
                Description = "A aa",
                Created = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            });
        }
    }
}
