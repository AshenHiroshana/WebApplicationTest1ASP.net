using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.Models;
using System.Linq;
using WebApplicationTest1.Services;

namespace WebApplicationTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var list = _todoService.AllTodos();

            if (id is null)
            {
                return Ok(list);
            }

            list = list.Where(t => t.Id == id).ToList();
            return Ok(list);
        }

        
    }
}
