using EventsApi.Data;
using EventsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]   
    public class EventsController : ControllerBase
    {
        private readonly IEventServices _eventServices;

        public EventsController(IEventServices eventServices)
        {
            _eventServices = eventServices;
        }

        [HttpGet]
        public ActionResult GetEvents()
        {
            return Ok(_eventServices.GetEvents());
        }

        [HttpGet("{id}")]
        public ActionResult GetEent(string id)
        {
            return Ok(_eventServices.GetEvent(id));
        }

        [HttpPost]
        public ActionResult AddEvent(Event evnt)
        {
            return Ok(_eventServices.AddEvent(evnt));
        }
    }
}