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
            int UserBread = 6;
            int breadTotal = UserBread * 5;
            int freeLoaves = UserBread / 3;
            breadTotal -= (freeLoaves * 5);
            Bread newBread = new Bread(UserBread);

            int result = newBread.Output(UserBread);

            Assert.AreEqual(breadTotal, result);
        }

        [TestMethod]
        public void Output_ReturnsPastryOrder()
        {
            int UserPastry = 4;
            int pastryTotal = UserPastry * 2;
            int freePastries = UserPastry / 4;
            pastryTotal -= (freePastries * 3);
            Pastry pastryOutput = new Pastry(UserPastry);

            int result2 = pastryOutput.Output2(UserPastry);

            Assert.AreEqual(pastryTotal, result2);

        }
    }
}