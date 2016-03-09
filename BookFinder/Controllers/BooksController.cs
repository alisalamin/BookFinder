using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookFinder.Models;
using FakeDomainInterfaces;
using FakeDomainInterfaces.Models;
using FakeDomainInterfaces.Managers;
using Autofac;
using Autofac.Integration.Mvc;


namespace BookFinder.Controllers
{
    public class BooksController : Controller
    {
        private IBooksManager _BookManager;//<-- BO RepoManager

        public BooksController(IBooksManager books)
        {
            _BookManager = books;
        }

        [HttpGet]
        public ActionResult Books()
        {
            return View(GetBookList());
        }

        //Alternate approach using cacheing being used.
        /*
        [HttpPost]
        public JsonResult GetBook(int isbn)
        {
            return Json(GetSingleBook(isbn), JsonRequestBehavior.AllowGet);
        }
        */

        //cache for 2 hrs.
        [OutputCache(Duration = 7200, VaryByParam = "none")]
        private BooksViewModel GetBookList()
        {
            var bookBOList = _BookManager.GetList();
            var booksList = new List<BookViewModel>();

            foreach (var book in bookBOList)
            {
                booksList.Add(new BookViewModel()
                {
                    Description = book.Description,
                    ISBN = book.ISBN,
                    Title = book.Title
                });
            }

            return new BooksViewModel()
            {
                Books = booksList
            };
        }

        private BookViewModel GetSingleBook(int isbn)
        {
            var bookBOList = _BookManager.GetList().ToList();
            var book = bookBOList.FirstOrDefault(x => x.ISBN.Equals(isbn));

            return new BookViewModel()
            {
                Description = book.Description,
                ISBN = book.ISBN,
                Title = book.Title
            };
        }

    }
}
