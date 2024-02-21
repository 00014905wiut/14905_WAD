using Events_Manager_14905.Interfaces;
using Events_Manager_14905.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

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

        [HttpGet("events")] // Adding attribute route
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
    }
}

