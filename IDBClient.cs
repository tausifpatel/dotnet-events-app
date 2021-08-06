using EventsApi.Models;
using MongoDB.Driver;

namespace EventsApi 
{
    public interface IDBClient
    {
        IMongoCollection<Event> getEventsCollection();
    }
}