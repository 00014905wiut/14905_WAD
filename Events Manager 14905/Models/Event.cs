using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;

namespace Events_Manager_14905.Models
{
    public class Event
    {
        [Key] // Marking EventId as the primary key
        public int EventId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string EventName { get; set; } = "";

        [Column(TypeName = "nvarchar(200)")]
        public string EventDescription { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string EventCategory { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string UserPhoneNum { get; set; } = "";

        public DateTime EventCreated { get; set; } = DateTime.Now;

        public DateTime EventFor { get; set; }

        public int TimeLeft()
        {
            long tmlft = (EventFor.Ticks - EventCreated.Ticks) / TimeSpan.TicksPerSecond;
            return (int)tmlft;
        }
    }
}
