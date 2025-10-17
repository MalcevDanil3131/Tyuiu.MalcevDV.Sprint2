using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MalcevDV.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 => 31,  // январь
                2 => 28,  // февраль (не високосный)
                3 => 31,  // март
                4 => 30,  // апрель
                5 => 31,  // май
                6 => 30,  // июнь
                7 => 31,  // июль
                8 => 31,  // август
                9 => 30,  // сентябрь
                10 => 31, // октябрь
                11 => 30, // ноябрь
                12 => 31, // декабрь
            };

            int nextYear = g;
            int nextMonth = m;
            int nextDay = n + 1;

            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth++;

                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }
    }
}
