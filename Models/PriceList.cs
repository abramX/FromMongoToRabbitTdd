using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PriceList
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Double Price { get; set; }

        public PriceList()
        {
            StartingDate = DateTime.Now;
            ExpirationDate = StartingDate.AddDays(356);
        }
    }
}
