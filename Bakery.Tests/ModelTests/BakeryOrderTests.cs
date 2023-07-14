using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BakeryOrderBreadTests
    {
        [TestMethod]
        public void Output_ReturnsBreadOrder()
        {
            int UserBread = 3;
            int BreadTotal = UserBread * 5;
            Bread newBread = new Bread(UserBread);

            int result = newBread.Output(UserBread);

            Assert.AreEqual(BreadTotal, result);
        }
    }
}