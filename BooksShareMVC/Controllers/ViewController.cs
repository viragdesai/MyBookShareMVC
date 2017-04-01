using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BooksShareMVC.Controllers
{
    public class ViewController : Controller
    {
        //
        // GET: /View/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Book()
        {
            BooksShareEntities1 bsEntities1 = new BooksShareEntities1();
            var bookList = new List<BooksShareMVC.Book>();
            if (Request.HttpMethod == "POST")
            {
                var key = Request.Params["id"].ToString();
                bookList = bsEntities1.Books.Where(b => b.Title.Contains(key) || b.Description.Contains(key)).ToList();
                return View(bookList);
            }
            else
            {
                bookList = bsEntities1.Books.Take(10).OrderByDescending(book => book.ViewCount).ToList();
                return View(bookList);
            }
        }


        public ActionResult Show()
        {
            if (RouteData.Values["id"] != null)
            {
                try
                {
                    BooksShareEntities1 bsEntities1 = new BooksShareEntities1();
                    long theId = long.Parse(RouteData.Values["id"].ToString());
                    var theBook = bsEntities1.Books.Where(b => b.ID == theId).ToList();
                    return View(theBook);
                }
                catch (Exception ex)
                {
                    BooksShareEntities1 bsEntities1 = new BooksShareEntities1();
                    List<BooksShareMVC.Book> bookList = bsEntities1.Books.ToList();
                    return View("Book", bookList);
                }
            }
            else
            {
                List<BooksShareMVC.Book> bookList = new List<BooksShareMVC.Book>();
                return View(bookList);
            }
        }
    }
}
