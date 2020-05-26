using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using RestfulService.Models;

namespace RestfulService.DAL
{
    public class BookDAO
    {
        static String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
        MyDBDataContext db = new MyDBDataContext(strCon);

        public List<Book> SelectAll()
        {
            List<Book> books = db.Books.ToList();
            return books;
        }

        public Book SelectByCode(int code)
        {
            Book book = db.Books.SingleOrDefault(x => x.Code == code);
            return book;
        }

        public Book Insert(Book newBook)
        {
            try
            {
                db.Books.InsertOnSubmit(newBook);
                db.SubmitChanges();
                return newBook;
            } catch
            {
                return null;
            }
        }

        public Book Update(int code, Book newBook)
        {
            try
            {
                Book dbBook = db.Books.SingleOrDefault(x => x.Code == code);
                if (dbBook != null)
                {
                    dbBook.Name = newBook.Name;
                    dbBook.Author = newBook.Author;
                    dbBook.Price = newBook.Price;
                    db.SubmitChanges();
                }
                return dbBook;
            } catch
            {
                return null;
            }
        }

        public Book Delete(int code)
        {
            try
            {
                Book dbBook = db.Books.SingleOrDefault(x => x.Code == code);
                if (dbBook != null)
                {
                    db.Books.DeleteOnSubmit(dbBook);
                    db.SubmitChanges();
                }
                return dbBook;
            } catch
            {
                return null;
            }
        }

        public List<Book> SelectByName(String keyword)
        {
            List<Book> books = db.Books.Where(b => b.Name.Contains(keyword)).ToList();
            return books;
        }
    }
}