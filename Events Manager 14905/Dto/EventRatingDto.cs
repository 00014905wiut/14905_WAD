using Events_Manager_14905.Models;

namespace Events_Manager_14905.Dto
{
    public class EventRatingDto
    {
        public int Id { get; set; }


        public int EventId { get; set; }


        public Event Event { get; set; }

        public int Rating { get; set; }


        public int EventNamesId { get; set; }


    }
}
