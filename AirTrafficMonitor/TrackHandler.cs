using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace AirTrafficMonitor
{
    public class TrackHandler : ITrackHandler
    {
        public void DataHandler(object Track, RawTransponderDataEventArgs eventArgs)
        {
            foreach (var data in eventArgs.TransponderData)
            {
                // Split tracks
                var tracks = SplitData(data.TransponderData);

                // Put tracks i wrapper
                var newTrackArgs = new NewTrackArgs
                {
                    Tracks = tracks
                };

                // Send Event
                sendEvent(newTrackArgs);
            }
        }
    }
}
