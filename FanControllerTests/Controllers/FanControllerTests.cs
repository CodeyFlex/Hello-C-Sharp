using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestAPI.Controllers;

namespace RestAPITests.Controllers
{
    [TestClass()]
    public class FanControllerTests
    {
        //Instance of FanSystem to be tested
        private readonly FanController _fanController = new FanController();

        [TestMethod()]
        public void GetTest()
        {
            Assert.AreEqual(_fanController.Get().Count(), 5);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.AreEqual(_fanController.GetById(3).GetId(), 3);
            Assert.AreEqual(_fanController.GetById(3).GetName(), "Fan Nominal");
        }
    }
}