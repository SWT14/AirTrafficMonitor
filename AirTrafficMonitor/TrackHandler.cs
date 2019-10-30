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
        public List<Track> TrackList;

        private ITransponderReceiver receiver;
        //Constructor injection for dependency
        public TrackHandler(ITransponderReceiver receiver)
        {
            //Store real or fake transponder receiver
            this.receiver = receiver;

            //Attach the event to the real or fake Transponder receiver
            receiver.TransponderDataReady += DataHandler;
        }
        public void DataHandler(object T, RawTransponderDataEventArgs eventArgs)
        {
            TrackList = new List<Tracks>();

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

        public void Tracksplitter()
        {

        }
    }
}
