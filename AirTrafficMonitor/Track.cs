using System;

namespace AirTrafficMonitor
{
    public class Track
    {
        public string tag { get; set; }
        public double X_coor { get; set; }
        public double Y_coor { get; set; }
        public double Altitude { get; set; }
        public double Velocity { get; set; }
        public double CompassCourse { get; set; }
        public DateTime timestamp { get; set; }
    }
}