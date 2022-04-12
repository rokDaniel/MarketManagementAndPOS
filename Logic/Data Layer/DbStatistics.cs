using MongoDB.Driver;
using Logic.Business_Layer;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Logic.Data_Layer
{
    public class DbStatistics
    {
        private const string ConnectionString = "mongodb+srv://dddaniel:admin@cluster0.kiz53.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
        private const string DatabaseName = "homepagedb";
        private const string collection = "statistics";

        private IMongoCollection<T> setupConnection<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);

            return db.GetCollection<T>(collection);
        }

        public async Task<List<Statistics>> GetAllStatistics()
        {
            var statsCollection = setupConnection<Statistics>(collection);
            var result = await statsCollection.FindAsync(_ => true);

            return result.ToList();
        }

        public Statistics LoadStatisticsById(string id)
        {
            var statsCollection = setupConnection<Statistics>(collection);
            var filter = Builders<Statistics>.Filter.Eq("Id", id);

            return statsCollection.Find(filter).First();
        }

        public Task CreateStats(Statistics stats)
        {
            var statsCollection = setupConnection<Statistics>(collection);

            return statsCollection.InsertOneAsync(stats);
        }

        public Task UpdateStatistics(Statistics stats)
        {
            var statsCollection = setupConnection<Statistics>(collection);
            var filter = Builders<Statistics>.Filter.Eq("Id", stats.Id);

            return statsCollection.ReplaceOneAsync(filter, stats, new ReplaceOptions { IsUpsert = true });
        }
    }
}
