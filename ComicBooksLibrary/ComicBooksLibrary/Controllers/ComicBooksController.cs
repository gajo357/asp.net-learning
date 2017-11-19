using ComicBooksLibrary.Data;
using System.Web.Mvc;

namespace ComicBooksLibrary.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController(ComicBookRepository repository)
        {
            _comicBookRepository = repository;
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
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