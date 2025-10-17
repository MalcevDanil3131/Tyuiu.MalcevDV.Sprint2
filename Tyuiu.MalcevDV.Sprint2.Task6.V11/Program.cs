using Tyuiu.MalcevDV.Sprint2.Task6.V11.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #2", width);
PrintCenteredLine("Тема: Создание решения по таску", width);
PrintCenteredLine("Задание #6", width);
PrintCenteredLine("Вариант #11", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, которое вычисляет значение функции", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine("Введите g:", width);
DataService ds = new DataService();
var g = int.Parse(Console.ReadLine());
Console.WriteLine("Введите m:", width);
var m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:", width);
var n = int.Parse(Console.ReadLine());
var res = ds.FindDateOfNextDay(g, m, n);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{res}", width);
Console.WriteLine(new string('*', width));