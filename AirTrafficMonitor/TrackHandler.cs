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
        public void DataHandler(object T, RawTransponderDataEventArgs eventArgs)
        {
            foreach (var data in eventArgs.TransponderData)
            {
                // Split tracks
                var tracks = Tracksplitter(data.TransponderData);

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

    public class Track
            {
            public string tag { get; set; }
            public double X_coor { get; set; }
            public double Y_coor { get; set; }
            public double Altitude { get; set; }
            public double Velocity { get; set; }
            public DateTime timestamp { get; set; }
            }
}
