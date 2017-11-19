using System;
using System.Web.Mvc;

namespace ComicBooksLibrary.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Details()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }

            return Content("Hello from Details ASP.NET");
        }
    }
}