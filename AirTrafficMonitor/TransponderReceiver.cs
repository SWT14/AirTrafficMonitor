﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace AirTrafficMonitor
{
    public class TransponderReceiver
    {
        public class RawTransponderDataEventArgs : EventArgs
        {
            public RawTransponderDataEventArgs(List<string> transponderData)
            {
                TransponderData = transponderData;
            }
            public List<string> TransponderData { get; }
        }

        public interface ITransponderReceiver
        {
            event EventHandler<RawTransponderDataEventArgs> TransponderDataReady;
        }

        public class TransponderReceiverFactory
        {
            public static ITransponderReceiver CreateTransponderDataReceiver { get; }
        }

        
    }
}