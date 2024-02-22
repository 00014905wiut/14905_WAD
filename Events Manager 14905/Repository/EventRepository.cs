using Events_Manager_14905.Data;
using Events_Manager_14905.Interfaces;
using Events_Manager_14905.Models;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Events_Manager_14905.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly DataContext _context;
        public EventRepository(DataContext context)
        {
            _context = context;
        }

        
        public bool EventExists(int Id)
        {
            return _context.Events.Any(p => p.EventId == Id);
        }

        public Event GetEvent(string Name)
        {
            return _context.Events.Where(p => p.EventName == Name).FirstOrDefault();
        }

        public Event GetEvent(int Id)
        {
            return _context.Events.Where(p => p.EventId == Id).FirstOrDefault();
       }

        public DateTime GetEventForDateTime(DateTime EventDate)
        {
            throw new NotImplementedException();
        }

        public int GetEventRating(int Id)
        {
            var Rating = _context.EventRatings.FirstOrDefault(p => p.Event.EventId == Id);

            if (Rating.Equals(0)) {
                return 0;
            }
            return Rating.Rating;
        }

        public ICollection<Event> GetEvents()
        {
            return _context.Events.OrderBy(p => p.EventId).ToList();
        }

        public EventNames GetNames(string Name)
        {
            throw new NotImplementedException();
        }

        EventNames IEventRepository.GetEventName(int id)
        {
            return _context.EventNames.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
