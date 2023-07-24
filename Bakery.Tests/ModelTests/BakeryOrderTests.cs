using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BakeryOrderBreadTests
    {

        [TestMethod]
        public void BreadOrderConstructor_CreatesNewBreadOrder()
        {
            Bread newBread = new Bread(6);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
        [TestMethod]
        public void Output_ReturnsBreadOrder_NoDiscount()
        {
            int UserBread = 2;
            int breadTotal = UserBread * 5;
            Bread newBread = new Bread(UserBread);

            int result = newBread.Output(UserBread);

            Assert.AreEqual(breadTotal, result);
        }

        [TestMethod]
        public void Output_ReturnsBreadOrder_WithDiscount()
        {
            int UserBread = 6;
            int freeLoaves = UserBread / 3;
            int breadTotal = UserBread * 5;
            breadTotal -= (freeLoaves * 5);
            Bread newBread = new Bread(UserBread);

            int result = newBread.Output(UserBread);

            Assert.AreEqual(breadTotal, result);
        }

        [TestMethod]
        public void Output_ReturnsPastryOrder_NoDiscount()
        {
            int UserPastry = 3;
            int pastryTotal = UserPastry * 2;
            Pastry pastryOutput = new Pastry(UserPastry);

            int result2 = pastryOutput.Output2(UserPastry);

            Assert.AreEqual(pastryTotal, result2);
        }

        [TestMethod]
        public void Output_ReturnsPastryOrder_WithDiscount()
        {
            int UserPastry = 4;
            int pastryTotal = UserPastry * 2;
            int freePastries = UserPastry / 4;
            pastryTotal -= (freePastries * 2);
            Pastry pastryOutput = new Pastry(UserPastry);

            int result2 = pastryOutput.Output2(UserPastry);

            Assert.AreEqual(pastryTotal, result2);

        }
    }
}