﻿using Library.Api.Entities;

namespace Library.Api.Models
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Book> Books { get; set; }
    }
}
