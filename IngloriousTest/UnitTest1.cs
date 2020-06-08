using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IngloriousTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;
            int[] a = { 1, 5, 4, -7, 30 };

            int resproduct = IngloriousLab2._3.Program.Product(n, a);
            int ressum = IngloriousLab2._3.Program.ElementsSum(n, a);

            Assert.AreEqual(-35, resproduct);
            Assert.AreEqual(3, ressum);
        }
    }
}
