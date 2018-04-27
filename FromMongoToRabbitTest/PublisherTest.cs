using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbRepository;
using Models;
using PublisherLib;

namespace FromMongoToRabbitTest
{
    [TestFixture]
    public class PublisherTest
    {
        MongoDbRepository _mongo;
        Publisher _sut;
        [SetUp]
        public void OnStart()
        {
            _mongo = new MongoDbRepository();
            
        }
        [Test]
        public void SelectingProductsFromMongoIsNotThrowingExeption()
        {
            Assert.DoesNotThrow(() => { _mongo.All<Product>().Count(); });
        }
        
        [Test]
        public void PublisherIsNotThrowingExeption()
        {
            _sut = new Publisher(_mongo.All<Product>());
            Assert.DoesNotThrow(() => { _sut.Execute(); });
        }



    }
}
