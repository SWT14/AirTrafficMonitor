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
        private RawTransponderDataEventArgs _eventArgs;
        private object _t;

        public List<Track> _trackList;
        
        private ITransponderReceiver _receiver;
        //Constructor injection for dependency
        public TrackHandler(ITransponderReceiver receiver, object t, RawTransponderDataEventArgs eventArgs)
        {
            // Initerere objekter
            _t = t;
            //_eventArgs = eventArgs;

            //Store real or fake transponder receiver
            this._receiver = receiver;

            //Attach the event to the real or fake Transponder receiver
            _receiver.TransponderDataReady += DataHandler;
        }

        public void DataHandler(object t, RawTransponderDataEventArgs eventArgs, List<Track> tracklist)
        {
            _trackList = new List<Track>();

            foreach (var data in eventArgs.TransponderData)
            {
                // Split tracks
                var Rawtrack = Rawhandler(eventArgs.TransponderData);
                Rawtrack.Split(); // virker det m¨ske?
                // Put tracks i wrapper
                var newTrackArgs = new NewTrackArgs
                {
                    _trackList = tracklist
                };

                // Send Event
               // sendEvent(newTrackArgs);
            }
        }

        public string Rawhandler(public List<string> Rawtracks)
        {

            return Track;
        }

         public int bobsdfsdf(int)
         { 
    
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
