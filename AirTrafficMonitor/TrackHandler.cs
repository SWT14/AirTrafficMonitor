using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitor
{
    class TrackHandler : ITrackHandler
    {
        private void ReceiverOnTransponderDataReady(object sender, RawTransponderDataEventArgs e)
        {
            // Just display datadata
            foreach (var data in e.TransponderData)
            {
                System.Console.WriteLine($"Transponderdata {}");
            }
        }


    }
}
