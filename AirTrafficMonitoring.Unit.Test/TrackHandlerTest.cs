using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirTrafficMonitor;
using NSubstitute;
using NUnit.Framework;


namespace AirTrafficMonitoring.Unit.Test
{
    [TestClass]
    public class TrackHandlerTest
    {
        private TransponderReceiver.ITransponderReceiver _transponderReceiver;
        private List<TrackData> _trackData;

        private TransponderReceiver.RawTransponderDataEventArgs _fakeData;
        private TrackHandler _uut;
        private List<string> _list;
        private int _eventCalled;

        [SetUp]
        public void SetUp()
        {
            _transponderReceiver = Substitute.For<TransponderReceiver.ITransponderReceiver>();
            _trackData = new List<TrackData>();

            _fakeData = new TransponderReceiver.RawTransponderDataEventArgs(_list);
            _uut = new TrackHandlerTest();
            _eventCalled = 0;
            _list = new List<string>();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
