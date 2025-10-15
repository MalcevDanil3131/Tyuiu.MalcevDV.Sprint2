using Tyuiu.MalcevDV.Sprint2.Task0.V19.Lib;
namespace Tyuiu.MalcevDV.Sprint2.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            var ds = new DataService();
            int x = 105;
            int y = 177;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true, true, true, true, true, true } ;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
