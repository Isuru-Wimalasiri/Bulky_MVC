using BulkeyWebRazor_Temp.Data;
using BulkeyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkeyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
            
        }
        public IActionResult OnPost(Categories obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToPage("Index")
        }
    }
}
