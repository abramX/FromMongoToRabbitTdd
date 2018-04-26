using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbRepository;
using Models;

namespace FromMongoToRabbitTest
{
    [TestFixture]
    public class PublisherTest
    {
        MongoDbRepository _mongo;
        [SetUp]
        public void OnStart()
        {
            _mongo = new MongoDbRepository();
        }

        [Test]
        public void SelectingProductsFromMongoIsNotThrowingExeption()
        {
            //int productsCount = _mongo.All<Product>().ToList().Count;
            
            //Assert.IsTrue(productsCount >= 1);
            Assert.DoesNotThrow(() => { _mongo.All<Product>().Count(); });
        }
        

    }
}
