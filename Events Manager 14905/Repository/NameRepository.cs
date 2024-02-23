using AutoMapper;
using Events_Manager_14905.Data;
using Events_Manager_14905.Interfaces;
using Events_Manager_14905.Models;

namespace Events_Manager_14905.Repository
{
    public class NameRepository : INameRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public NameRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ICollection<EventNames> GetEventNames()
        {
           return _context.EventNames.ToList();
        }

        public ICollection<Event> GetEventsWithRateName(string rateName)
        {
            throw new NotImplementedException();
        }

        public EventNames GetName(int id)
        {
            return _context.EventNames.Where(c => c.Id == id).FirstOrDefault();
        }

        public EventNames GetNameByName(string name)
        {
            return _context.EventNames.Where(p => p.Name == name).FirstOrDefault();
        }

        public bool NameExists(int id)
        {
           return _context.EventNames.Any(e => e.Id == id);
        }
    }
}
