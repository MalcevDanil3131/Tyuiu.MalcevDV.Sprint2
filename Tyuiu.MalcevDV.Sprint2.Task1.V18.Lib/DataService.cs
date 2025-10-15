using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MalcevDV.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = !(a > d);
            result[1] = (a < b) & (c != d);
            result[2] = (a < b) || (c > d);
            result[3] = (a > d) && (c < d);
            result[4] = !(a == d);
            result[5] = (a < b) ^ (d >= c);
            return result;
        }
    }
}
