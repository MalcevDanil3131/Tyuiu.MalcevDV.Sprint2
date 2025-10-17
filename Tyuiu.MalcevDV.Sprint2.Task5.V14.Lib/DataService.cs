using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MalcevDV.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            int dayNumber = (d + k - 1) % 7;
            if (dayNumber == 0)
            {
                dayNumber = 7;
            }
            string dayOfWeek = dayNumber switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
            };

            return dayOfWeek;
        }
    }
}
