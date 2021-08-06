using System.Collections.Generic;
using EventsApi.Models;
using MongoDB.Driver;

namespace EventsApi.Data
{
    public class EventServices : IEventServices
    {
        private readonly IMongoCollection<Event> _events;

        // Constructor
        public EventServices(IDBClient DBClient)
        {
            _events = DBClient.getEventsCollection();
        }

        public Event AddEvent(Event evnt)
        {
            _events.InsertOne(evnt);
            return evnt;
        }

        public Event GetEvent(string id)
        {
            return _events.Find(evnt => evnt.Id == id).First();
        }

        public List<Event> GetEvents()
        {
            return _events.Find(evnt => true).ToList();
        }
    }
}