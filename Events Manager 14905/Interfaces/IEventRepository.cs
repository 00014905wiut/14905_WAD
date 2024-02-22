using Events_Manager_14905.Models;

namespace Events_Manager_14905.Interfaces
{
    public interface IEventRepository
    {
        ICollection<Event> GetEvents();
        Event GetEvent (int EventId);
        Event GetEvent(string Name);

        int GetEventRating(int Id);

        EventNames GetEventName(int Id);

        bool EventExists (int Id);
       

        DateTime GetEventForDateTime(DateTime EventDate);

       
        

    }
}
