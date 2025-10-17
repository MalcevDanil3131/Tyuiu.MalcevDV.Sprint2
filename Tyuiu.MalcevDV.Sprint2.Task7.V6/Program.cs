using Tyuiu.MalcevDV.Sprint2.Task7.V6.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #2", width);
PrintCenteredLine("Тема: Создание итогового решения по спринту", width);
PrintCenteredLine("Задание #7", width);
PrintCenteredLine("Вариант #6", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, которое вычисляет значение функции", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine("Введите x:", width);
DataService ds = new DataService();
var x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y:", width);
var y = int.Parse(Console.ReadLine());
var res = ds.CheckDotInShadedArea(x,y);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{res}", width);
Console.WriteLine(new string('*', width));