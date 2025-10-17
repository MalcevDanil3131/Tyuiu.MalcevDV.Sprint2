using Tyuiu.MalcevDV.Sprint2.Task3.V26.Lib;
namespace Tyuiu.MalcevDV.Sprint2.Task3.V26.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            var x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, 4.702);
        }
    }
}
