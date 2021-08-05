using System.Collections.Generic;
using EventsApi.Models;

namespace EventsApi.Data
{
    public class EventServices : IEventServices
    {
        public Event GetEvent(string id)
        {
            return new Event{Name = "NextJs", Location = "London"};
        }

        public List<Event> GetEvents()
        {
            var events = new List<Event>
            {
                new Event{Id="01", Name = "NextJs", Location = "London"},
                new Event{Id="02", Name = "ReactJs", Location = "Manchester"}
            };
            return events;
        }
    }
}