using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public List<BookModel> listt = new List<BookModel>
        {
            new BookModel { Id = 1, Author = "sourav", Title = "fun1" },

            new BookModel { Id = 2, Author = "golu", Title = "fun2" } ,
            new BookModel { Id = 3, Author = "muskan", Title = "fun3" },
            new BookModel { Id = 4, Author = "shivam", Title = "fun4" }
            

        };
        public List<BookModel> Index(int id)
        {
            return listt;
        }
        public BookModel GetBooksById(int id)
        {
            return listt.Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string author,string title)
        {
            return listt.Where(x => x.Author.Contains(author) && x.Title.Contains(title)).ToList();
        }


    }
}
