using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MalcevDV.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double result;

            if (x > 0)
            {
                double inner = (x + 1) / Math.Cos(Math.Pow(x, 2));
                result = x + Math.Pow(inner, x);
            }
            else if (x == 0)
            {
                double denominator = Math.Pow(3, 2) - Math.Sin(Math.Pow(x, 2));
                result = (15 + x) / denominator;
            }
            else if (x > -30 && x < 0)
            {
                double inner = Math.Sin(Math.Pow(x, 3)) / (x + 5);
                result = Math.Pow(inner, x);
            }
            else
            {
                result = x + 7 * x - (1 / x);
            }

            return Math.Round(result, 3);
        }
    }
}
