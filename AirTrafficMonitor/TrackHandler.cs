using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace AirTrafficMonitor
{
    public class TrackHandler : ITrackHandler
    {
        public List<Track> _trackList;
        
        private ITransponderReceiver _receiver;
        //Constructor injection for dependency
        public TrackHandler(ITransponderReceiver receiver)
        {
            
            //Store real or fake transponder receiver
            this._receiver = receiver;

            //Attach the event to the real or fake Transponder receiver
            _receiver.TransponderDataReady += DataHandler;
        }

        public void DataHandler(object t, RawTransponderDataEventArgs eventArgs)
        {
            _trackList = new List<Track>();

            foreach (var data in eventArgs.TransponderData)
            {
                Rawhandler(data);
                // Split tracks
                // Send Event
               // sendEvent(newTrackArgs);
            }
        }

        public string Rawhandler(string data)
        {

            return Track;
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
