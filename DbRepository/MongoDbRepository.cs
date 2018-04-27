using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;

namespace DbRepository
{
    public class MongoDbRepository
    {
        private MongoClient _provider;
        private IMongoDatabase _db;
        private string _collection;

        public MongoDbRepository()
        {
            _provider = new MongoClient("mongodb://localhost:27017");
            _db = _provider.GetDatabase("mydb");
            _collection = "products";

        }
        public IQueryable<T> All<T>() where T : class, new()
        {
            return _db.GetCollection<T>(_collection).AsQueryable();
        }
    }
}
