using System;

namespace AirTrafficMonitor
{
    public interface ITrack
    {
        string tag { get; set; }
        double X_coor { get; set; }
        double Y_coor { get; set; }
        double Altitude { get; set; }
        double Velocity { get; set; }
        double CompassCourse { get; set; }
        DateTime timestamp { get; set; }
    }
}