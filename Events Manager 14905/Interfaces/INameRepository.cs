using Events_Manager_14905.Models;

namespace Events_Manager_14905.Interfaces
{
    public interface INameRepository
    {
        ICollection<EventNames> GetEventNames();
        
        EventNames GetName(int id);

        ICollection<Event> GetEventsWithRateName(string rateName);

        EventNames GetNameByName(string name);

        bool NameExists(int id);
    }
}
