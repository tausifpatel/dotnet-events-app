using EventsApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace EventsApi 
{
    public class DBClient : IDBClient
    {
        private readonly IMongoCollection<Event> _events;

        public DBClient(IOptions<EventDBConfig> eventDbConfig)
        {
            var client = new MongoClient(eventDbConfig.Value.Connection_String);
            var database = client.GetDatabase(eventDbConfig.Value.Database_Name);
            _events = database.GetCollection<Event>(eventDbConfig.Value.Events_Collection_Name);
        }

        public IMongoCollection<Event> getEventsCollection()
        {
            return _events;
        }
    }
}