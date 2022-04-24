using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.Services.Authors;


namespace WebApplicationTest1.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/Authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorsController(IAuthorRepository repository)
        {
            _authorRepository = repository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorRepository.GetAuthor(id);
            if (author == null)
            {
                return NotFound("No Author");
            }
            return Ok(author); ;
        }
    }
}
