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

        public void Rawhandler(string data)
        {
            //Use ";" as seperator for splitting data
            var _data = data.Split(';');
            var TagId = _data[0];  //Item 1 is the tagid
            var Xcoor = Int32.Parse(_data[1]); //Item 2 is the coordinate for 'X'
            var Ycoor = Int32.Parse(_data[2]); //Item 3 is the coordinate for 'Y'
            var altitude = Int32.Parse(_data[3]); //Item 4 is the altitude
            var dateTime = DateTime.ParseExact(_data[4], //Item 5 is the exact time
                "yyyyMMddHHmmssfff",
                null,
                DateTimeStyles.None);

            var track = new Track
            {
                tag = TagId,
                X_coor = Xcoor,
                Y_coor = Ycoor,
                Altitude = altitude,
                timestamp = dateTime
            };
            _trackList.Add(track);
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
