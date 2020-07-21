using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure
{
     public interface IWeather
    {
        public string Get(int id);
    }
}
