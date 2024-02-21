using Events_Manager_14905.Data;
using Events_Manager_14905.Models;

namespace Events_Manager_14905
{
    public class Seed
    {
   
            private readonly DataContext dataContext;

            public Seed(DataContext context)
            {
                this.dataContext = context;
            }

            public void SeedDataContext()
            {
                if (!dataContext.Events.Any())
                {
                    var events = new List<Event>()
            {
                new Event
                {
                    EventName = "Example Event 1",
                    EventDescription = "Description of Example Event 1",
                    EventCategory = "Category of Example Event 1",
                    Ratings = new List<EventRating>()
                    {
                        new EventRating { Rating = 5, EventNames = new EventNames { Name = "important" } },
                        new EventRating { Rating = 4, EventNames = new EventNames { Name = "mildly important" } }
                    }
                },
                new Event
                {
                    EventName = "Example Event 2",
                    EventDescription = "Description of Example Event 2",
                    EventCategory = "Category of Example Event 2",
                    Ratings = new List<EventRating>()
                    {
                        new EventRating { Rating = 3, EventNames = new EventNames { Name = "not important" } },
                        new EventRating { Rating = 2, EventNames = new EventNames { Name = "urgent" } }
                    }
                }
            };

                    dataContext.Events.AddRange(events);
                    dataContext.SaveChanges();
                }
            }
        

    }
}
