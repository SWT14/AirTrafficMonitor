using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace AirTrafficMonitor
{
    public class Track : ITrack
    {
        public string tag { get; set; }
        public double X_coor { get; set; }
        public double Y_coor { get; set; }
        public double Altitude { get; set; }
        public double Velocity { get; set; }
        public double CompassCourse { get; set; }
        public DateTime timestamp { get; set; }
        public bool Airspace { get; set; }

        //public Track(string Tag, double X, double Y, double A)
        //{
        //    this.tag = Tag;
        //    this.X_coor = X;
        //    this.Y_coor = Y;
        //    this.Altitude = A;
        //    this.Airspace = FlightTrack(X, Y, A);
        //}

        public bool FlightTrack(double X, double Y, double A)
        {
            if (X >= 10000 && X <= 90000 && Y >= 10000 && Y <= 90000 && A >= 500 && A <= 20000)
            {
                return true;
            }
            return false;
        }
    }
}