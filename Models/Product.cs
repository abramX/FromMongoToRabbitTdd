using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public ObjectId Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public PriceList PriceList { get; set; }
        public bool Sent { get; set; }
        public Product()
        {
            CreationDate = DateTime.Now;
            Sent = false;
        }
    }
}
