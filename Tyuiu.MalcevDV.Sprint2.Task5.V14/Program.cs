using Tyuiu.MalcevDV.Sprint2.Task5.V14.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #2", width);
PrintCenteredLine("Тема: Создание решения по таску", width);
PrintCenteredLine("Задание #3", width);
PrintCenteredLine("Вариант #26", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, которое вычисляет значение функции", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine("Введите d:", width);
DataService ds = new DataService();
var d = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k:", width);
var k = int.Parse(Console.ReadLine());
var res = ds.FindDayName(d, k);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{res}", width);
Console.WriteLine(new string('*', width));
