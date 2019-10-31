using System;
using System.Collections.Generic;
using System.Globalization;
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
        public List<ITrack> _trackList;
        
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
            _trackList = new List<ITrack>();

            foreach (var data in eventArgs.TransponderData)  // kalder Rawhandler på hvert track den modtager.
            {
                Rawhandler(data);
                // Split tracks
                // Send Event
               // sendEvent(newTrackArgs);

            }
            
        }

        public void Rawhandler(String data) // tager data fra TransponderData som parameter og konvertere det til Tracks
        {           
            var _data = data.Split(';');
            var TagId = _data[0];
            var Xcoor = Int32.Parse(_data[1]);
            var Ycoor = Int32.Parse(_data[2]); 
            var altitude = Int32.Parse(_data[3]); 
            var dateTime = DateTime.ParseExact(_data[4], 
                "yyyyMMddHHmmssfff",
                null,
                DateTimeStyles.None); //anveder datetime til at give os dato og tid på dagen.
            var track = new Track
            {
                tag = TagId,
                X_coor = Xcoor,
                Y_coor = Ycoor,
                Altitude = altitude,
                timestamp = dateTime
            };
            _trackList.Add(track);  // tilføjer tracket til _tracklist efter det er konveteret til et objekt af typen Track
            System.Console.WriteLine(_trackList);
            System.Console.WriteLine(data);
        }
    }
}
