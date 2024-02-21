using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events_Manager_14905.Models
{
    public class EventRating
    {
        [Key] 
        public int Id { get; set; }

        
        public int EventId { get; set; }

        
        public Event Event { get; set; }

        public int Rating { get; set; }

       
        public int EventNamesId { get; set; }

       
        public EventNames EventNames { get; set; }
       }
    }
