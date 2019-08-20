using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosMapModels
{
    public class Place
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitud { get; set; }

        public Place(string name, double latitude, double longitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitud = longitude;
        }
    }
}
