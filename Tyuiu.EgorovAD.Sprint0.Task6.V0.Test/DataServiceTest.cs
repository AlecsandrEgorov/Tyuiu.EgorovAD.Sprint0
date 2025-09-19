using Tyuiu.EgorovAD.Sprint0.Task6.V0.Lib;
namespace Tyuiu.EgorovAD.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numders = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numders);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var numders = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numders);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var numders = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numders);
            Assert.AreEqual(120, res);
        }

    }

}
