using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor
{
    class ConsoleWriter : IConsoleWriter
    {
        public void printPlanes(List<ITrack> tracklist)
        {

            foreach (Track track in tracklist)
            {
                Console.WriteLine("flynummer:" + track.tag + "X coordinat:" + track.X_coor + "Y coordinat:" + track.Y_coor + "højde:" + track.Altitude + "meter" + track.CompassCourse + track.timestamp);
            }
        }


    }

}
