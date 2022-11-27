using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "showking all book";
        }
        public string GetOnlyOneBooks(int id)
        {
            return "Only book which id is"+ id;
        }
        public string SearchBooks(string author , string typeofbook)
        {
            return "showking all book in cataguory" + author + typeofbook;
        }

    }
}
