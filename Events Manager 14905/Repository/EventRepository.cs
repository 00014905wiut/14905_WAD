using Events_Manager_14905.Data;
using Events_Manager_14905.Interfaces;
using Events_Manager_14905.Models;
using System.Runtime.CompilerServices;

namespace Events_Manager_14905.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly DataContext _context;
        public EventRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Event> GetEvents()
        {
            return _context.Events.OrderBy(p => p.EventId).ToList();
        }
    }
}
