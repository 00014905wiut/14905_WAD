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
    public class EventNameController : ControllerBase
    {
        public readonly INameRepository _nameRepository;
        public readonly IMapper _mapper;
        public EventNameController(INameRepository nameRepository, IMapper mapper) 
        {
            _nameRepository = nameRepository;
            _mapper = mapper;
        }

        [HttpGet("names")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EventNames>))]
        public IActionResult GetEventNames()
        {
            var names = _mapper.Map<List<EventNamesDto>>(_nameRepository.GetEventNames());

            if (names == null)
            {
                return NotFound();
            }

            return Ok(names);
        }

        [HttpGet("{nameid}")]
        [ProducesResponseType(200, Type = typeof(EventNames))]
        [ProducesResponseType(400)]
        public IActionResult GetName(int id)
        {
            if (!_nameRepository.NameExists(id))
                return NotFound();

            var name = _mapper.Map<EventNamesDto>(_nameRepository.GetName(id));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(name);
        }

        



    }
}
