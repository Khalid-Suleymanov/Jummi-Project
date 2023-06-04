using HomeTaskReletion.DAL;
using HomeTaskReletion.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskReletion.Controllers
{
    public class TestimonialController:Controller
    {

        private readonly ReletionDbContext _context;

        public TestimonialController(ReletionDbContext context)
        {
            _context = context;
        }

        public IActionResult Detail(int id)
        {
            Testimonial testimonial = _context.Testimonials.Include(c => c.Profession).ToList().FirstOrDefault(x => x.Id == id);
            return View(testimonial);
        }
    }
}
