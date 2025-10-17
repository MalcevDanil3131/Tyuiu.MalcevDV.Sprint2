using Tyuiu.MalcevDV.Sprint2.Task5.V14.Lib;
namespace Tyuiu.MalcevDV.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            int d = 1;
            int k = 5;
            var wait = "Пятница";
            var res = ds.FindDayName(d, k);
            Assert.AreEqual(wait, res);
        }
    }
}
