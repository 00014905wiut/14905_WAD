using Events_Manager_14905.Models;

namespace Events_Manager_14905.Interfaces
{
    public interface IEventRepository
    {
        ICollection<Event> GetEvents();
    }
}
