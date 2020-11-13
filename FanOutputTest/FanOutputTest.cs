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
            _fanSys.Id = 15;
            Assert.AreEqual(_fanSys.Id, 15);
        }

        [TestMethod]
        public void SetNameSuccessTest()
        {
            _fanSys.Name = "Martin";
            Assert.AreEqual(_fanSys.Name, "Martin");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Name is too short.")]
        public void SetNameFailTest()
        {
            _fanSys.Name = "M";
        }

        [TestMethod]
        public void SetTempSuccessTest()
        {
            _fanSys.Temp = 23;
            Assert.AreEqual(_fanSys.Temp, 23);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Temp value is invalid (Is less than 15, or more than 25.")]
        public void SetTempFailTest()
        {
            _fanSys.Temp = 99;
        }

        [TestMethod]
        public void SetHumiditySuccessTest()
        {
            _fanSys.Humidity = 43;
            Assert.AreEqual(_fanSys.Humidity, 43);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Humidity value is invalid (Is less than 30, or more than 80.")]
        public void SetHumidityFailTest()
        {
            _fanSys.Humidity = 89;
        }

        [TestMethod]
        public void ToStringTest()
        {
            _fanSys.ToString();
            Assert.AreEqual(_fanSys.ToString(), "Id: 1, Name: Hej, Temp: 20, Humidity: 40");
        }
    }
}
