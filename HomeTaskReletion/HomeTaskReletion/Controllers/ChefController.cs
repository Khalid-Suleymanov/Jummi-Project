using HomeTaskReletion.DAL;
using HomeTaskReletion.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskReletion.Controllers
{
    public class ChefController:Controller
    {
        private readonly ReletionDbContext _context;

        public ChefController(ReletionDbContext context)
        {
            _context = context;
        }

        public IActionResult Detail(int id)
        {
            Chef chef = _context.Chefs.Include(c=>c.ChefSocialMedia).Include(c=>c.Profession).ToList().FirstOrDefault(x => x.Id == id); 
            return View(chef);
        }
    }
}
