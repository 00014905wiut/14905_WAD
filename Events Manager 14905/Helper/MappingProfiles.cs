using AutoMapper;
using Events_Manager_14905.Dto;
using Events_Manager_14905.Models;

namespace Events_Manager_14905.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Event, EventDto>();
            CreateMap<EventRating,  EventRatingDto>();
            CreateMap<EventNames, EventNamesDto>();
        }
    }
}
