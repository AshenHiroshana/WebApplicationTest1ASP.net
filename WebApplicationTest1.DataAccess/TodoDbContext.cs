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
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-150BK28; Database=MyTodoDb; User Id=root; Password=1234";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id = 1, FullName = "Ashen Hiroshana", AddressNo = "2", Street = "3", City = "col1"},
                new Author { Id = 2, FullName = "Indeera Hiroshana", AddressNo = "4", Street = "2", City = "Gam"},
                new Author { Id = 3, FullName = "Salika Hiroshana", AddressNo = "2", Street = "3", City = "col1"}
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                    Id = 1,
                    Title = "A",
                    Description = "A aa",
                    Created = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                    
                },
                new Todo
                {
                    Id = 2,
                    Title = "B",
                    Description = "A aa",
                    Created = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                }
            });
        }
    }
}
