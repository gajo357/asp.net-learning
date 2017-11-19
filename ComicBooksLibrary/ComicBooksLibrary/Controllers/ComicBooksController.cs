using ComicBooksLibrary.Data;
using ComicBooksLibrary.Models;
using System;
using System.Web.Mvc;

namespace ComicBooksLibrary.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (!id.HasValue)
                return HttpNotFound();

            var comicBook = _comicBookRepository.GetComicBook(id.Value);

            return View(comicBook);
        }   
    }
}