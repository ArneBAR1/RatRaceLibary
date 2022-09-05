using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRaceLibary
{
    class Forrest : Track
    {
        public Forrest(string name, int trackLength) : base(name, trackLength)
        {
            TrackLength = trackLength;
            Name = name;
            Terrain = "Forrest";
            //+ speed for forrest rats
        }
    }
}
