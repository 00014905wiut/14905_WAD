namespace Events_Manager_14905.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class EventNames
    {
        [Key] // Marking Id as the primary key
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        // Navigation property for the related EventRating entities
        public ICollection<EventRating> Names { get; set; }
        
    }

}
