using Events_Manager_14905.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace Events_Manager_14905.Interfaces
{
    public interface IRatingRepository
    {
        ICollection<EventRating> GetEventRating();
        EventRating GetRating(int id);

        ICollection<Event> GetEventByCategory(int EventId);
        
        bool RatingExists(int id);


    }
}
