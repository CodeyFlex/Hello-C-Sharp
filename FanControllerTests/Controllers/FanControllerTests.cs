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

        [TestMethod()]
        public void GetTest()
        {
            Assert.AreEqual(_fanController.Get().Count(), 5);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.AreEqual(_fanController.GetById(2).Id, 2);
            Assert.AreEqual(_fanController.GetById(2).Name, "Fan Nominal");
        }

        [TestMethod()]
        public void PostTest()
        {
            _fanController.Post(_fanOutputModel);
            Assert.AreEqual(_fanController.GetById(_fanOutputModel.Id).Name, "Fan Test");
        }

        [TestMethod()]
        public void PutTest()
        {
            _fanController.Put(4, new FanOutput(4, "Fan Put Test", 20, 40));
            Assert.AreEqual(_fanController.GetById(4).Name, "Fan Put Test");
        }

        [TestMethod()]
        [ExpectedException(typeof(System.NullReferenceException), "Model was succesfully deleted, and then not found")]
        public void DeleteTest()
        {
            Assert.AreEqual(_fanController.GetById(_fanOutputModel.Id).Name, "Fan Test");
            _fanController.Delete(_fanOutputModel.Id);
            Assert.AreEqual(_fanController.GetById(_fanOutputModel.Id).Name, "Fan Test");
        }
    }
}