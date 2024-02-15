using Microsoft.EntityFrameworkCore;

namespace Events_Manager_14905.Models
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions options) : base(options) 
        {

        }
      

        public DbSet<Event> Events { get; set; }
    }
}
