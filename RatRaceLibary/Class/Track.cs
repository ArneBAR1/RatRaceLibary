using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRaceLibary
{
    public class Track
    {
        public string Name;
        public int TrackLength;
        public string Terrain;
        public Track(string name, int trackLength)
        {
            TrackLength = trackLength;
            Name = name;

        }
    }
}
