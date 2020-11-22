using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Testing these
using RestAPI.Controllers;
using ModelLib.model;


namespace RestAPITests.Controllers
{
    [TestClass()]
    public class FanControllerTests
    {
        //Instance of FanController to be tested
        private readonly FanController _fanController = new FanController();

        //Instance of FanOutput Model to be tested
        private readonly FanOutput _fanOutputModel = new FanOutput(5, "Fan Test", 20, 40);

        //Instance of FilterFan Model to be tested
        private readonly FilterFan _filterFan = new FilterFan(20, 22);

        [TestMethod()]
        public void GetTest()
        {
            Assert.AreEqual(5, _fanController.Get().Count());
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.AreEqual(2, _fanController.GetById(2).Id);
            Assert.AreEqual("Fan Nominal", _fanController.GetById(2).Name);
        }

        [TestMethod()]
        public void GetByNameTest()
        {
            Assert.AreEqual((5), _fanController.GetByName("Fan").Count());
        }

        [TestMethod()]
        public void GetByTempTest()
        {
            Assert.AreEqual((1), _fanController.GetByTemp(24).Count());
        }

        [TestMethod()]
        public void GetByHumidityTest()
        {
            Assert.AreEqual((1), _fanController.GetByHumidity(59).Count());
        }

        [TestMethod()]
        public void PostTest()
        {
            _fanController.Post(_fanOutputModel);
            Assert.AreEqual("Fan Test", _fanController.GetById(_fanOutputModel.Id).Name);
        }

        [TestMethod()]
        public void PutTest()
        {
            _fanController.Put(4, new FanOutput(4, "Fan Put Test", 20, 40));
            Assert.AreEqual("Fan Put Test", _fanController.GetById(4).Name);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.NullReferenceException), "Model was succesfully deleted, and then not found")]
        public void DeleteTest()
        {
            Assert.AreEqual("Fan Test", _fanController.GetById(_fanOutputModel.Id).Name);
            _fanController.Delete(_fanOutputModel.Id);
            Assert.AreEqual("Fan Test", _fanController.GetById(_fanOutputModel.Id).Name);
        }

        [TestMethod()]
        
        public void SearchTempBelowTest()
        {
            Assert.AreEqual(4, _fanController.SearchTempBelow(21).Count());
        }

        [TestMethod()]
        public void SearchTempAboveTest()
        {
            Assert.AreEqual(2, _fanController.SearchTempAbove(21).Count());
        }

        [TestMethod()]
        public void SearchHumidityBelowTest()
        {
            Assert.AreEqual(5, _fanController.SearchHumidityBelow(48).Count());
        }

        [TestMethod()]
        public void SearchHumidityAboveTest()
        {
            Assert.AreEqual(1, _fanController.SearchHumidityAbove(50).Count());
        }

        [TestMethod()]
        public void SearchTest()
        {
            Assert.AreEqual(_fanController.GetById(3), _fanController.Search(_filterFan));
        }
    }
}