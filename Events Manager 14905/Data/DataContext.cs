using Events_Manager_14905.Models;
using Microsoft.EntityFrameworkCore;

namespace Events_Manager_14905.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventNames> EventNames { get; set; }
        public DbSet<EventRating> EventRatings {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasKey(pc => pc.EventId);

          
                

        }
    }
}
