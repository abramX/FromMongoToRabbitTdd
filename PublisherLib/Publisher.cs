using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib
{
    public class Publisher
    {
        IEnumerable<object> _listToSend;
        public Publisher(IEnumerable<Object> listToSend)
        {
            _listToSend = listToSend;
        }

        public string ConvertToJson(IEnumerable<Object> listToConvert)
        {
            return JsonConvert.SerializeObject(listToConvert);
        }

        public void Execute()
        {
            string message = ConvertToJson(_listToSend);
        }
    }
}
