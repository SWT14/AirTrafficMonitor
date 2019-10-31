using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;




namespace AirTrafficMonitor
{
//    public class AirSpaceFilter : IAirSpaceFilter
//    {
      
        public Dictionary<string,ITrack> TrackDict { get; set; }
        public Dictionary<string,ITrackCalculator> TrackCalcDict { get; set; }
        public EventHandler<TrackinAirEvent> TrackUpdated;
        public List<ITrack> trackList { get; set; }

        public AirSpaceFilter(ITrackHandler trackhandler)
        {
            //Attaching the event to the constructor
            trackhandler.trackCreated += onTrackCreated;
            trackList = new List<ITrack>();
            TrackDict = new Dictionary<string, ITrack>();
            TrackCalcDict = new Dictionary<string, ITrackCalculator>();
        }

        public void onTrackCreated(object s, TrackEvent trackList)
        {
            Tracks = trackList.tracks;
            foreach (ITrack track in trackList)
            {
                if (TrackDict.ContainsKey(track.tag))
                {
                    if (TrackDict.Airspace)
                    {
                        Create(track);
                    }
                    else
                    {
                        TrackDict[track.tag] = track;
                    }
                }
                else
                {
                    TrackDict.Add(track.tag, track);
                }
            }
        }

        public void Create(ITrack track)
        {
            if (TrackDict.ContainsKey(track.tag))
            {
                TrackDict[track.tag] = new 
            }
        }

        public class TrackinAirEvent : EventArgs
        {
            public Dictionary<string, ITrackCalculator> tracks { get; set; }
        }


//    }
}
