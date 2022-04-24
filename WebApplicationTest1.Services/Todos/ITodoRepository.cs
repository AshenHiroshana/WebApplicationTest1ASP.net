using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationTest1.Models;

namespace WebApplicationTest1.Services.Todos
{
    //dao
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();
    }
}
