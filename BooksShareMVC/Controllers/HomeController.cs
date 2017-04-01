using System.Web.Mvc;

namespace BooksShareMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "A simple platform to buy/sell/exchange your old/new books here.";
            //BooksShareEntities1 context = new BooksShareEntities1();
            //var qry = from books in context.Books select books;
            //List<BooksShareMVC.Book> sss = qry.ToList();
            //return View(sss);
            return View();
        }

        [HttpPost]
        public ActionResult Search(string keyword)
        {

            //return RedirectToAction("Book", "View", new { key= keyword });
            //return RedirectToAction("Book", "View");
            return RedirectToAction("Book", "View");
            //Response.Redirect("/View/Book?key=" + keyword);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
