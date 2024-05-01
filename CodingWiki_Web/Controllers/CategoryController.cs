using CodingWiki_DataAccess.Data;
using CodingWiki_Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingWiki_Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new();
            if ( id == 0 || id==null)
            {
                return View(category);
            }
           
               category = _db.Categories.FirstOrDefault(u=>u.Category_Id == id);
                if(category == null)
                {
                    return NotFound();
                }
               
                    return View(category);
                
                
            

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
         public async Task <IActionResult> Upsert(Category obj)
        {
            if(ModelState.IsValid)
            {
                if(obj.Category_Id == 0)
                {
                    await _db.Categories.AddAsync(obj);
                }
                else
                {
                    _db.Categories.Update(obj);
                }
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(obj);

        }
    }
}
