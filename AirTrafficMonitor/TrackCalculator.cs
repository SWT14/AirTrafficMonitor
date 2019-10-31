using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor
{
    public class TrackCalculator 
    {
        public string tag { get; set; }
        public double X_coor { get; set; }
        public double Y_coor { get; set; }
        public double Altitude { get; set; }
        public double Velocity { get; set; }
        public double CompassCourse { get; set; }
        public DateTime timestamp { get; set; }

        public TrackCalculator(IAirSpaceFilter trackBefore, IAirSpaceFilter trackNow)
        {
            this.tag = trackNow
            X_coor = trackNow.;
            Y_coor = trackNow._yCoordinate;
            this.Altitude = trackNow._altitude;
            Velocity = VelocityCalculation(trackBefore._xCoordinate, X_coor, trackBefore._yCoordinate,
                Y_coor, trackBefore._dateTime, timestamp);
            CompassCourse = CompassCourseCalculation(trackBefore._xCoordinate, X_coor, trackBefore._yCoordinate,
                Y_coor);
        }

        public VelocityCalculation(double X_coor1, double X_coor2, double Y_coor1, double Y_coor2,
            DateTime timestamp1, DateTime timestamp2)
        {
            double difference = CompassCourseCalculation(X_coor1, X_coor2, Y_coor1, Y_coor2)
            TimeSpan timeSpan = timestamp1 - timestamp2;
            double timedifference = timeSpan.TotalMilliseconds / 1000;
            double velocity = difference / timedifference;
            return velocity;
        }

        public double CompassCourseCalculation(double X_coor1, double X_coor2, double Y_coor1, double Y_coor2)
        {
            double difference = Math.Sqrt((Math.Pow((X_coor1 - X_coor2), 2) + Math.Pow((Y_coor1 - Y_coor2), 2)));
            return difference;

        }
    }
}
