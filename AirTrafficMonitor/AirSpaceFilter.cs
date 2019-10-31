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
        public string Tag { get; set; }
        public double X_coor { get; set; }
        public double Y_coor { get; set; }
        public double Altitude { get; set; }
        public bool AirSpace { get; set; }

        public AirSpaceFilter(string Tag, double X, double Y, double A)
        {
            this.Tag = Tag;
            this.X_coor = X;
            this.Y_coor = Y;
            this.Altitude = A;
            this.AirSpace = FilterTracks(X, Y, A);

        }

        foreach(Track in _TrackList)
            {
            
            }



        public bool FilterTracks(double X, double Y, double A)
        {
            if (X >= 10000 && X <= 90000 && Y >= 10000 && Y <= 90000 && A >= 500 && A <= 20000)
            {
                return true;
            }
            else
                return false;
        }

        

    }
}
