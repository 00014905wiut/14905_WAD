using Events_Manager_14905.Interfaces;
using Events_Manager_14905.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;


using System.Collections.Generic;

namespace Events_Manager_14905.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [HttpGet("events")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Event>))]
        public IActionResult GetEvents()
        {
            var events = _eventRepository.GetEvents();

            if (events == null)
            {
                return NotFound();
            }

            return Ok(events);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Event))]
        [ProducesResponseType(400)]
        public IActionResult GetEvent(int id)
        {
            if (!_eventRepository.EventExists(id))
                return NotFound();

            var _event = _eventRepository.GetEvent(id);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(_event);
        }

        [HttpGet("{eventId}/rating")] 
        [ProducesResponseType(200, Type = typeof(int))]
        [ProducesResponseType(400)]
        public IActionResult GetEventRating(int eventId)
        {
            if (!_eventRepository.EventExists(eventId))
                return NotFound();

            var rating = _eventRepository.GetEventRating(eventId);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(rating);
        }

        [HttpGet("{eventId}/name")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Event>))]
        [ProducesResponseType(400)]
        public IActionResult GetEventName(int Id)
        {
            if (!_eventRepository.EventExists(Id))
                return NotFound();

            var eventName = _eventRepository.GetEventName(Id);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(eventName);
        }
    }
}
