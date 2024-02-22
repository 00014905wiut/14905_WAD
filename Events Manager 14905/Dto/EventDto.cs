using System.ComponentModel.DataAnnotations.Schema;

namespace Events_Manager_14905.Dto
{
    public class EventDto
    {
        public int EventId { get; set; }

       
        public string EventName { get; set; } 

        
        public string EventDescription { get; set; } 


        public DateTime EventFor { get; set; }
    }
}
