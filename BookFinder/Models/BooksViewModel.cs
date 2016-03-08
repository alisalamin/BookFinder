using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FakeDomainInterfaces;
using FakeDomainInterfaces.Models;

namespace BookFinder.Models
{
    public class BookViewModel : IBook
    {
        public int ISBN { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class BooksViewModel
    {
        public IEnumerable<BookViewModel> Books { get; set; }
    }
}