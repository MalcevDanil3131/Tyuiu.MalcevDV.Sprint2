using Tyuiu.MalcevDV.Sprint2.Task7.V6.Lib;
namespace Tyuiu.MalcevDV.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.CheckDotInShadedArea(x, y);
            var wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
