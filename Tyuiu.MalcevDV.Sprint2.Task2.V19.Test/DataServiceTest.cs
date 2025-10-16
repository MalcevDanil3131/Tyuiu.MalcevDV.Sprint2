using Tyuiu.MalcevDV.Sprint2.Task2.V19.Lib;
namespace Tyuiu.MalcevDV.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Checkvalid()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(true, res);
        }
    }
}
