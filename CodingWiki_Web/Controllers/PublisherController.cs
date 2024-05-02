using CodingWiki_DataAccess.Data;
using CodingWiki_Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_Web.Controllers
{
    public class PublisherController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PublisherController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Publisher> publisher = await _db.Publishers.ToListAsync();
            return View(publisher);
        }
        public async Task <IActionResult> Upsert (int? id)
        {
            Publisher publisher = new Publisher();
            if(id ==  0 || id ==null )
            {
                //Create
                return View(publisher);
            }
           
                publisher = await _db.Publishers.FirstOrDefaultAsync(u => u.Publisher_Id == id);
                if (publisher == null)
                {
                    return NotFound();
                }              
                return View(publisher);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Upsert(Publisher publisher) 
        {
            if (ModelState.IsValid)
            {

                if (publisher.Publisher_Id == 0)
                {
                    await _db.Publishers.AddAsync(publisher);
                }
                else
                {
                    _db.Publishers.Update(publisher);
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(publisher);
        } 
    
        public async Task <IActionResult> Delete (int id)
        {
            Publisher publisher = await _db.Publishers.FirstOrDefaultAsync (u=>u.Publisher_Id==id);
            if (publisher == null) {
                return NotFound();
            }
            _db.Publishers.Remove(publisher);
            await _db.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));

        }

    }
}
