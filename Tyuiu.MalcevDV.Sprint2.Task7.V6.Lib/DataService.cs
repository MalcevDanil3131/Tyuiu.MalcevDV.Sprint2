using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MalcevDV.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double r2 = x * x + y * y;
            return (r2 >= 1 && r2 <= 4 && y >= 0);
        }
    }
}
