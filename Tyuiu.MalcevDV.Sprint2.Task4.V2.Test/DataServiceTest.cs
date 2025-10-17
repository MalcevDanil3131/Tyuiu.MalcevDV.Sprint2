using Tyuiu.MalcevDV.Sprint2.Task4.V2.Lib;
namespace Tyuiu.MalcevDV.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid1()
        {
            DataService ds = new DataService();
            var x = 5.0;
            var y = 1.0;
            var wait = 11.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void CheckValid2()
        {
            DataService ds = new DataService();
            var x = 5.0;
            var y = 2.0;
            var wait = 1.75;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
