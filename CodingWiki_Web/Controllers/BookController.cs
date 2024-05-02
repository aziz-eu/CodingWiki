using CodingWiki_DataAccess.Data;
using CodingWiki_Models.Models;
using CodingWiki_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_Web.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db =db;
        }
        public async Task<IActionResult> Index()
        {
            List<Book> books = await _db.Books.ToListAsync();

            foreach (var obj in books)
            {
                //obj.Publisher = await _db.Publishers.FindAsync(obj.Publisher_Id);
                await _db.Entry(obj).Reference(u=> u.Publisher).LoadAsync();
            }

            return View(books);
        }
        public async Task<IActionResult> Upsert(int? id)
        {
            BookVM bookVM = new BookVM();
            bookVM.PublisherList = _db.Publishers.Select(u=> new SelectListItem
            {
                Text = u.Name,
                Value = u.Publisher_Id.ToString(),
            });

            if(id ==0 || id == null)
            {
               return View(bookVM);
            }
            bookVM.Book = await _db.Books.FirstOrDefaultAsync(u => u.Id == id);
            if(bookVM.Book == null)
            {
                return NotFound();
            }
            return View(bookVM);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(BookVM bookVM)
        {
            try
            {
                if(bookVM.Book.Id == 0)
                {
                    await _db.Books.AddAsync(bookVM.Book);
                }
                else
                {
                    _db.Books.Update(bookVM.Book);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            BookVM bookVM = new();
            bookVM.Book = await _db.Books.FirstOrDefaultAsync(u=>u.Id == id);
            if(bookVM.Book == null)
            {
                return NotFound();
            }
            _db.Books.Remove(bookVM.Book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
