using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitor;

namespace AirTrafficMonitor
{
    public interface IAirSpaceFilter
    {
        string tag { get; set; }
        double X_coor { get; set; }
        double Y_coor { get; set; }
        double Altitude { get; set; }
        bool AirSpace { get; set; }
        bool FilterTracks(double X, double Y, double A);
    }
}
