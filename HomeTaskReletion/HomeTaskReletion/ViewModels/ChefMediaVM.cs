using HomeTaskReletion.Entities;

namespace HomeTaskReletion.ViewModels
{
    public class ChefMediaVM
    {

        public IEnumerable<Chef> Chefs { get; set; }

        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
