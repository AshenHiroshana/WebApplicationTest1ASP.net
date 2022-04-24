using System.ComponentModel.DataAnnotations;

namespace WebApplicationTest1.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime DueDate { get; set; }

        public TodoStatus Status { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

    }
}
