using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor
{
    public interface IAirSpaceFilter
    {
        List<Track> Track { get; set; }

        bool FilterTracks(Track track);
    }
}
