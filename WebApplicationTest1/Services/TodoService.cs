using WebApplicationTest1.Models;

namespace WebApplicationTest1.Services
{
    public class TodoService
    {
        public List<Todo> AllTodos()
        {
            var list = new List<Todo>();

            list.Add(new Todo
            {
                Id = 1,
                Title = "A",
                Description = "A aa",
                Created = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            });

            list.Add(new Todo
            {
                Id = 2,
                Title = "B",
                Description = "B bb",
                Created = DateTime.Now,
                DueDate = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed
            });

            list.Add(new Todo
            {
                Id = 3,
                Title = "C",
                Description = "C aa",
                Created = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress
            });

            return list;
        }
    }
}
