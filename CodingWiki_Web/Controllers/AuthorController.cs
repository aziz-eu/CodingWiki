using CodingWiki_DataAccess.Data;
using CodingWiki_Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AuthorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Author> authors = await _db.Authors.ToListAsync();
            return View(authors);
        }

        
        public async Task<IActionResult> Upsert(int? id)
        {
            Author author = new();
            if(id == null || id == 0)
            {
                return View(author);
            }
            author = await _db.Authors.FirstOrDefaultAsync(u => u.Author_Id == id);
            if(author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // POST: Author/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Upsert (Author author)
        {
            try
            {
               
                if (ModelState.IsValid)
                {
                    if(author.Author_Id == 0)
                    {
                        await _db.Authors.AddAsync(author);
                    }
                    else
                    {
                        _db.Authors.Update(author);
                    }
                    await _db.SaveChangesAsync();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(author);
            }
        }

      
        public async Task<IActionResult> Delete(int id)
        {
            Author author = new();
            author = await _db.Authors.FirstOrDefaultAsync(u=>u.Author_Id ==id);
            if(author == null)
            {
                return NotFound();
            }
            _db.Authors.Remove(author);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
