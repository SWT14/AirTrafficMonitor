using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor
{
    public class AirSpaceFilter : IAirSpaceFilter
    {
        public List<TrackData> _object;


        public AirSpaceFilter(List<TrackData> object);
        {
            _object = object;
        }

        

    }
}
