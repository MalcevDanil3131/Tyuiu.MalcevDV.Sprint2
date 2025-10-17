using Tyuiu.MalcevDV.Sprint2.Task6.V11.Lib;
namespace Tyuiu.MalcevDV.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 12;
            int n = 31;
            var res = ds.FindDateOfNextDay(g, m, n);
            var wait = "01.01.2024";
            Assert.AreEqual(res, wait);
        }
    }
}
