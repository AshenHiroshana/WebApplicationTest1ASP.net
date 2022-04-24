﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationTest1.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [MaxLength(10)]
        public string AddressNo { get; set; }

        [MaxLength(200)]
        public string Street { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }


        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}
