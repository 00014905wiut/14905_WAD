using AutoMapper;
using Events_Manager_14905.Dto;
using Events_Manager_14905.Interfaces;
using Events_Manager_14905.Models;
using Events_Manager_14905.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Events_Manager_14905.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventRateController : Controller 
    
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IMapper _mapper;
        public EventRateController(IRatingRepository ratingRepository, IMapper mapper) 
        {
            _ratingRepository = ratingRepository;
            _mapper = mapper;
        }

        [HttpGet("rate")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EventRating>))]
        public IActionResult GetEventRatings()
        {
            var ratings = _ratingRepository.GetEventRating();

            if (ratings == null)
            {
                return NotFound();
            }

            return Ok(ratings);
        }
        [HttpGet("{ratingId}")]
        [ProducesResponseType(200, Type = typeof(EventRating))]
        [ProducesResponseType(400)]
        public IActionResult GetEventRatings(int id)
        {
            if (!_ratingRepository.RatingExists(id))
                return NotFound();

            var _rateId = _mapper.Map<EventRatingDto>(_ratingRepository.GetRating(id));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(_rateId);
        }

        [HttpGet("event/{rateid}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EventRating>))]
        [ProducesResponseType(400)]
        public IActionResult GetEventRatingByEventName(int EventId)
        {
            var events = _mapper.Map<List<EventRatingDto>>(_ratingRepository.GetEventByCategory(EventId));

            if(!ModelState.IsValid) return BadRequest();
            return Ok(events);
        }

    }
}
