using System.Collections.Generic;

namespace AirTrafficMonitor
{
    interface IConsoleWriter
    {
        void printPlanes(List<ITrack> tracklist);
    }
}