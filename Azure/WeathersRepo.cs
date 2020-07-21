using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure
{
    public class WeathersRepo : IWeather
    {

        private static readonly string[] Summaries = new[]
       {
            "Freezing", "Bracing", "Mild Chilly", "Mild Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" ,"Too Hot"
        };
        public string Get(int rnd)
        {

            return Summaries[rnd];

        }
    }
}
