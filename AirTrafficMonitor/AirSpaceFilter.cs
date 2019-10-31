using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;




namespace AirTrafficMonitor
{
    public class AirSpaceFilter : IAirSpaceFilter
    {
      
        public Dictionary<string,ITrack> TrackDic { get; set; }
        public Dictionary<string,ITrackCalculator> TrackCalcDic { get; set; }
        public EventHandler<TrackinAirEvent> TrackUpdated;
        public List<ITrack> trackList { get; set; }

        public AirSpaceFilter(ITrackHandler trackhandler)
        {
            //Attaching the event to the constructor
        }



        public class TrackinAirEvent : EventArgs
        {
            public Dictionary<string, ITrackCalculator> tracks { get; set; }
        }


    }
}
