using HomeTaskReletion.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskReletion.DAL
{
    public class ReletionDbContext:DbContext
    {
        public ReletionDbContext(DbContextOptions<ReletionDbContext>options):base(options)
        {

        }

        public DbSet<Chef> Chefs { get; set; }

        public DbSet<Profession> Professions { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<ChefSocialMedia> ChefSocialMedias { get; set; }
    }
}
