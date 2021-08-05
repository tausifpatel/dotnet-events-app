using System.Collections.Generic;
using EventsApi.Models;

namespace EventsApi.Data
{
    public interface IEventServices
    {
        List<Event> GetEvents();
        Event GetEvent(string id);
    }
}