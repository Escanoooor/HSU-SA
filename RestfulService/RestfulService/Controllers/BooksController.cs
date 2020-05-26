using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using RestfulService.Models;
using RestfulService.DAL;

namespace RestfulService.Controllers
{
    public class BooksController : ApiController
    {
        [HttpGet]
        [Route("api/books")]
        public List<Book> GetAll()
        {
            List<Book> books = new BookDAO().SelectAll();
            return books;
        }

        [HttpGet]
        [Route("api/books/{code}")]
        public Book GetDetails(int code)
        {
            Book book = new BookDAO().SelectByCode(code);
            return book;
        }

        [HttpPost]
        [Route("api/books")]
        public Book AddNew(Book b)
        {
            Book newBook = new BookDAO().Insert(b);
            return newBook;
        }

        [HttpPut]
        [Route("api/books/{code}")]
        public Book Update(int code, Book b)
        {
            Book newBook = new BookDAO().Update(code, b);
            return newBook;
        }

        [HttpDelete]
        [Route("api/books/{code}")]
        public Book Delete(int code)
        {
            Book book = new BookDAO().Delete(code);
            return book;
        }

        [HttpGet]
        [Route("api/books/search/{keyword}")]
        public List<Book> Search(String keyword)
        {
            List<Book> books = new BookDAO().SelectByName(keyword);
            return books;
        }
    }
}