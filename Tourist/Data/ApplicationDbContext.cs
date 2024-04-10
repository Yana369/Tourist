using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tourist.Models;

namespace Tourist.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Region> Regions { get; set; } // DbSet для областей
        public DbSet<Place> Places { get; set; }   // DbSet для місць

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Зв'язок між областями та місцями: одна область може мати багато місць
            builder.Entity<Place>()
                .HasOne(p => p.Region) // Місце має одну область
                .WithMany(r => r.Places) // Область може мати багато місць
                .HasForeignKey(p => p.RegionID); // Встановлюємо зовнішній ключ

        }

    }
}
