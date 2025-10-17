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
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
            };

            return dayOfWeek;
        }
    }
}
