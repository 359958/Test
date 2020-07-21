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
            "Mild Freezing", "Mild Bracing", "Mild Chilly", "Mild Cool", "Mild", "Mild Warm", "Mild Balmy", "Mild Hot", "Mild Sweltering", "Mild Scorching" ,"Too Hot"
        };
        public string Get(int rnd)
        {

            return Summaries[rnd];

        }
    }
}
