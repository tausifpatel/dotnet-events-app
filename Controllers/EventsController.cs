using EventsApi.Data;
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
        public ActionResult GetBooks()
        {
            return Ok(_eventServices.GetEvents());
        }

        [HttpGet("{id}")]
        public ActionResult getBook(string id)
        {
            return Ok(_eventServices.GetEvent(id));
        }
    }
}