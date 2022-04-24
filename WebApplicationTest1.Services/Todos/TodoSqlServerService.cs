using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationTest1.DataAccess;
using WebApplicationTest1.Models;

namespace WebApplicationTest1.Services.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();

        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
