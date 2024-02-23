using Events_Manager_14905.Data;
using Events_Manager_14905.Interfaces;
using Events_Manager_14905.Models;
using System.Runtime.CompilerServices;

namespace Events_Manager_14905.Repository
{
    public class RatingRepository : IRatingRepository
    {
        private DataContext _context;
        public RatingRepository(DataContext context)
        {
            _context = context;  
        }
        public ICollection<Event> GetEventByCategory(int EventId)
        {
            return _context.EventRatings.Where(e => e.EventId == EventId).Select(c => c.Event).ToList();
        }

        public ICollection<EventRating> GetEventRating()
        {
            return _context.EventRatings.ToList();
        }

        public EventRating GetRating(int id)
        {
            return _context.EventRatings.Where(b => b.Id == id).FirstOrDefault();
        }

        public bool RatingExists(int id)
        {
            return _context.EventRatings.Any(c => c.Id == id);
        }
    }
}
