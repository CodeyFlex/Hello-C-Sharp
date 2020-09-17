using System;
using FanSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FanOutputTest
{
    [TestClass]
    public class FanOutputTest
    {
        //Instance of FanSystem to be tested
        FanOutput FanSys = new FanOutput();

        [TestMethod]
        public void setIdTest()
        {
            FanSys.setId(15);
            Assert.AreEqual(FanSys.getId(), 15);
        }

        [TestMethod]
        public void setNameSuccessTest()
        {
            FanSys.setName("Martin");
            Assert.AreEqual(FanSys.getName(), "Martin");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Name is too short.")]
        public void setNameFailTest()
        {
            FanSys.setName("M");
        }

        [TestMethod]
        public void setTempSuccessTest()
        {
            FanSys.setTemp(23);
            Assert.AreEqual(FanSys.getTemp(), 23);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Temp value is invalid (Less than 15, or more than 25.")]
        public void setTempFailTest()
        {
            FanSys.setTemp(99);
        }

        [TestMethod]
        public void setHumiditySuccessTest()
        {
            FanSys.setHumidity(43);
            Assert.AreEqual(FanSys.getHumidity(), 43);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Humidity value is invalid (Less than 30, or more than 80.")]
        public void setHumidtyFailTest()
        {
            FanSys.setTemp(89);
        }
    }
}
