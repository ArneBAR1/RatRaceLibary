using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRaceLibary
{
    class Plain : Track
    {
        public Plain(string name, int trackLength) : base(name, trackLength)
        {
            TrackLength = trackLength;
            Name = name;
            Terrain = "Plain";
            //+speed for plain rats
        }
    }
}
