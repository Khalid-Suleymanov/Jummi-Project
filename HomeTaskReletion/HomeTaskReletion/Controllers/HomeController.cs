using HomeTaskReletion.DAL;
using HomeTaskReletion.Entities;
using HomeTaskReletion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskReletion.Controllers
{
    public class HomeController:Controller
    {
        private readonly ReletionDbContext _context;

        public HomeController(ReletionDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {

            IEnumerable<Chef> chefs = _context.Chefs.Include(c => c.ChefSocialMedia).Include(c => c.Profession).AsEnumerable();
            IEnumerable<Testimonial> testimonials = _context.Testimonials.Include(c => c.Profession).AsEnumerable();


            ChefMediaVM model = new()
            {
                Chefs= chefs,
                Testimonials=testimonials
            };

            return View(model);
        }
        
    }
}
