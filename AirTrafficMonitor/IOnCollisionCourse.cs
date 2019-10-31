using System;
using System.Collections.Generic;

namespace AirTrafficMonitor
{
    public interface IOnCollisionCourse
    {
        event EventHandler<OnCollisionCourse.SeperationEvent> CreateSeperation;

        double Span(ITrackCalculator track1, ITrackCalculator track2)
        void TrackInAirSpace(TrackEvent TEtracks); 
        Dictionary<String, TrackCalculator> _tracks { get; set; }
        
    }
}