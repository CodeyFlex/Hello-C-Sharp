using System;
using ModelLib.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FanOutputTest
{
    [TestClass]
    public class FanOutputTest
    {
        //Instance of FanSystem to be tested
        private readonly FanOutput _fanSys = new FanOutput(1, "Hej", 20, 40);

        [TestMethod]
        public void SetIdTest()
        {
            _fanSys.SetId(15);
            Assert.AreEqual(_fanSys.GetId(), 15);
        }

        [TestMethod]
        public void SetNameSuccessTest()
        {
            _fanSys.SetName("Martin");
            Assert.AreEqual(_fanSys.GetName(), "Martin");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Name is too short.")]
        public void SetNameFailTest()
        {
            _fanSys.SetName("M");
        }

        [TestMethod]
        public void SetTempSuccessTest()
        {
            _fanSys.SetTemp(23);
            Assert.AreEqual(_fanSys.GetTemp(), 23);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Temp value is invalid (Is less than 15, or more than 25.")]
        public void SetTempFailTest()
        {
            _fanSys.SetTemp(99);
        }

        [TestMethod]
        public void SetHumiditySuccessTest()
        {
            _fanSys.SetHumidity(43);
            Assert.AreEqual(_fanSys.GetHumidity(), 43);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Humidity value is invalid (Is less than 30, or more than 80.")]
        public void SetHumidityFailTest()
        {
            _fanSys.SetHumidity(89);
        }

        [TestMethod]
        public void GetFanDataTest()
        {
            _fanSys.GetFanData();
            Assert.AreEqual(_fanSys.GetFanData(), "Id: " + 1 + " Name: " + "Hej" + " Temp: " + 20 + " Humidity: " + 40);
        }
    }
}
