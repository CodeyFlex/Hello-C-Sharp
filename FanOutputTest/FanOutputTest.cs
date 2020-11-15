using System;
using ModelLib.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FanOutputTest
{
    [TestClass]
    public class FanOutputTest
    {
        //Instance of FanSystem to be tested
        private readonly FanOutput _fanOutputModel = new FanOutput(5, "Fan Test", 20, 40);

        [TestMethod]
        public void SetIdTest()
        {
            _fanOutputModel.Id = 15;
            Assert.AreEqual(_fanOutputModel.Id, 15);
        }

        [TestMethod]
        public void SetNameSuccessTest()
        {
            _fanOutputModel.Name = "Martin";
            Assert.AreEqual(_fanOutputModel.Name, "Martin");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Name is too short.")]
        public void SetNameFailTest()
        {
            _fanOutputModel.Name = "M";
        }

        [TestMethod]
        public void SetTempSuccessTest()
        {
            _fanOutputModel.Temp = 23;
            Assert.AreEqual(_fanOutputModel.Temp, 23);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Temp value is invalid (Is less than 15, or more than 25.")]
        public void SetTempFailTest()
        {
            _fanOutputModel.Temp = 99;
        }

        [TestMethod]
        public void SetHumiditySuccessTest()
        {
            _fanOutputModel.Humidity = 43;
            Assert.AreEqual(_fanOutputModel.Humidity, 43);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Humidity value is invalid (Is less than 30, or more than 80.")]
        public void SetHumidityFailTest()
        {
            _fanOutputModel.Humidity = 89;
        }

        [TestMethod]
        public void ToStringTest()
        {
            _fanOutputModel.ToString();
            Assert.AreEqual(_fanOutputModel.ToString(), "Id: 5, Name: Fan Test, Temp: 20, Humidity: 40");
        }
    }
}
