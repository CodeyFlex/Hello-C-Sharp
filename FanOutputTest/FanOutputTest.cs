using System;
using ModelLib.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FanOutputTest
{
    [TestClass]
    public class FanOutputTest
    {
        //Instance of FanOutput Model to be tested
        private readonly FanOutput _fanOutputModel = new FanOutput();

        [TestMethod]
        public void SetIdTest()
        {
            _fanOutputModel.Id = 15;
            Assert.AreEqual(15, _fanOutputModel.Id);
        }

        [TestMethod]
        public void SetNameSuccessTest()
        {
            _fanOutputModel.Name = "Martin";
            Assert.AreEqual("Martin", _fanOutputModel.Name);
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
            Assert.AreEqual(23, _fanOutputModel.Temp);
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
            Assert.AreEqual(43, _fanOutputModel.Humidity);
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
            _fanOutputModel.Name = "Fan To String Test";
            _fanOutputModel.ToString();
            Assert.AreEqual("Id: 0, Name: Fan To String Test, Temp: 0, Humidity: 0", _fanOutputModel.ToString());
        }
    }
}
